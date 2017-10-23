using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using SpacingGame.Model;

namespace SpacingGame
{
    public partial class SGView : Form
    {
        private GameModel       model;
        private PictureBox[,]   gameGrid;
        private Tablesize       tablesize;
        private bool            isFirstGame;
        private bool            isPauseMode;
        private Timer           moveAsteroidsTimer;
        private Timer           addNewAsteroidsTimer;
        private Timer           increaseAsteroidsNumberTimer;
        private const string    asteroidImageLocation   = "..\\..\\Images\\asteroid_23x23.png";
        private const string    spaceshipImageLocation  = "..\\..\\Images\\spaceship_23x23.png";
        private Stopwatch       gameDuration;
        



        public SGView()
        {
            InitializeComponent();
            isFirstGame     = true;
            tablesize       = new Tablesize(23, 23);
            gameDuration    = new Stopwatch();
        }


        private void NewGameButton_Clicked(object sender, EventArgs e)
        {
            if(isFirstGame)
            {
                KeyPreview = true;

                this.gameTablePanel.Controls.Remove(welcomeLabel);
                this.gameTablePanel.Controls.Remove(welcomePictureBox);

                moveAsteroidsTimer = new Timer();
                moveAsteroidsTimer.Interval = 100;
                moveAsteroidsTimer.Tick += new EventHandler(MoveAsteroids_Tick);

                addNewAsteroidsTimer = new Timer();
                addNewAsteroidsTimer.Interval = 700;
                addNewAsteroidsTimer.Tick += new EventHandler(AddNewAsteroids_Tick);

                increaseAsteroidsNumberTimer = new Timer();
                increaseAsteroidsNumberTimer.Interval = 1500;
                increaseAsteroidsNumberTimer.Tick += new EventHandler(IncreaseAsteroids_Tick);

                KeyDown                                 += new KeyEventHandler(MoveSpaceship_KeyDown);
                isFirstGame = false;
            }
            
            model = new GameModel(tablesize);
            CreateTable();
            SetSpaceshipImage(Image.FromFile(spaceshipImageLocation));

            model.GameOver += new EventHandler<GameEventArgs>(Game_GameOver);

            


            StartTimers();
            isPauseMode = false;
            pauseButton.Show();
            gameDuration.Restart();
        }


        private void CreateTable()
        {
            if (gameGrid != null)
            {
                for (int i = 0; i < tablesize.first; ++i)
                {
                    for (int j = 0; j < tablesize.second; ++j)
                    {
                        gameTablePanel.Controls.Remove(gameGrid[i, j]);
                    }
                }
            }

            gameGrid = new PictureBox[tablesize.first, tablesize.second];

            for (Int32 i = 0; i < tablesize.first; ++i)
            {
                for (Int32 j = 0; j < tablesize.second; ++j)
                {
                    gameGrid[i, j] = new PictureBox();
                    gameGrid[i, j].Location = new Point(j * 22, i * 22);
                    gameGrid[i, j].Size = new Size(22, 22);
                    gameGrid[i, j].Enabled = false;
                    gameGrid[i, j].TabIndex = 100 + i * tablesize.first + j;
                    gameGrid[i, j].BackColor = Color.Black;

                    gameTablePanel.Controls.Add(gameGrid[i, j]);
                }
            }
        }


        private void MoveAsteroids_Tick(Object sender, EventArgs e)
        {
            SetAsteroidsImage(null);

            model.MoveDownAllAsteroids();

            SetAsteroidsImage(Image.FromFile(asteroidImageLocation));
        }

        private void SetAsteroidsImage(Image image)
        {
            var asteroids = model.ASTEROIDS;
            foreach (var asteroid in asteroids)
            {
                var koordinates = asteroid.KOORDINATE;
                gameGrid[koordinates.second, koordinates.first].Image = image;
            }
        }

        private void SetSpaceshipImage(Image image)
        {
            var spaceshipkoor = model.SPACESHIP.KOORDINATE;
            gameGrid[spaceshipkoor.second, spaceshipkoor.first].Image = image;
        }


        private void AddNewAsteroids_Tick(Object sender, EventArgs e)
        {
            model.AddNewAsteroids();
        }


        private void IncreaseAsteroids_Tick(Object sender, EventArgs e)
        {
            model.CreateMoreAsteroids(1);
        }

        private void MoveSpaceship_KeyDown(Object sender, KeyEventArgs e)
        {
            SetSpaceshipImage(null);
            if (e.KeyCode == Keys.D)
                model.MoveSpaceShipRight();
            if (e.KeyCode == Keys.A)
                model.MoveSpaceShipLeft();
            SetSpaceshipImage(Image.FromFile(spaceshipImageLocation));
        }

        
        private void Game_GameOver(Object sender, GameEventArgs e)
        {
            StopTimers();
            pauseButton.Hide();
            if (gameGrid != null)
            {
                for (int i = 0; i < tablesize.first; ++i)
                {
                    for (int j = 0; j < tablesize.second; ++j)
                    {
                        gameTablePanel.Controls.Remove(gameGrid[i, j]);
                    }
                }
            }
            gameDuration.Stop();
            TimeSpan ts = gameDuration.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                                                ts.Minutes, ts.Seconds,ts.Milliseconds/10);
            MessageBox.Show("Sajnos a játék itt véget ért, aszteroidának ütköztél!" + Environment.NewLine +
                            "Ennyi időt játszottál: " + elapsedTime,
                                "Játék vége",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
        }


        #region MenuButtonsEventHandlers
        private void Pause_Click(Object sender, EventArgs e)
        {
            if (!isPauseMode)
            {
                StopTimers();
                gameDuration.Stop();
                KeyDown -= MoveSpaceship_KeyDown;
            }
            else
            {
                StartTimers();
                gameDuration.Start();
                KeyDown += MoveSpaceship_KeyDown;
            }
            isPauseMode = !isPauseMode;
        }


        private void ExitButton_Clicked(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void StartTimers()
        {
            moveAsteroidsTimer.Start();
            addNewAsteroidsTimer.Start();
            increaseAsteroidsNumberTimer.Start();
        }

        private void StopTimers()
        {
            moveAsteroidsTimer.Stop();
            addNewAsteroidsTimer.Stop();
            increaseAsteroidsNumberTimer.Stop();
        }
    }
}
