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
    public partial class DoublerGame : Form
    {
        public string[] states = { "0" };

        public DoublerGame()
        {
            InitializeComponent();
            lblTargetValue.Text = (new Random().Next(10, 1000)).ToString();
            lblPlayerState.Text = "0";
            lblMoves.Text = "0";
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            lblPlayerState.Text = (int.Parse(lblPlayerState.Text) + 1).ToString();
            lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
            AddState(ref states, lblMoves.Text);
            states[int.Parse(lblMoves.Text)] = lblPlayerState.Text;
            if (int.Parse(lblPlayerState.Text) == int.Parse(lblTargetValue.Text))
            {
                var answer = MessageBox.Show($"Поздравляю, Вы выиграли!\nСделано ходов: {lblMoves.Text}", "Победа!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            lblPlayerState.Text = (int.Parse(lblPlayerState.Text) * 2).ToString();
            lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
            AddState(ref states, lblMoves.Text);
            states[int.Parse(lblMoves.Text)] = lblPlayerState.Text;
            if (int.Parse(lblPlayerState.Text) == int.Parse(lblTargetValue.Text))
            {
                var answer = MessageBox.Show($"Поздравляю, Вы выиграли!\nСделано ходов: {lblMoves.Text}", "Победа!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblMoves.Text) - 1 >= 0)
            {
                lblMoves.Text = (int.Parse(lblMoves.Text) - 1).ToString();
                lblPlayerState.Text = PreviousState(states, lblMoves.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lblPlayerState.Text != "0")
            {
                lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();
                AddState(ref states, lblMoves.Text);
                lblPlayerState.Text = "0";
            }
        }


        static void AddState(ref string[] states, string move)
        {
            if (states.Length == int.Parse(move))
            {
                Array.Resize(ref states, int.Parse(move) + 1);
            }
        }

        static string PreviousState(string[] states, string move)
        {
            return states[int.Parse(move)];
        }
    }
}
