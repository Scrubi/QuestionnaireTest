using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireTest
{
    class Answer
    {
        public string UserName { get; }

        private List<bool> usersAnswers = new List<bool>();

        public Answer(string name, Questionnaire questionnaire)
        {
            UserName = name;
        }

        public void AddUsersAnswer(int id, bool answer)
        {
            usersAnswers.Add(answer);
        }

        public bool GetUsersAnswer(int id)
        {
            if (id >= 0 && id < usersAnswers.Count)
            {
                return usersAnswers[id];
            }
            else 
            {
                return false;
            }
        
            
        }
    }
}
