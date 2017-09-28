namespace SpacingGame
{
    partial class spacingGame
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.newGame = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.mainGameTable = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(42, 526);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(187, 23);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(355, 526);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(187, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // mainGameTable
            // 
            this.mainGameTable.BackColor = System.Drawing.Color.Blue;
            this.mainGameTable.Location = new System.Drawing.Point(42, 20);
            this.mainGameTable.Name = "mainGameTable";
            this.mainGameTable.Size = new System.Drawing.Size(500, 500);
            this.mainGameTable.TabIndex = 2;
            // 
            // spacingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.mainGameTable);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.newGame);
            this.Name = "spacingGame";
            this.Text = "Spacing Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel mainGameTable;
    }
}

