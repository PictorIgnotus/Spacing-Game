namespace SpacingGame
{
    partial class SGView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGView));
            this.gameTablePanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTablePanel
            // 
            this.gameTablePanel.BackColor = System.Drawing.Color.Black;
            this.gameTablePanel.Controls.Add(this.welcomeLabel);
            this.gameTablePanel.Controls.Add(this.welcomePictureBox);
            this.gameTablePanel.Location = new System.Drawing.Point(39, 12);
            this.gameTablePanel.MaximumSize = new System.Drawing.Size(506, 506);
            this.gameTablePanel.MinimumSize = new System.Drawing.Size(506, 506);
            this.gameTablePanel.Name = "gameTablePanel";
            this.gameTablePanel.Size = new System.Drawing.Size(506, 506);
            this.gameTablePanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeLabel.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Location = new System.Drawing.Point(105, 2);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(305, 59);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Spacing Game";
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomePictureBox.Image = global::SpacingGame.Properties.Resources.asteroidfield_399x433;
            this.welcomePictureBox.InitialImage = global::SpacingGame.Properties.Resources.asteroidfield_399x433;
            this.welcomePictureBox.Location = new System.Drawing.Point(53, 64);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.Size = new System.Drawing.Size(399, 433);
            this.welcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcomePictureBox.TabIndex = 1;
            this.welcomePictureBox.TabStop = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(39, 576);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(136, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Clicked);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(225, 576);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(136, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.Pause_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(409, 576);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Clicked);
            // 
            // SGView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameTablePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 650);
            this.MinimumSize = new System.Drawing.Size(600, 650);
            this.Name = "SGView";
            this.Text = "Spacing Game";
            this.gameTablePanel.ResumeLayout(false);
            this.gameTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameTablePanel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox welcomePictureBox;
    }
}

