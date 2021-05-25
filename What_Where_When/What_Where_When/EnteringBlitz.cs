using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_Where_When
{
    public partial class EnteringBlitz : Form
    {
        List<QuestionsAndAnswers> questionsAndAnswers = new List<QuestionsAndAnswers>();

        List<List<Blitz>> blitz = new List<List<Blitz>>();

        int counterBlitz = 0;
        public EnteringBlitz(List<QuestionsAndAnswers> questionsAndAnswers)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.questionsAndAnswers = questionsAndAnswers;

        }

        private void EnteringBlitz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxQuestion_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "Введите вопрос")
            {
                textBoxQuestion.Text = "";
            }
        }

        private void textBoxQuestion_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "")
            {
                textBoxQuestion.Text = "Введите вопрос";
            }
        }

        private void textBoxAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxAnswer.Text == "Введите ответ")
            {
                textBoxAnswer.Text = "";
            }
        }

        private void textBoxAnswer_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAnswer.Text == "")
            {
                textBoxAnswer.Text = "Введите ответ";
            }
        }

        private void buttonEnterQuestion_Click(object sender, EventArgs e)
        {

            if (textBoxQuestion.Text == "Введите вопрос")
            {
                MessageBox.Show("Вы не ввели вопрос");
                return;
            }
            if (textBoxAnswer.Text == "Введите ответ")
            {
                MessageBox.Show("Вы не ввели ответ");
                return;
            }
            if (buttonEnterBlitz.Visible == false)
            {
                buttonEnterBlitz.Visible = true;
            }
            int counter;
            int.TryParse(string.Join("", buttonEnterQuestion.Text.Where(c => char.IsDigit(c))), out counter);
            counter++;
            buttonEnterQuestion.Text = $"Принять вопрос № {counter} для блица";
            blitz[counterBlitz].Add(new Blitz() { QuastionProperty = textBoxQuestion.Text, AnswerProperty = textBoxAnswer.Text, ThemeProperty = textBoxBlitzTheme.Text, AuthorProperty = textBoxAuthor.Text });
            textBoxQuestion.Text = "Введите вопрос";
            textBoxAnswer.Text = "Введите ответ";
        }

        private void buttonEnterBlitz_Click(object sender, EventArgs e)
        {
            int counter;
            int.TryParse(string.Join("", labelEnteringBlitz.Text.Where(c => char.IsDigit(c))), out counter);
            counter++;
            counterBlitz++;
            labelEnteringBlitz.Text = $"Введите блиц № {counter}";
            buttonEnterQuestion.Text = "Принять вопрос № 1 для блица";
            buttonEnterBlitz.Text = $"Принять блиц № {counter}";
            buttonEnterBlitzTheme.Text = $"Принять тему для блица № {counter}";
            if (buttonEndEnter.Visible == false)
            {
                buttonEndEnter.Visible = true;
            }
            if (buttonEnterBlitz.Visible == true)
            {
                buttonEnterBlitz.Visible = false;
            }
            textBoxQuestion.Visible = false;
            textBoxAnswer.Visible = false;
            buttonEnterQuestion.Visible = false;
            textBoxBlitzTheme.Visible = true;
            buttonEnterBlitzTheme.Visible = true;
            textBoxAuthor.Visible = true;
            textBoxBlitzTheme.Text = "Введите тему блица";
            textBoxAuthor.Text = "Введите автора блица";
        }

        private void buttonEndEnter_Click(object sender, EventArgs e)
        {
            this.Hide();

            CheckingQuestionsAndBlitz checkingQuestionsAndBlitz = new CheckingQuestionsAndBlitz(blitz, questionsAndAnswers);

            checkingQuestionsAndBlitz.Show();
        }

        private void textBoxBlitzTheme_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxBlitzTheme.Text == "Введите тему блица")
            {
                textBoxBlitzTheme.Text = "";
            }
        }

        private void textBoxBlitzTheme_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxBlitzTheme.Text == "")
            {
                textBoxBlitzTheme.Text = "Введите тему блица";
            }
        }

        private void buttonEnterBlitzTheme_Click(object sender, EventArgs e)
        {
            if (textBoxBlitzTheme.Text == "Введите тему блица")
            {
                MessageBox.Show("Вы не ввели тему блица");
                return;
            }
            if (textBoxAuthor.Text == "Введите автора блица")
            {
                MessageBox.Show("Вы не ввели автора блица");
                return;
            }
            blitz.Add(new List<Blitz>());
            textBoxQuestion.Visible = true;
            textBoxAnswer.Visible = true;
            buttonEnterQuestion.Visible = true;
            textBoxBlitzTheme.Visible = false;
            buttonEnterBlitzTheme.Visible = false;
            buttonEndEnter.Visible = false;
            textBoxAuthor.Visible = false;
        }

        private void textBoxBlitzTheme_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxBlitzTheme.Text == "Введите тему блица")
            {
                textBoxBlitzTheme.Text = "";
            }
        }

        private void textBoxQuestion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxQuestion.Text == "Введите вопрос")
            {
                textBoxQuestion.Text = "";
            }
        }

        private void textBoxAnswer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxAnswer.Text == "Введите ответ")
            {
                textBoxAnswer.Text = "";
            }
        }

        private void textBoxBlitzTheme_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxBlitzTheme.Text == "")
            {
                textBoxBlitzTheme.Text = "Введите тему блица";
            }
        }

        private void textBoxQuestion_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxQuestion.Text == "")
            {
                textBoxQuestion.Text = "Введите вопрос";
            }
        }

        private void textBoxAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxAnswer.Text == "")
            {
                textBoxAnswer.Text = "Введите ответ";
            }
        }

        private void textBoxAuthor_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "Введите автора блица")
            {
                textBoxAuthor.Text = "";
            }
        }

        private void textBoxAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Введите автора блица";
            }
        }

        private void textBoxAuthor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxAuthor.Text == "Введите автора блица")
            {
                textBoxAuthor.Text = "";
            }
        }

        private void textBoxAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxAuthor.Text == "Введите автора блица")
            {
                textBoxAuthor.Text = "";
            }
        }
    }
}
