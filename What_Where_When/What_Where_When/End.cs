using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace What_Where_When
{
    public partial class End : Form
    {
        public End(List<List<Blitz>> blitz, List<QuestionsAndAnswers> questionsAndAnswers, int scorePlayers, int scoreSpectators)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            if (scorePlayers > scoreSpectators)
            {
                labelCommunication.Text = $"Игра окончена со счетом {scorePlayers} : {scoreSpectators} в пользу знатоков !";
            }
            else if (scorePlayers < scoreSpectators)
            {
                labelCommunication.Text = $"Игра окончена со счетом {scorePlayers} : {scoreSpectators} в пользу зрителей !";
            }
            else
            {
                labelCommunication.Text = $"Игра окончена со счетом {scorePlayers} : {scoreSpectators}. Ничья !";
            }

            richTextBoxScore.Text = "Обычные вопросы:";
            foreach (var item in questionsAndAnswers)
            {
                string result = "не взят";
                if (item.RightOrWrongProperty)
                {
                    result = "взят";
                }
                richTextBoxScore.Text += $"\n\n\tВопрос: {item.QuastionProperty} \n\n\tОтвет: {item.AnswerProperty} \n\n\tАвтор вопроса: {item.AuthorProperty} \n\n\tОтвечавший: {item.NameOfResponderProperty} \n\n\tРезультат: {result};";
                richTextBoxScore.Text += "\n";
            }
            richTextBoxScore.Text += "\nБлицы:";
            int counter = 1;
            foreach (var item in blitz)
            {
                richTextBoxScore.Text += $"\n\tБлицы №:{counter}";
                for (int i = 0; i < item.Count; i++)
                {
                    if (i == 0)
                    {
                        richTextBoxScore.Text += $"\n\t\tТема блица: {item[i].ThemeProperty}";
                        richTextBoxScore.Text += $"\n\t\tАвтор блица: {item[i].AuthorProperty}";
                        richTextBoxScore.Text += $"\n\t\tОтвечавший на блиц: {item[i].NameOfResponderProperty}";
                    }
                    string result = "не взят";
                    if (item[i].RightOrWrongProperty)
                    {
                        result = "взят";
                    }
                    richTextBoxScore.Text += $"\n\t\t\tВопрос №{i+1}: {item[i].QuastionProperty}";
                    richTextBoxScore.Text += $"\n\t\t\tОтвет: {item[i].AnswerProperty}";
                    richTextBoxScore.Text += $"\n\t\t\tРезультат: {result}";
                    richTextBoxScore.Text += "\n";
                }
                counter++;
            }


            richTextBoxScore.Text += "\nЗнатоки:";
            List<string> playersAll = new List<string>();
            foreach (var item in questionsAndAnswers)
            {
                playersAll.Add(item.NameOfResponderProperty);
            }
            List<string> playersWithoutDuplicate = new List<string>(playersAll.Distinct());
            foreach (var player in playersWithoutDuplicate)
            {
                int numberResponses = 0;
                foreach (var item in questionsAndAnswers)
                {
                    if (item.NameOfResponderProperty == player)
                    {
                        numberResponses++;
                    }
                }
                bool blitzResponses = false;
                foreach (var item in blitz)
                {
                    int counterForBlitz = 0;
                    foreach (var item2 in item)
                    {
                        if (item2.NameOfResponderProperty == player && item2.RightOrWrongProperty)
                        {
                            counterForBlitz++;
                        }
                    }
                    if (counterForBlitz == item.Count)
                    {
                        blitzResponses = true;
                    }
                }
                string blitzResult = "не взят";
                if (blitzResponses)
                {
                    blitzResult = "взят";
                }
                richTextBoxScore.Text += $"\n\t Знаток: {player} \n\tКоличество правильных ответов на обычный вопрос: {numberResponses} \n\tБлитц: {blitzResult}";
                richTextBoxScore.Text += "\n";
            }
        }

        private void End_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Document doc = application.Documents.Add(Visible:true);
            Range range = doc.Range();
            range.Text = richTextBoxScore.Text;
            doc.Save();
            doc.Close();
            application.Quit();
        }
    }
}
