using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoringTests
  {
    [TestMethod]
    public void ScoringConstructor_CreateInstanceOfScoring_Scoring()
    {
      Scoring newScore = new Scoring("word");
      Assert.AreEqual(typeof(Scoring), newScore.GetType());
    }
  }
}