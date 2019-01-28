namespace BowlingGroup2.Views
{
    partial class PlayerBoard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.player1Scoreboard = new System.Windows.Forms.ListBox();
            this.player2Scoreboard = new System.Windows.Forms.ListBox();
            this.player1RollBtn = new System.Windows.Forms.Button();
            this.player2RollBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.player1Scoreboard);
            this.groupBox1.Controls.Add(this.player1RollBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 136);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1 Scoring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.player2RollBtn);
            this.groupBox2.Controls.Add(this.player2Scoreboard);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 125);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2 Scoring";
            // 
            // player1Scoreboard
            // 
            this.player1Scoreboard.FormattingEnabled = true;
            this.player1Scoreboard.Location = new System.Drawing.Point(7, 20);
            this.player1Scoreboard.Name = "player1Scoreboard";
            this.player1Scoreboard.Size = new System.Drawing.Size(120, 95);
            this.player1Scoreboard.TabIndex = 0;
            // 
            // player2Scoreboard
            // 
            this.player2Scoreboard.FormattingEnabled = true;
            this.player2Scoreboard.Location = new System.Drawing.Point(7, 20);
            this.player2Scoreboard.Name = "player2Scoreboard";
            this.player2Scoreboard.Size = new System.Drawing.Size(120, 95);
            this.player2Scoreboard.TabIndex = 0;
            // 
            // player1RollBtn
            // 
            this.player1RollBtn.Location = new System.Drawing.Point(182, 19);
            this.player1RollBtn.Name = "player1RollBtn";
            this.player1RollBtn.Size = new System.Drawing.Size(75, 95);
            this.player1RollBtn.TabIndex = 12;
            this.player1RollBtn.Text = "Roll";
            this.player1RollBtn.UseVisualStyleBackColor = true;
            // 
            // player2RollBtn
            // 
            this.player2RollBtn.Location = new System.Drawing.Point(182, 19);
            this.player2RollBtn.Name = "player2RollBtn";
            this.player2RollBtn.Size = new System.Drawing.Size(75, 95);
            this.player2RollBtn.TabIndex = 13;
            this.player2RollBtn.Text = "Roll";
            this.player2RollBtn.UseVisualStyleBackColor = true;
            this.player2RollBtn.Click += new System.EventHandler(this.player2RollBtn_Click);
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlayerBoard";
            this.Text = "PlayerBoard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox player1Scoreboard;
        private System.Windows.Forms.Button player1RollBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox player2Scoreboard;
        private System.Windows.Forms.Button player2RollBtn;
    }
}