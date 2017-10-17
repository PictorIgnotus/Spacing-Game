using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Timer           increaseAsteroidsNumberTimer;


        public SGView()
        {
            InitializeComponent();
            isFirstGame = true;
            tablesize = new Tablesize(23, 23);
        }


        private void NewGameButton_Clicked(object sender, EventArgs e)
        {
            if(isFirstGame)
            {
                this.gameTablePanel.Controls.Remove(welcomeLabel);
                this.gameTablePanel.Controls.Remove(welcomePictureBox);
                isFirstGame = false;
            }

            model = new GameModel(tablesize);
            CreateTable();

            moveAsteroidsTimer                      = new Timer();
            moveAsteroidsTimer.Interval             = 1000;
            moveAsteroidsTimer.Tick                 += new EventHandler(MoveAsteroids_Tick);
            increaseAsteroidsNumberTimer            = new Timer();
            increaseAsteroidsNumberTimer.Interval   = 5000;
            increaseAsteroidsNumberTimer.Tick       += new EventHandler(IncreaseAsteroids_Tick);

            moveAsteroidsTimer.Start();
            increaseAsteroidsNumberTimer.Start();
            isPauseMode = false;
            pauseButton.Show();
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
                    gameGrid[i, j].BackColor = Color.White;

                    gameTablePanel.Controls.Add(gameGrid[i, j]);
                }
            }
        }


        private void MoveAsteroids_Tick(Object sender, EventArgs e)
        {
            model.AddNewAsteroids();
            model.MoveDownAllAsteroids();
        }

        private void IncreaseAsteroids_Tick(Object sender, EventArgs e)
        {
            model.CreateMoreAsteroids(1);
        }

        #region MenuButtonsEventHandlers
        private void Pause_Click(Object sender, EventArgs e)
        {
            if (!isPauseMode)
            {
                moveAsteroidsTimer.Stop();
                increaseAsteroidsNumberTimer.Stop();
            }
            else
            {
                moveAsteroidsTimer.Start();
                increaseAsteroidsNumberTimer.Start();
            }
        }


        private void ExitButton_Clicked(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
