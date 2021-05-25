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
    public partial class EnteringQuestions : Form
    {
        List<QuestionsAndAnswers> questionsAndAnswers = new List<QuestionsAndAnswers>();
        public EnteringQuestions()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void EnteringQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
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
            if (textBoxNameAuthor.Text == "Введите имя автора")
            {
                MessageBox.Show("Вы не имя автора");
                return;
            }
            if (buttonEndEnter.Visible == false)
            {
                buttonEndEnter.Visible = true;
            }
            questionsAndAnswers.Add(new QuestionsAndAnswers() { QuastionProperty = textBoxQuestion.Text, AnswerProperty = textBoxAnswer.Text, AuthorProperty = textBoxNameAuthor.Text});

            int counter;
            int.TryParse(string.Join("",labelEnteringQuestions.Text.Where(c => char.IsDigit(c))), out counter);
            counter++;
            labelEnteringQuestions.Text = $"Введите вопрос № {counter}";
            buttonEnter.Text = $"Принять вопрос № {counter}";
            textBoxQuestion.Text = "Введите вопрос";
            textBoxAnswer.Text = "Введите ответ";
            textBoxNameAuthor.Text = "Введите имя автора";

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

        private void buttonEndEnter_Click(object sender, EventArgs e)
        {
            this.Hide();

            EnteringBlitz enteringBlitz = new EnteringBlitz(questionsAndAnswers);

            enteringBlitz.Show();
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

        private void textBoxNameAuthor_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxNameAuthor.Text == "Введите имя автора")
            {
                textBoxNameAuthor.Text = "";
            }
        }

        private void textBoxNameAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxNameAuthor.Text == "")
            {
                textBoxNameAuthor.Text = "Введите имя автора";
            }
        }

        private void textBoxNameAuthor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxNameAuthor.Text == "Введите имя автора")
            {
                textBoxNameAuthor.Text = "";
            }
        }

        private void textBoxNameAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxNameAuthor.Text == "")
            {
                textBoxNameAuthor.Text = "Введите имя автора";
            }
        }
    }
}
