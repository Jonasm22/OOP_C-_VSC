using System.Reflection;

namespace MyQuizApp
{
  public class Question
  {
    public string QuestionText { get; set; }
    public string[] Answers { get; set; }
    public int CorrectAnswerIndex { get; set; }

    public Question(string questionText, string[] answer, int correctAnswerIndex)
    {
      QuestionText = questionText;
      Answers = answer;
      CorrectAnswerIndex = correctAnswerIndex;
    }
    public bool IsCorrectAnswer(int choice)
    {
      return CorrectAnswerIndex == choice; // alternative to proof is equals as 0 to false;
    }
  }



}