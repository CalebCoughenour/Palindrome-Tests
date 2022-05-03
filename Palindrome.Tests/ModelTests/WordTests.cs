using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

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
    Console.WriteLine("char Array" + charArray);
    Assert.AreEqual(charArray[0], inputWord.CharArray[0]);
  }
  [TestMethod]
  public void ReverseWord_MakesWordReversed_Char()
  {
    Word inputWord = new Word("Hello");
    char[] charArray = {'o', 'l', 'l', 'e', 'H'};
    inputWord.ReverseWord();
    Assert.AreEqual(charArray[0], inputWord.CharArray[0]);
  }
 }
}