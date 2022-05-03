using System;
using System.Text;
using System.Linq;

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
    public bool ReverseWord()
    {
      Array.Reverse(CharArray);
      char[] TempArray = String.ToCharArray();
      bool result = TempArray.SequenceEqual(CharArray);
      return result;
    }
  }
}

