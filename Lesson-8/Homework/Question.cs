using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Question
    {
        #region Properties

        public string Text { get; set; }

        public bool Answer { get; set; }

        #endregion

        #region Constructors

        public Question()
        {

        }

        public Question(string text, bool answer)
        {
            Text = text;
            Answer = answer;
        }

        #endregion
    }
}
