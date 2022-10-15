using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Game : Form
    {
        private QuestionsEditor gamedb;
        private int points;

        public Game(QuestionsEditor database)
        {
            InitializeComponent();
            gamedb = database;
            points = 0;
            lblQuestionNumber.Text = "1";
            tbQuestionText.Text = gamedb[int.Parse(lblQuestionNumber.Text) - 1].Text;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            if (gamedb[int.Parse(lblQuestionNumber.Text) - 1].Answer == true)
            {
                points++;
            }

            if (int.Parse(lblQuestionNumber.Text) != gamedb.QuestionCounter)
            {
                lblQuestionNumber.Text = (int.Parse(lblQuestionNumber.Text) + 1).ToString();
                tbQuestionText.Text = gamedb[int.Parse(lblQuestionNumber.Text) - 1].Text;
            }
            else
            {
                MessageBox.Show($"Поздравляю, вы набрали {points} очков", "Конец игры", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            if (gamedb[int.Parse(lblQuestionNumber.Text) - 1].Answer == false)
            {
                points++;
            }

            if (int.Parse(lblQuestionNumber.Text) != gamedb.QuestionCounter)
            {
                lblQuestionNumber.Text = (int.Parse(lblQuestionNumber.Text) + 1).ToString();
                tbQuestionText.Text = gamedb[int.Parse(lblQuestionNumber.Text) - 1].Text;
            }
            else
            {
                MessageBox.Show($"Поздравляю, вы набрали {points} очков", "Конец игры", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
