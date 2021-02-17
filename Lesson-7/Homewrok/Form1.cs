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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Doubler_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoublerGame game = new DoublerGame();
            game.ShowDialog();
            if(int.Parse(lblDoubleFinalScore.Text) > int.Parse(game.lblMoves.Text)) lblDoubleFinalScore.Text = game.lblMoves.Text;
            else if (lblDoubleFinalScore.Text == "0") lblDoubleFinalScore.Text = game.lblMoves.Text;
            this.Show();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuessGame game = new GuessGame();
            game.ShowDialog();
            if (int.Parse(lblGuessFinalScore.Text) > int.Parse(game.lblMoves.Text)) lblGuessFinalScore.Text = game.lblMoves.Text;
            else if (lblGuessFinalScore.Text == "0") lblGuessFinalScore.Text = game.lblMoves.Text;
            this.Show();
        }
    }
}
