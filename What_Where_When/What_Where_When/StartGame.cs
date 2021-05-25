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
    public partial class StartGame : Form
    {
        List<QuestionsAndAnswers> questionsAndAnswers = new List<QuestionsAndAnswers>();

        List<List<Blitz>> blitz = new List<List<Blitz>>();

        int[] counterQuestins;

        int[] counterBlitz;

        int numberOfQuestions = 0;

        int numberOfQuestionsPassed = 0;

        int numberOfBlitz = 0;

        int numberOfPassedBlitz = 0;

        int numberOfQuestionsInBlitz = 0;

        int numberOfPassedQuestionsInBlitz = 0;

        int scorePlayers = 0;

        int scoreSpectators = 0;
        public StartGame(List<List<Blitz>> blitz, List<QuestionsAndAnswers> questionsAndAnswers)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.questionsAndAnswers = questionsAndAnswers;

            this.blitz = blitz;

            counterQuestins = new int[this.questionsAndAnswers.Count];

            RandomNumbers.RandomFilling(counterQuestins);

            counterBlitz = new int[this.blitz.Count];

            RandomNumbers.RandomFilling(counterBlitz);

            numberOfQuestions = this.questionsAndAnswers.Count;

            numberOfBlitz = this.blitz.Count;

            buttonQuestion.Text = $"Обычный вопрос ({numberOfQuestionsPassed} / {numberOfQuestions})";

            buttonBlitz.Text = $"Блиц ({numberOfPassedBlitz} / {numberOfBlitz})";

        }

        private void StartGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            textBoxAuthor.Visible = true;
            textBoxQuestion.Visible = true;
            textBoxAnswer.Visible = true;
            textBoxNameOfResponder.Visible = true;
            buttonRight.Visible = true;
            buttonWrong.Visible = true;
            buttonQuestion.Visible = false;
            buttonBlitz.Visible = false;
            labelCommunication.Text = $"Вопрос № {counterQuestins[numberOfQuestionsPassed] + 1}";
            textBoxAuthor.Text = questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].AuthorProperty;
            textBoxQuestion.Text = questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].QuastionProperty;
            textBoxAnswer.Text = questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].AnswerProperty;
        }

        private void buttonBlitz_Click(object sender, EventArgs e)
        {
            resultBlitz = true;
            numberOfPassedQuestionsInBlitz = 0;
            textBoxThemeBlitz.Visible = true;
            textBoxAuthor.Visible = true;
            textBoxQuestion.Visible = true;
            textBoxAnswer.Visible = true;
            textBoxNameOfResponder.Visible = true;
            buttonRight.Visible = true;
            buttonWrong.Visible = true;
            buttonQuestion.Visible = false;
            buttonBlitz.Visible = false;
            numberOfQuestionsInBlitz = blitz[counterBlitz[numberOfPassedBlitz]].Count;
            labelCommunication.Text = $"Блиц № {counterBlitz[numberOfPassedBlitz] + 1}";
            textBoxAuthor.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].AuthorProperty;
            textBoxThemeBlitz.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].ThemeProperty;
            textBoxQuestion.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].QuastionProperty;
            textBoxAnswer.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].AnswerProperty;

        }

        private void textBoxNameOfResponder_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxNameOfResponder.Text == "Введите имя отвечающего")
            {
                textBoxNameOfResponder.Text = "";
            }
        }

        private void textBoxNameOfResponder_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxNameOfResponder.Text == "")
            {
                textBoxNameOfResponder.Text = "Введите имя отвечающего";
            }
        }

        private void textBoxNameOfResponder_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBoxNameOfResponder.Text == "Введите имя отвечающего")
            {
                textBoxNameOfResponder.Text = "";
            }
        }

        private void textBoxNameOfResponder_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxNameOfResponder.Text == "")
            {
                textBoxNameOfResponder.Text = "Введите имя отвечающего";
            }
        }

        bool resultBlitz = true;
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (textBoxNameOfResponder.Text == "Введите имя отвечающего")
            {
                MessageBox.Show("Вы не ввели имя отвечающего");
                return;
            }
            if (textBoxThemeBlitz.Visible != true)
            {
                questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].NameOfResponderProperty = textBoxNameOfResponder.Text;
                questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].RightOrWrongProperty = true;
                numberOfQuestionsPassed++;
            }
            else if (textBoxThemeBlitz.Visible == true)
            {
                blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].NameOfResponderProperty = textBoxNameOfResponder.Text;
                blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].RightOrWrongProperty = true;
                numberOfPassedQuestionsInBlitz++;
                if (numberOfPassedQuestionsInBlitz < numberOfQuestionsInBlitz)
                {
                    textBoxQuestion.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].QuastionProperty;
                    textBoxAnswer.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].AnswerProperty;
                    textBoxNameOfResponder.ReadOnly = true;
                    return;
                }
                textBoxThemeBlitz.Visible = false;
                textBoxNameOfResponder.ReadOnly = false;
                numberOfPassedBlitz++;
            }
            
            if (resultBlitz)
            {
                scorePlayers++;
            }
            else if (!resultBlitz)
            {
                scoreSpectators++;
            }
            labelScore.Text = $"ЗНАТОКИ {scorePlayers} : {scoreSpectators} ЗРИТЕЛИ";
            labelCommunication.Text = "Выберите раунд";
            textBoxAuthor.Visible = false;
            textBoxQuestion.Visible = false;
            textBoxAnswer.Visible = false;
            buttonRight.Visible = false;
            buttonWrong.Visible = false;
            textBoxNameOfResponder.Text = "Введите имя отвечающего";
            textBoxNameOfResponder.Visible = false;
            if (numberOfQuestionsPassed < numberOfQuestions)
            {
                buttonQuestion.Visible = true;
                buttonQuestion.Text = $"Обычный вопрос ({numberOfQuestionsPassed} / {numberOfQuestions})";
            }
            if (numberOfPassedBlitz < numberOfBlitz)
            {
                buttonBlitz.Visible = true;
                buttonBlitz.Text = $"Блиц ({numberOfPassedBlitz} / {numberOfBlitz})";
            }
            if (numberOfQuestionsPassed == numberOfQuestions && numberOfPassedBlitz == numberOfBlitz)
            {
                this.Hide();

                End end = new End(blitz, questionsAndAnswers, scorePlayers, scoreSpectators);

                end.Show();
            }

            
        }

        private void buttonWrong_Click(object sender, EventArgs e)
        {
            if (textBoxNameOfResponder.Text == "Введите имя отвечающего")
            {
                MessageBox.Show("Вы не ввели имя отвечающего");
                return;
            }
            resultBlitz = false;
            if (textBoxThemeBlitz.Visible != true)
            {
                questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].NameOfResponderProperty = textBoxNameOfResponder.Text;
                questionsAndAnswers[counterQuestins[numberOfQuestionsPassed]].RightOrWrongProperty = false;
                numberOfQuestionsPassed++;
            }
            else if (textBoxThemeBlitz.Visible == true)
            {
                blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].NameOfResponderProperty = textBoxNameOfResponder.Text;
                blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].RightOrWrongProperty = false;
                numberOfPassedQuestionsInBlitz++;
                if (numberOfPassedQuestionsInBlitz < numberOfQuestionsInBlitz)
                {
                    textBoxQuestion.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].QuastionProperty;
                    textBoxAnswer.Text = blitz[counterBlitz[numberOfPassedBlitz]][numberOfPassedQuestionsInBlitz].AnswerProperty;
                    textBoxNameOfResponder.ReadOnly = true;
                    return;
                }
                textBoxThemeBlitz.Visible = false;
                textBoxNameOfResponder.ReadOnly = false;
                numberOfPassedBlitz++;
            }

            if (resultBlitz)
            {
                scorePlayers++;
            }
            else if (!resultBlitz)
            {
                scoreSpectators++;
            }
            labelScore.Text = $"ЗНАТОКИ {scorePlayers} : {scoreSpectators} ЗРИТЕЛИ";
            labelCommunication.Text = "Выберите раунд";
            textBoxAuthor.Visible = false;
            textBoxQuestion.Visible = false;
            textBoxAnswer.Visible = false;
            buttonRight.Visible = false;
            buttonWrong.Visible = false;
            textBoxNameOfResponder.Text = "Введите имя отвечающего";
            textBoxNameOfResponder.Visible = false;
            if (numberOfQuestionsPassed < numberOfQuestions)
            {
                buttonQuestion.Visible = true;
                buttonQuestion.Text = $"Обычный вопрос ({numberOfQuestionsPassed} / {numberOfQuestions})";
            }
            if (numberOfPassedBlitz < numberOfBlitz)
            {
                buttonBlitz.Visible = true;
                buttonBlitz.Text = $"Блиц ({numberOfPassedBlitz} / {numberOfBlitz})";
            }
            if (numberOfQuestionsPassed == numberOfQuestions && numberOfPassedBlitz == numberOfBlitz)
            {
                this.Hide();

                End end = new End(blitz, questionsAndAnswers, scorePlayers, scoreSpectators);

                end.Show();
            }
        }
    }
}
