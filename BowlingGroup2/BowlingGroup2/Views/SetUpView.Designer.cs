namespace BowlingGroup2
{
    partial class SetUpView
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
            this.playGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player1NameTxt = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameBtn
            // 
            this.playGameBtn.Location = new System.Drawing.Point(12, 161);
            this.playGameBtn.Name = "playGameBtn";
            this.playGameBtn.Size = new System.Drawing.Size(274, 70);
            this.playGameBtn.TabIndex = 0;
            this.playGameBtn.Text = "Play Game";
            this.playGameBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // player1NameTxt
            // 
            this.player1NameTxt.Location = new System.Drawing.Point(93, 67);
            this.player1NameTxt.Name = "player1NameTxt";
            this.player1NameTxt.Size = new System.Drawing.Size(176, 20);
            this.player1NameTxt.TabIndex = 2;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(93, 107);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(176, 20);
            this.player2Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2";
            // 
            // SetUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1NameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playGameBtn);
            this.Name = "SetUpView";
            this.Text = "Bowling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player1NameTxt;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Label label2;
    }
}

