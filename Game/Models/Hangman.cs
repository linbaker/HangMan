namespace Game.Models
{
  public class Hangman
  {
    private static List<Right> Right {get; set;} = new List<Right> {};
    private static List<Wrong> Wrong {get; set;} = new List<Wrong> {};
    public int Id {get; set;}
    private List<Guess> _items;
    public string WordToGuess {get; set;}
    public string[] WordSolutionArray {get; set;} = {"rutabaga", "jurassic", "conditioner", "armchair", "kimono"};

    public Hangman() {
      WordToGuess =  WordSolutionArray[random.Next(5)-1];
      Guess.RightWrong();

    }

    public RightWrong() {
      foreach (Guess in List<Guess>)
      {
        If (WordToGuess.Contains(Guess))
        {
          Right.Add(Guess)
        } else {
          Wrong.Add(Guess)
        }
      }
    }

    // public void RightWrong () {
    //   If(WordToGuess.Contains()) {
    //     RightGuess.Add(guessLetter);
    //   }
    //   else
    //   {
    //       WrongGuess.Add(guessLetter);
    //   }
    // }
    //
    // public bool isUsed(char letterInput) {
    //   if (RightGuess.Countains(letterInput) || WrongGuess.Contains(letterInput))
    //   {
    //     Hangman.GuessLetter = letterInput;
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }
    //
    //


  }
}
