using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireTest
{

        class Questionnaire
        {
        public List<Question> QuestionsList { get; } = new List<Question>();

        public Questionnaire()
        {
            AddQuestions();
        }

        public void AddQuestion(int id, string text, bool correctAnswer)
        {
            QuestionsList.Add(new Question(id, text, correctAnswer));
        }

        public void AddQuestions()
        {
            AddQuestion(0, "Is the moon larger than earth?      ", false);
            AddQuestion(1, "Did you have fun coding this solution?  ", true);
            AddQuestion(2, "Are you excited for next weeks test?", true);
            AddQuestion(3, "Do you have Corona?                 ", false);
        }



    }
  
}
