using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Where_When
{
    public class QuestionsAndAnswers
    {
        protected string quastion;

        public string QuastionProperty
        {
            get { return quastion; }
            set { quastion = value; }
        }

        protected string answer;

        public string AnswerProperty
        {
            get { return answer; }
            set { answer = value; }
        }

        private string author;

        public string AuthorProperty
        {
            get { return author; }
            set { author = value; }
        }

        private bool rightOrWrong;

        public bool RightOrWrongProperty
        {
            get { return rightOrWrong; }
            set { rightOrWrong = value; }
        }

        private string nameOfResponder;

        public string NameOfResponderProperty
        {
            get { return nameOfResponder; }
            set { nameOfResponder = value; }
        }

    }
}
