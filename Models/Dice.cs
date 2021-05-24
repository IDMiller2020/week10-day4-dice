namespace dice.Models
{
  public class Dice
  {
    public int Sides { get; set; }
    public int Roll()
    {
      Random rnd = new Random();
      return rnd.Next(1, Sides + 1);
    }
    public Dice(int Sides)
    {
      Sides = Sides;
    }
  }
}