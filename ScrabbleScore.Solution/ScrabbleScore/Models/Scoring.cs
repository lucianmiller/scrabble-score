using System.Text;
using System;

namespace ScrabbleScore.Models
{
  public class Scoring
  {
    public string PlayerWord { get; set; }
    public string CleanPlayerWord { get; set; }
    public int TotalScore { get; set; }
    public string ScoreOne { get; set; }
    public string ScoreTwo { get; set; }
    public string ScoreThree { get; set; }
    public string ScoreFour { get; set; }
    public string ScoreFive { get; set; }
    public string ScoreEight { get; set; }
    public string ScoreTen { get; set; }

    public Scoring(string playerWord) 
    {
      ScoreOne = "aeioulnrst";
      ScoreTwo = "dg";
      ScoreThree = "bcmp";
      ScoreFour = "fhvwy";
      ScoreFive = "k";
      ScoreEight = "jx";
      ScoreTen = "qz";
      PlayerWord = playerWord;
      CleanPlayerWord = "";
      TotalScore = 0;
    }

    //Solution from https://stackoverflow.com/questions/421616/how-can-i-strip-punctuation-from-a-string
    public void SanitizeInputWord()
    {
      var sb = new StringBuilder();

      foreach (char c in this.PlayerWord)
      {
        if (!char.IsPunctuation(c))
        sb.Append(c);
      }

      this.CleanPlayerWord = sb.ToString().ToLower();
    }

    public void DetermineScore()
    {
      foreach (char c in this.CleanPlayerWord)
      {
        if(this.ScoreOne.Contains(c))
        {
          this.TotalScore += 1;
        }
        else if (this.ScoreTwo.Contains(c))
        {
          this.TotalScore += 2;
        }
        else if (this.ScoreThree.Contains(c))
        {
          this.TotalScore += 3;
        }
        else if (this.ScoreFour.Contains(c))
        {
          this.TotalScore += 4;
        }
        else if (this.ScoreFive.Contains(c))
        {
          this.TotalScore += 5;
        }
        else if (this.ScoreEight.Contains(c))
        {
          this.TotalScore += 8;
        }
        else if (this.ScoreTen.Contains(c))
        {
          this.TotalScore += 10;
        }
      }
    }

    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Welcome to Scrabble Score!");
        Console.WriteLine("Please enter your word:");
        string userWord = Console.ReadLine();
        Scoring newScore = new Scoring(userWord);
        newScore.SanitizeInputWord();
        newScore.DetermineScore();
        Console.WriteLine("The score of your word is: " + newScore.TotalScore);
      }
    }
  }
}