using System;
using System.Collections.Generic;

namespace Anagram
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter word to check:");
      string userWord = Console.ReadLine();
      string wordCopy = SortString(userWord);

      Console.WriteLine("Enter list to check against. Type 'done' when finished:");
      List<string> wordList = new List<String>{};
      
      string currentWord = Console.ReadLine();
      while(currentWord != "done" && currentWord != "Done")
      {
        wordList.Add(currentWord);
        Console.WriteLine("Enter next word ('done' when finished):");
        currentWord = Console.ReadLine();
      }
      List<string> listCopy = new List<String>(wordList);

      for(int i = 0; i < wordList.Count; i++)
      {
        listCopy[i] = SortString(wordList[i]);
      }

      for(int j = 0; j < listCopy.Count; j++)
      {
        if(string.Equals(listCopy[j], wordCopy) == true)
        {
          listCopy[j] = "+";
        }
      }

      for(int k = 0; k < wordList.Count; k++)
      {
        if(listCopy[k] == "+")
        {
          Console.WriteLine(wordList[k] + " is an Anagram of " + userWord + "!");
        }

      }

      Console.WriteLine("");
      Console.WriteLine("Thank you for using the program! If any anagrams were found, they will have been printed above. Goodbye.");

    }

    static string SortString(string str)
    {
      char[] chars = str.ToCharArray();
      Array.Sort(chars);
      return new String(chars);

    }

  }
}

//                                                     PLAIN ENGLISH SPECS
//---------------------------------------------------------------------------------------------------------------------------
//user enters word to check for anagrams of -------------------------------------> program sets variable equal to user input
//user enters a word to check against initial word entered ----------------------> program adds word to list
//user enters another word to check against initial word entered ----------------> program adds word to list
//user indicates they are done entering words by typing 'done' ------------------> program checks for anagrams and returns any to user