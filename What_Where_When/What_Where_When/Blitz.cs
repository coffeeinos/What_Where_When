using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Where_When
{
    public class Blitz : QuestionsAndAnswers
    {
        private string theme;

        public string ThemeProperty
        {
            get { return theme; }
            set { theme = value; }
        }

    }
}
