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
  }
}