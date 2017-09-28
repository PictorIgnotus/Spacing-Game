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
            this.button2 = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTablePanel
            // 
            this.gameTablePanel.BackColor = System.Drawing.Color.Black;
            this.gameTablePanel.Controls.Add(this.button2);
            this.gameTablePanel.Location = new System.Drawing.Point(39, 12);
            this.gameTablePanel.MaximumSize = new System.Drawing.Size(506, 500);
            this.gameTablePanel.MinimumSize = new System.Drawing.Size(506, 500);
            this.gameTablePanel.Name = "gameTablePanel";
            this.gameTablePanel.Size = new System.Drawing.Size(506, 500);
            this.gameTablePanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SpacingGame.Properties.Resources.spaceship_23x23;
            this.button2.Location = new System.Drawing.Point(216, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(39, 526);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(136, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(225, 526);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(136, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(409, 526);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // SGView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameTablePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "SGView";
            this.Text = "Spacing Game";
            this.gameTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameTablePanel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button2;
    }
}

