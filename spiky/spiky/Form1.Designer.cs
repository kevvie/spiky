namespace spiky
{
    partial class spikyStartUp
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
            this.startButton = new System.Windows.Forms.Button();
            this.multiPlayerButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.changeCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Bombing", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(325, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 150);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Press to start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // multiPlayerButton
            // 
            this.multiPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayerButton.Location = new System.Drawing.Point(150, 250);
            this.multiPlayerButton.Name = "multiPlayerButton";
            this.multiPlayerButton.Size = new System.Drawing.Size(150, 50);
            this.multiPlayerButton.TabIndex = 1;
            this.multiPlayerButton.Text = "MultiPlayer";
            this.multiPlayerButton.UseVisualStyleBackColor = true;
            this.multiPlayerButton.Click += new System.EventHandler(this.multiPlayerButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScoreButton.Location = new System.Drawing.Point(500, 250);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(150, 50);
            this.highScoreButton.TabIndex = 2;
            this.highScoreButton.Text = "HighScore";
            this.highScoreButton.UseVisualStyleBackColor = true;
            // 
            // muteButton
            // 
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.Location = new System.Drawing.Point(150, 500);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(150, 50);
            this.muteButton.TabIndex = 3;
            this.muteButton.Text = "Mute";
            this.muteButton.UseVisualStyleBackColor = true;
            // 
            // changeCharacterButton
            // 
            this.changeCharacterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCharacterButton.Location = new System.Drawing.Point(500, 500);
            this.changeCharacterButton.Name = "changeCharacterButton";
            this.changeCharacterButton.Size = new System.Drawing.Size(150, 50);
            this.changeCharacterButton.TabIndex = 4;
            this.changeCharacterButton.Text = "Change Character";
            this.changeCharacterButton.UseVisualStyleBackColor = true;
            // 
            // spikyStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.changeCharacterButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.multiPlayerButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "spikyStartUp";
            this.Text = "Spiky the Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button multiPlayerButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Button changeCharacterButton;
    }
}

