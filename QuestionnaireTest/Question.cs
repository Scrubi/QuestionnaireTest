using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireTest
{
    class Question
    {
        public int Id { get; }

        public string Text { get; }

        public bool CorrectAnswer { get; }

        public Question(int id, string text, bool correctAnswer)
        {
            Id = id;
            Text = text;
            CorrectAnswer = correctAnswer;
        }

        public bool IsAnswerCorrect(bool answer)
        {
            return answer == CorrectAnswer;
        }
    }
}
