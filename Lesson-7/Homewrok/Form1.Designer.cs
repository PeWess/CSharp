
namespace Homewrok
{
    partial class Menu
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnDoubler = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblGuessFinalScore = new System.Windows.Forms.Label();
            this.lblDoubleFinalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuess.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnGuess.Location = new System.Drawing.Point(250, 45);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(161, 120);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Угадай число";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.Guess_Click);
            // 
            // btnDoubler
            // 
            this.btnDoubler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDoubler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoubler.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnDoubler.Location = new System.Drawing.Point(12, 45);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(161, 120);
            this.btnDoubler.TabIndex = 0;
            this.btnDoubler.Text = "Удвоитель";
            this.btnDoubler.UseVisualStyleBackColor = true;
            this.btnDoubler.Click += new System.EventHandler(this.Doubler_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textBox1.Location = new System.Drawing.Point(132, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Выберите игру";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.textBox2.Location = new System.Drawing.Point(0, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(423, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Made by Сергей Критский";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textBox3.Location = new System.Drawing.Point(12, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(161, 16);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Минимально число ходов:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textBox4.Location = new System.Drawing.Point(250, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(161, 16);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Минимально число ходов:";
            // 
            // lblGuessFinalScore
            // 
            this.lblGuessFinalScore.AutoSize = true;
            this.lblGuessFinalScore.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.lblGuessFinalScore.Location = new System.Drawing.Point(398, 173);
            this.lblGuessFinalScore.Name = "lblGuessFinalScore";
            this.lblGuessFinalScore.Size = new System.Drawing.Size(13, 14);
            this.lblGuessFinalScore.TabIndex = 7;
            this.lblGuessFinalScore.Text = "0";
            // 
            // lblDoubleFinalScore
            // 
            this.lblDoubleFinalScore.AutoSize = true;
            this.lblDoubleFinalScore.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.lblDoubleFinalScore.Location = new System.Drawing.Point(160, 173);
            this.lblDoubleFinalScore.Name = "lblDoubleFinalScore";
            this.lblDoubleFinalScore.Size = new System.Drawing.Size(13, 14);
            this.lblDoubleFinalScore.TabIndex = 8;
            this.lblDoubleFinalScore.Text = "0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.lblDoubleFinalScore);
            this.Controls.Add(this.lblGuessFinalScore);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnDoubler);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblGuessFinalScore;
        private System.Windows.Forms.Label lblDoubleFinalScore;
    }
}

