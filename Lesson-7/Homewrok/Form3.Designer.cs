
namespace Homewrok
{
    partial class GuessGame
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbxResult = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.txtbxAnswer = new System.Windows.Forms.TextBox();
            this.btnWinner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(399, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Постарайтесь угадать число от 1 до 100:";
            // 
            // txtbxResult
            // 
            this.txtbxResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxResult.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtbxResult.Location = new System.Drawing.Point(12, 89);
            this.txtbxResult.Name = "txtbxResult";
            this.txtbxResult.ReadOnly = true;
            this.txtbxResult.Size = new System.Drawing.Size(399, 23);
            this.txtbxResult.TabIndex = 6;
            this.txtbxResult.Text = "Введите предполагаемое число";
            this.txtbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textBox3.Location = new System.Drawing.Point(0, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(423, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Сделано ходов:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblMoves.Location = new System.Drawing.Point(116, 249);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(51, 20);
            this.lblMoves.TabIndex = 9;
            this.lblMoves.Text = "label1";
            // 
            // txtbxAnswer
            // 
            this.txtbxAnswer.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtbxAnswer.Location = new System.Drawing.Point(148, 160);
            this.txtbxAnswer.Name = "txtbxAnswer";
            this.txtbxAnswer.Size = new System.Drawing.Size(100, 27);
            this.txtbxAnswer.TabIndex = 10;
            this.txtbxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxAnswer_KeyDown);
            // 
            // btnWinner
            // 
            this.btnWinner.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btnWinner.Location = new System.Drawing.Point(82, 131);
            this.btnWinner.Name = "btnWinner";
            this.btnWinner.Size = new System.Drawing.Size(244, 87);
            this.btnWinner.TabIndex = 11;
            this.btnWinner.Text = "Я молодец!";
            this.btnWinner.UseVisualStyleBackColor = true;
            this.btnWinner.Visible = false;
            this.btnWinner.Click += new System.EventHandler(this.btnWinner_Click);
            // 
            // GuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.btnWinner);
            this.Controls.Add(this.txtbxAnswer);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtbxResult);
            this.Controls.Add(this.textBox1);
            this.Name = "GuessGame";
            this.Text = "Guess the number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.TextBox txtbxAnswer;
        private System.Windows.Forms.Button btnWinner;
    }
}