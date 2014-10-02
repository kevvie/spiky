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
            this.characterButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Bombing", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(244, 264);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 122);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Press to start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // multiPlayerButton
            // 
            this.multiPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayerButton.FlatAppearance.BorderSize = 0;
            this.multiPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiPlayerButton.Font = new System.Drawing.Font("Bombing", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayerButton.ForeColor = System.Drawing.Color.Red;
            this.multiPlayerButton.Location = new System.Drawing.Point(103, 203);
            this.multiPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.multiPlayerButton.Name = "multiPlayerButton";
            this.multiPlayerButton.Size = new System.Drawing.Size(121, 41);
            this.multiPlayerButton.TabIndex = 1;
            this.multiPlayerButton.Text = "MultiPlayer";
            this.multiPlayerButton.UseVisualStyleBackColor = true;
            this.multiPlayerButton.Click += new System.EventHandler(this.multiPlayerButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScoreButton.FlatAppearance.BorderSize = 0;
            this.highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreButton.Font = new System.Drawing.Font("Bombing", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreButton.ForeColor = System.Drawing.Color.Red;
            this.highScoreButton.Location = new System.Drawing.Point(375, 203);
            this.highScoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(112, 41);
            this.highScoreButton.TabIndex = 2;
            this.highScoreButton.Text = "HighScore";
            this.highScoreButton.UseVisualStyleBackColor = true;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButton.Font = new System.Drawing.Font("Bombing", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteButton.ForeColor = System.Drawing.Color.Red;
            this.muteButton.Location = new System.Drawing.Point(112, 406);
            this.muteButton.Margin = new System.Windows.Forms.Padding(2);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(112, 41);
            this.muteButton.TabIndex = 3;
            this.muteButton.Text = "Mute";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click_1);
            // 
            // characterButton
            // 
            this.characterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.characterButton.FlatAppearance.BorderSize = 0;
            this.characterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.characterButton.Font = new System.Drawing.Font("Bombing", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterButton.ForeColor = System.Drawing.Color.Red;
            this.characterButton.Location = new System.Drawing.Point(375, 406);
            this.characterButton.Margin = new System.Windows.Forms.Padding(2);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(112, 41);
            this.characterButton.TabIndex = 4;
            this.characterButton.Text = "Character";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Bombing", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(244, 139);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 41);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Bombing", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(244, 462);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 41);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // spikyStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(586, 612);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.characterButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.multiPlayerButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "spikyStartUp";
            this.Text = "Spiky the Game";
            this.Load += new System.EventHandler(this.spikyStartUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button multiPlayerButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}

