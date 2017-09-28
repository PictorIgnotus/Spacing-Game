using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpacingGame
{
    public partial class SGView : Form
    {
        private bool firstGame;

        public SGView()
        {
            InitializeComponent();
            firstGame = true;
        }

        private void NewGameButton_Clicked(object sender, EventArgs e)
        {
            this.gameTablePanel.Controls.Remove(welcomeLabel);
            this.gameTablePanel.Controls.Remove(welcomePictureBox);
        }

        private void ExitButton_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
