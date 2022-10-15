
namespace Homework
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFalse);
            this.panel1.Controls.Add(this.btnTrue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnFalse
            // 
            this.btnFalse.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnFalse.Location = new System.Drawing.Point(282, 12);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(121, 76);
            this.btnFalse.TabIndex = 2;
            this.btnFalse.Text = "Не верю!";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnTrue.Location = new System.Drawing.Point(51, 12);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(121, 76);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "Верю!";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textBox1.Location = new System.Drawing.Point(179, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Вопрос";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblQuestionNumber.Location = new System.Drawing.Point(232, 2);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(51, 20);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "label1";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbQuestionText
            // 
            this.tbQuestionText.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.tbQuestionText.Location = new System.Drawing.Point(0, 22);
            this.tbQuestionText.Multiline = true;
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.ReadOnly = true;
            this.tbQuestionText.Size = new System.Drawing.Size(453, 166);
            this.tbQuestionText.TabIndex = 3;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.tbQuestionText);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Cheat";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.Button btnFalse;
    }
}