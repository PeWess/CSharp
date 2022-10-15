using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework
{
    public class QuestionsEditor
    {
        #region Private Fields

        private List<Question> questions;
        private string filename;

        #endregion

        #region Properties

        public string FileName
        {
            set { filename = value; }
        }

        public Question this[int index]
        {
            get { return questions[index]; }
        }

        public int QuestionCounter
        {
            get { return questions.Count; }
        }

        #endregion

        #region Constructors

        public QuestionsEditor(string filename)
        {
            this.filename = filename;
            questions = new List<Question>();
        }

        #endregion

        #region Public Methods

        public void AddQuestion(string text, bool answer)
        {
            questions.Add(new Question() { Text = text, Answer = answer });
        }

        public void RemoveQuestion(int index)
        {
            if(questions != null && index < questions.Count && index >= 0)
            {
                questions.RemoveAt(index);
            }
        }

        public void LoadQuestions()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                questions = (List<Question>)xmlSerializer.Deserialize(stream);
            }
        }

        public void SaveQuestions()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, questions);
            }
        }

        #endregion
    }
}
