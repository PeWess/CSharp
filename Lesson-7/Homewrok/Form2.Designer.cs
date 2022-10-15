
namespace Homewrok
{
    partial class DoublerGame
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
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTargetValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPlayerState = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusOne.Location = new System.Drawing.Point(309, 11);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(93, 50);
            this.btnPlusOne.TabIndex = 0;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDouble.Location = new System.Drawing.Point(309, 76);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(93, 50);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "X2";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(309, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTargetValue
            // 
            this.lblTargetValue.AutoSize = true;
            this.lblTargetValue.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblTargetValue.Location = new System.Drawing.Point(82, 58);
            this.lblTargetValue.Name = "lblTargetValue";
            this.lblTargetValue.Size = new System.Drawing.Size(82, 31);
            this.lblTargetValue.TabIndex = 3;
            this.lblTargetValue.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.textBox1.Location = new System.Drawing.Point(60, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "ВАША ЦЕЛЬ:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.textBox2.Location = new System.Drawing.Point(12, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(259, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "ТЕКУЩЕЕ СОСТОЯНИЕ:";
            // 
            // lblPlayerState
            // 
            this.lblPlayerState.AutoSize = true;
            this.lblPlayerState.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblPlayerState.Location = new System.Drawing.Point(82, 161);
            this.lblPlayerState.Name = "lblPlayerState";
            this.lblPlayerState.Size = new System.Drawing.Size(82, 31);
            this.lblPlayerState.TabIndex = 5;
            this.lblPlayerState.Text = "label2";
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
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Сделано ходов:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblMoves.Location = new System.Drawing.Point(117, 249);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(51, 20);
            this.lblMoves.TabIndex = 8;
            this.lblMoves.Text = "label3";
            // 
            // btnUndo
            // 
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Location = new System.Drawing.Point(309, 132);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(93, 50);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // DoublerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPlayerState);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTargetValue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnPlusOne);
            this.Name = "DoublerGame";
            this.Text = "Doubler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTargetValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPlayerState;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Button btnUndo;
    }
}