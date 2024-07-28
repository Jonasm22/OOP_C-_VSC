

namespace MyQuizApp
{

    public class Quiz
    {

        //Take Question-class to proof each question.
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {

            this._questions = questions;
            _score = 0;


        }

        public void StarQuiz()
        {

            System.Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; // display question Numbers

            foreach (Question question in _questions)
            {

                System.Console.WriteLine($"Question: {questionNumber++}:");
                displayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {

                    System.Console.WriteLine("Correct!");
                    _score++;


                }
                else
                {


                    System.Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");


                }

            }
            DisplayResult();
        }

        public void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                **Result**                ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.ResetColor();

            System.Console.WriteLine($"Your score is:  {_score} out of {_questions.Length}");
            double porcentage = (double)_score / _questions.Length;

            if (porcentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent");

            }

            else if (porcentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");

            }
            Console.ResetColor();



        }


        // metho to display the question
        private void displayQuestion(Question question)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                **Question**                ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // change text color
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();   // reset text color

                Console.WriteLine($". {question.Answers[i]}");

            }

        }

        public int GetUserChoice()
        {

            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {

                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4:");
                input = Console.ReadLine();


            }

            return choice - 1;




        }




    }



}
