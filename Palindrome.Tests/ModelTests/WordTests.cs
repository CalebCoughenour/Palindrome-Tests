using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System.Linq;

namespace Palindrome.Tests
{
 [TestClass]
 public class WordTests 
 {
  [TestMethod]
  public void StringToChar_ArrayOfCharacters_Char()
  {
    Word inputWord = new Word("Hello");
    char[] charArray = {'H', 'e', 'l', 'l', 'o'};
    Assert.AreEqual(true, charArray.SequenceEqual(inputWord.CharArray));
  }
  [TestMethod]
  public void ReverseWord_MakesWordReversed_Char()
  {
    Word inputWord = new Word("Hello");
    char[] charArray = {'o', 'l', 'l', 'e', 'H'};
    inputWord.ReverseWord();
    Assert.AreEqual(true, charArray.SequenceEqual(inputWord.CharArray));
  }
  [TestMethod]
  public void ReverseWord_ComparesWordToReverse_True()
  {
    Word inputWord = new Word("tacocat");
    Assert.AreEqual(true, inputWord.ReverseWord());
  }
  [TestMethod]
  public void ReverseWord_ComparesWordToReverse_False()
  {
    Word inputWord = new Word("racecat");
    Assert.AreEqual(false, inputWord.ReverseWord());
  }
 }
}