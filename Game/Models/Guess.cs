using System.Collections.Generic;

namespace Game.Models
{
  public class Guess
  {
    public char GuessLetter {get; set;}
    public int Id {get; set;}
    public static List<Guess> GuessList {get; set;} = new List<Guess> {};


    public Guess (char guessLetter)
    {
      GuessLetter = guessLetter;
      GuessList.Add(this);
      Id = GuessList.Count;

    }
  }
}
