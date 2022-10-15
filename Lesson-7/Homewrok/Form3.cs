using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homewrok
{
    public partial class GuessGame : Form
    {
        public int guessNumber = new Random().Next(1, 101);
        public GuessGame()
        {
            InitializeComponent();
            lblMoves.Text = "0";
        }

        private void txtbxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int enter;
                if (int.TryParse(txtbxAnswer.Text, out enter) == false || enter < 1 || enter > 100)
                {
                    txtbxResult.Text = "Введены некорректные данные.";
                }

                else if (enter > guessNumber)
                {
                    txtbxResult.Text = "Загаданное число меньше вашего.";
                    lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
                }

                else if (enter < guessNumber)
                {
                    txtbxResult.Text = "Загаданное число больше вашего.";
                    lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
                }

                else if (enter == guessNumber)
                {
                    lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
                    txtbxResult.Text = $"Поздравляю, вы отгадали число!!!";
                    txtbxAnswer.Hide();
                    btnWinner.Show();
                }
            }
        }

        private void btnWinner_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
