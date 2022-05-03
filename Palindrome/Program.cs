using System;
using System.Linq;
using Palindrome;

public class Program {
  public static void Main() {
    Console.WriteLine("Please Enter a word");
    string Word = Console.ReadLine();
    Word inputWord = new Word(Word);
    
    if (inputWord.ReverseWord()) {
      Console.WriteLine("This word " + Word + " is a palindrome!");
    }
    else 
    {
      Console.WriteLine("This word " + Word + " is not a palindrome!");
    }
  }
}