using System;
namespace Palindrome
{
  public class Word
  {
    public string String {get; set;}
    public char[] CharArray {get; set;}
    public Word(string word)
    {
      String = word;
      CharArray = word.ToCharArray();
    }
    public char[] ReverseWord()
    {
      Array.Reverse(CharArray);
      return CharArray;
    }
  }
}

