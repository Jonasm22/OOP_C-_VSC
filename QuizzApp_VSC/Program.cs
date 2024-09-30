using System.Collections.Generic;
using System;
using MyQuizApp;


public class Program
{
       static void Main(string[] args)
       {
              Question[] questions = new Question[]
              {

                     new Question(
                      "What is the capital of Germany?", // question text 
                     new string[] { "Paris", "Berlin", "London", "Barcelona"}, // Answer Array
                            1// correct asnwer



                     ),
                     new Question(
                      "What is 2+2: ?", // question text 
                     new string[] { "3", "4", "5", "6"}, // Answer Array
                            1// correct asnwer



                     ),
                     new Question(
                      "Who wrote Hamblet?", // question text 
                     new string[] { "Goethe", "Austen", "Shakespeare", "Dickes"}, // Answer Array
                            2// correct asnwer
                     )
              };

              Quiz myQuiz = new Quiz(questions);
              myQuiz.StarQuiz();
              Console.ReadLine();
       }

}

