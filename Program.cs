// See https://aka.ms/new-console-template for more information
public interface Score
{
  void DisplayScore();
  int Calculate();
  public interface Location
  {
    void InputCity(string city);
    void DisplayCity();
  }
  public class Player : Score, Location
  {
  public int PlayerId;
  public string PlayerName;
  public int score1, score2;
  private string city;
  
  public void InputCity(string pcity)
  {
    city = pcity;
  }
  public void DisplayCity()
  {
    Console.WriteLine("The player is from " + city);
  }
    public void DisplayScore()
    {
    Console.WriteLine("The score for try 1 is " + score1);
    Console.WriteLine("The score for try 2 is " + score2);
    }
    public int Calculate()
    {
      return (score1 + score2);
    } 
  }
  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player();
      player1.PlayerId = 1;
      player1.PlayerName = "Ryan";

      player1.score1 = 10;
      player1.score2 = 20;

      player1.DisplayScore();
      Console.WriteLine("The Total score is " + player1.Calculate());
      player1.InputCity("Atlanta");
      player1.DisplayCity();
      Console.Read();
    }
  }
}

