using System;
using System.Collections.Generic;

namespace QuestionnaireTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Friday Quiz App";

            DataHandler handler = new DataHandler();
            handler.AddTestData();

            bool showMenu = true;
            while (showMenu)
            {
                handler.PrintAnswerMatrix();
                showMenu = MainMenu(handler);
            }
        }

        private static bool MainMenu(DataHandler handler)
        {
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("              QUIZ             ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You will be asked to input your nickname");
            Console.WriteLine("After that the quiz will begin!");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
           
            handler.FillQuestionnaire();
            return true;
        }
    }
     
}


