//using System;

namespace ScrabbleScore.Models
{
  public class Scoring
  {
    public string PlayerWord { get; set; }
    public string[] ScoreOne { get; set; }
    public string[] ScoreTwo { get; set; }
    public string[] ScoreThree { get; set; }
    public string[] ScoreFour { get; set; }
    public string[] ScoreFive { get; set; }
    public string[] ScoreEight { get; set; }
    public string[] ScoreTen { get; set; }

    public Scoring(string playerWord) 
    {
      ScoreOne = new string[] { "a", "e", "i", "o", "u","l", "n", "r", "s", "t" };
      ScoreTwo = new string[] { "d", "g" };
      ScoreThree = new string[] { "b", "c", "m", "p" };
      ScoreFour = new string[] { "f", "h", "v", "w", "y" };
      ScoreFive = new string[] { "k" };
      ScoreEight = new string[] { "j", "x" };
      ScoreTen = new string[] { "q", "z" };
      PlayerWord = playerWord;
    }

    //Solution from https://stackoverflow.com/questions/421616/how-can-i-strip-punctuation-from-a-string
    public string SanitizeInputWord(userWord)
    {
      var sb = new StringBuilder();

      foreach (char c in userWord)
      {
        if (!char.IsPunctuation(c))
        sb.Append(c);
      }

      userWord = sb.ToString();
      return userWord;
    }

    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Welcome to Scrabble Score!");
        Console.WriteLine("Please enter your word:");
        string userWord = Console.ReadLine();
        string cleanUserWord = SanitizeInputWord(userWord);
      }
    }
  }
}