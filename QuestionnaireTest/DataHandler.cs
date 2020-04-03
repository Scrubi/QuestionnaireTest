using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireTest
{
    class DataHandler
    {
        public List<Answer> AnswersList { get; set; } = new List<Answer>();

        public Questionnaire MainQuestionnaire { get; set; } = new Questionnaire();

        public void AddTestData()
        {
            Answer answer = new Answer("Pepe", MainQuestionnaire);
            answer.AddUsersAnswer(0, true);
            answer.AddUsersAnswer(1, true);
            answer.AddUsersAnswer(2, true);
            answer.AddUsersAnswer(3, true);
            AnswersList.Add(answer);

            answer = new Answer("KekW", MainQuestionnaire);
            answer.AddUsersAnswer(0, false);
            answer.AddUsersAnswer(1, true);
            answer.AddUsersAnswer(2, false);
            answer.AddUsersAnswer(3, false);
            AnswersList.Add(answer);

            answer = new Answer("4Head", MainQuestionnaire);
            answer.AddUsersAnswer(0, false);
            answer.AddUsersAnswer(1, true);
            answer.AddUsersAnswer(2, true);
            answer.AddUsersAnswer(3, true);
            AnswersList.Add(answer);
        }

        public void FillQuestionnaire()
        {
            Console.WriteLine("Write your nickname:");
            string userName = Console.ReadLine();

            Answer answer = new Answer(userName, MainQuestionnaire);
            AnswersList.Add(answer);
            int id = 0;

            foreach (var question in MainQuestionnaire.QuestionsList)
            {
                Console.WriteLine();
                bool boolAnswer = AskQuestion(question);
                answer.AddUsersAnswer(id, boolAnswer);
                id++;
            }
        }

        public bool AskQuestion(Question question)
        {
            Console.WriteLine(question.Text);
            bool answer = AskTrueOrFalse();

            if (question.IsAnswerCorrect(answer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tCorrect!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tWrong!");
            }

            Console.ResetColor();
            return answer;
        }

        public void PrintAnswerMatrix()
        {
            Console.Write("\t\t\t\t\t");
            foreach (Answer answer in AnswersList)
            {
                Console.Write($"\t{answer.UserName}");
            }
            Console.WriteLine("\tCorrect Answer");
            Console.WriteLine();

            foreach (Question question in MainQuestionnaire.QuestionsList)
            {
                int id = question.Id;
                Console.Write($"{id + 1}. {question.Text} ");
                foreach (Answer answer in AnswersList)
                {
                    bool usersAnswer = answer.GetUsersAnswer(id);
                    Console.Write("\t");
                    PrintAnswerStatus(question, usersAnswer);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t{question.CorrectAnswer}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private void PrintAnswerStatus(Question question, bool usersAnswer)
        {
            if (question.IsAnswerCorrect(usersAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("True");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("False");
            }
            Console.ResetColor();
        }

        public bool AskTrueOrFalse()
        {
            Console.WriteLine("(1) True or (2) False?");
            while (true)
            {
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                    
                        return true;

                    case "2":
                    
                        return false;
                }
                Console.WriteLine("Invalid answer. Try again:");
            }
        }


    }
}

