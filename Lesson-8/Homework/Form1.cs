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
    public partial class Form1 : Form
    {
        private QuestionsEditor database;

        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Items

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new QuestionsEditor(saveFileDialog.FileName);
                database.AddQuestion("Земля круглая", true);

                nudQuestionNumber.Minimum = 1;
                nudQuestionNumber.Maximum = 1;
                nudQuestionNumber.Value = 1;
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new QuestionsEditor(openFileDialog.FileName);

                try
                {
                    database.LoadQuestions();

                    nudQuestionNumber.Minimum = 1;
                    nudQuestionNumber.Maximum = database.QuestionCounter;
                    nudQuestionNumber.Value = 1;

                    if (database.QuestionCounter != 0)
                    {
                        tbCurrentQuestion.Text = database[0].Text;
                        cbTrue.Checked = database[0].Answer;
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            database.SaveQuestions();
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveFileDialog.FileName;
                database.SaveQuestions();
            }
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudQuestionNumber.Maximum == 0)
            {
                if (tbCurrentQuestion.Text.Replace(" ", string.Empty) == "")
                {
                    MessageBox.Show("Вы не можете добавить пустой вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        database = new QuestionsEditor(saveFileDialog.FileName);
                        database.AddQuestion(tbCurrentQuestion.Text, cbTrue.Checked);

                        nudQuestionNumber.Minimum = 1;
                        nudQuestionNumber.Maximum = 1;
                        nudQuestionNumber.Value = 1;
                    }
                }
            }

            else
            {
                database.AddQuestion(((int)nudQuestionNumber.Maximum + 1).ToString(), true);
                nudQuestionNumber.Maximum = database.QuestionCounter;
                nudQuestionNumber.Value = database.QuestionCounter;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudQuestionNumber.Maximum != 0)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить вопрос: '{database[(int)nudQuestionNumber.Value - 1].Text}'?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nudQuestionNumber.Maximum == 1)
                    {
                        MessageBox.Show("База вопросов для игры не может быть пустой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        database.RemoveQuestion((int)nudQuestionNumber.Value - 1);
                        nudQuestionNumber.Maximum--;
                        tbCurrentQuestion.Text = database[(int)nudQuestionNumber.Value - 1].Text;
                        cbTrue.Checked = database[(int)nudQuestionNumber.Value - 1].Answer;
                    }
                }
            }
            else
            {
                MessageBox.Show("Удаление невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCurrentQuestion.Text.Replace(" ", string.Empty) == "")
            {
                MessageBox.Show("Вы не можете добавить пустой вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                database[(int)nudQuestionNumber.Value - 1].Text = tbCurrentQuestion.Text;
                database[(int)nudQuestionNumber.Value - 1].Answer = cbTrue.Checked;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (nudQuestionNumber.Maximum != 0)
            {
                this.Hide();
                Game game = new Game(database);
                game.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Вы не можете сыграть с пустым списком вопросов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events

        private void nudQuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            tbCurrentQuestion.Text = database[(int)nudQuestionNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudQuestionNumber.Value - 1].Answer;
        }

        #endregion
    }
}
