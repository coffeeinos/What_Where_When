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
    public partial class CheckingQuestionsAndBlitz : Form
    {
        List<QuestionsAndAnswers> questionsAndAnswers = new List<QuestionsAndAnswers>();

        List<List<Blitz>> blitz = new List<List<Blitz>>();

        int counterQuestion = 0;

        int counterBlitz = 0;
        public CheckingQuestionsAndBlitz(List<List<Blitz>> blitz, List<QuestionsAndAnswers> questionsAndAnswers)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.questionsAndAnswers = questionsAndAnswers;

            this.blitz = blitz;

            textBoxQuestion.Text = this.questionsAndAnswers[counterQuestion].QuastionProperty;
            textBoxAnswer.Text = this.questionsAndAnswers[counterQuestion].AnswerProperty;
            textBoxAuthor.Text = this.questionsAndAnswers[counterQuestion].AuthorProperty;
        }

        private void CheckingQuestionsAndBlitz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxThemeBlitz_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxThemeBlitz.Text != blitz[counterBlitz][counterQuestion].ThemeProperty)
            {
                buttonAcceptQuestion.Text = "Исправить";
            }
            else if (textBoxThemeBlitz.Text == blitz[counterBlitz][counterQuestion].ThemeProperty)
            {
                buttonAcceptQuestion.Text = "Правильно";
            }
            if (textBoxThemeBlitz.Text == "")
            {
                textBoxThemeBlitz.Text = "Введите тему блица";
            }
        }

        private void textBoxQuestion_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxThemeBlitz.Visible != true)
            {
                if (textBoxQuestion.Text != questionsAndAnswers[counterQuestion].QuastionProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxQuestion.Text == questionsAndAnswers[counterQuestion].QuastionProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            else if (textBoxThemeBlitz.Visible == true)
            {
                if (textBoxQuestion.Text != blitz[counterBlitz][counterQuestion].QuastionProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxQuestion.Text == blitz[counterBlitz][counterQuestion].QuastionProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            
            if (textBoxQuestion.Text == "")
            {
                textBoxQuestion.Text = "Введите вопрос";
            }
        }

        private void textBoxAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxThemeBlitz.Visible != true)
            {
                if (textBoxAnswer.Text != questionsAndAnswers[counterQuestion].AnswerProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxAnswer.Text == questionsAndAnswers[counterQuestion].AnswerProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            else if (textBoxThemeBlitz.Visible == true)
            {
                if (textBoxAnswer.Text != blitz[counterBlitz][counterQuestion].AnswerProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxAnswer.Text == blitz[counterBlitz][counterQuestion].AnswerProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            if (textBoxAnswer.Text == "")
            {
                textBoxAnswer.Text = "Введите ответ";
            }
        }

        private void buttonAcceptQuestion_Click(object sender, EventArgs e)
        {
            if (textBoxThemeBlitz.Text == "Введите тему блица")
            {
                    MessageBox.Show("Вы не ввели тему блица");
                    return;
            }
            if (textBoxQuestion.Text == "Введите вопрос")
            {
                MessageBox.Show("Вы не ввели вопрос");
                return;
            }
            if (textBoxAnswer.Text == "Введите ответ")
            {
                MessageBox.Show("Вы не ввели ответ на вопрос");
                return;
            }
            if (textBoxThemeBlitz.Visible != true)
            {
                if (!(textBoxQuestion.Text == questionsAndAnswers[counterQuestion].QuastionProperty || textBoxAnswer.Text == questionsAndAnswers[counterQuestion].AnswerProperty))
                {
                    questionsAndAnswers[counterQuestion].QuastionProperty = textBoxQuestion.Text;
                    questionsAndAnswers[counterQuestion].AnswerProperty = textBoxAnswer.Text;
                }
                counterQuestion++;
                if (counterQuestion < questionsAndAnswers.Count)
                {
                    textBoxQuestion.Text = questionsAndAnswers[counterQuestion].QuastionProperty;
                    textBoxAnswer.Text = questionsAndAnswers[counterQuestion].AnswerProperty;
                    labelEnteringBlitz.Text = $"Проверите вопрос № {counterQuestion + 1}";
                    buttonAcceptQuestion.Text = "Правильно";
                }
                else
                {
                    textBoxThemeBlitz.Visible = true;
                    textBoxAuthor.Visible = true;
                    counterQuestion = 0;
                    textBoxThemeBlitz.Text = blitz[counterBlitz][counterQuestion].ThemeProperty;
                    textBoxQuestion.Text = blitz[counterBlitz][counterQuestion].QuastionProperty;
                    textBoxAnswer.Text = blitz[counterBlitz][counterQuestion].AnswerProperty;
                    textBoxAuthor.Text = blitz[counterBlitz][counterQuestion].AuthorProperty;
                    labelEnteringBlitz.Text = $"Проверите вопрос № {counterQuestion + 1} блица №{counterBlitz + 1}";
                    buttonAcceptQuestion.Text = "Правильно";

                }
            }
            else
            {
                if (!(textBoxQuestion.Text == blitz[counterBlitz][counterQuestion].QuastionProperty || textBoxAnswer.Text == blitz[counterBlitz][counterQuestion].AnswerProperty || textBoxThemeBlitz.Text == blitz[counterBlitz][counterQuestion].ThemeProperty))
                {
                    blitz[counterBlitz][counterQuestion].QuastionProperty = textBoxQuestion.Text;
                    blitz[counterBlitz][counterQuestion].AnswerProperty = textBoxAnswer.Text;
                    blitz[counterBlitz][counterQuestion].ThemeProperty = textBoxThemeBlitz.Text;
                    blitz[counterBlitz][counterQuestion].AuthorProperty = textBoxAuthor.Text;
                }
                counterQuestion++;
                if (counterQuestion < blitz[counterBlitz].Count)
                {
                    textBoxThemeBlitz.Text = blitz[counterBlitz][counterQuestion].ThemeProperty;
                    textBoxQuestion.Text = blitz[counterBlitz][counterQuestion].QuastionProperty;
                    textBoxAnswer.Text = blitz[counterBlitz][counterQuestion].AnswerProperty;
                    textBoxAuthor.Text = blitz[counterBlitz][counterQuestion].AuthorProperty;
                    labelEnteringBlitz.Text = $"Проверите вопрос № {counterQuestion + 1} блица №{counterBlitz + 1}";
                    buttonAcceptQuestion.Text = "Правильно";
                }
                else
                {
                    counterQuestion = 0;
                    counterBlitz++;
                    if (counterBlitz < blitz.Count)
                    {
                        textBoxThemeBlitz.Text = blitz[counterBlitz][counterQuestion].ThemeProperty;
                        textBoxQuestion.Text = blitz[counterBlitz][counterQuestion].QuastionProperty;
                        textBoxAnswer.Text = blitz[counterBlitz][counterQuestion].AnswerProperty;
                        textBoxAuthor.Text = blitz[counterBlitz][counterQuestion].AuthorProperty;
                        labelEnteringBlitz.Text = $"Проверите вопрос № {counterQuestion + 1} блица №{counterBlitz + 1}";
                        buttonAcceptQuestion.Text = "Правильно";
                    }
                    else
                    {
                        this.Hide();

                        StartGame startGame = new StartGame(blitz, questionsAndAnswers);

                        startGame.Show();
                    }
                }
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

        private void textBoxThemeBlitz_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxThemeBlitz.Text == "Введите тему блица")
            {
                textBoxThemeBlitz.Text = "";
            }
        }

        private void textBoxThemeBlitz_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxThemeBlitz.Text == "")
            {
                textBoxThemeBlitz.Text = "Введите тему блица";
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

        private void textBoxThemeBlitz_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxThemeBlitz.Text == "Введите тему блица")
            {
                textBoxThemeBlitz.Text = "";
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

        private void buttonSkipCheking_Click(object sender, EventArgs e)
        {
            this.Hide();

            StartGame startGame = new StartGame(blitz, questionsAndAnswers);

            startGame.Show();
        }

        private void textBoxAuthor_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "Введите имя автора")
            {
                textBoxAuthor.Text = "";
            }
        }

        private void textBoxAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Введите имя автора";
            }
        }

        private void textBoxAuthor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxAuthor.Text == "Введите имя автора")
            {
                textBoxAuthor.Text = "";
            }
        }

        private void textBoxAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxThemeBlitz.Visible != true)
            {
                if (textBoxAuthor.Text != questionsAndAnswers[counterQuestion].AuthorProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxAuthor.Text == questionsAndAnswers[counterQuestion].AuthorProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            else if (textBoxThemeBlitz.Visible == true)
            {
                if (textBoxAuthor.Text != blitz[counterBlitz][counterQuestion].AuthorProperty)
                {
                    buttonAcceptQuestion.Text = "Исправить";
                }
                else if (textBoxAuthor.Text == blitz[counterBlitz][counterQuestion].AuthorProperty)
                {
                    buttonAcceptQuestion.Text = "Правильно";
                }
            }
            if (textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Введите имя автора";
            }
        }
    }
}
