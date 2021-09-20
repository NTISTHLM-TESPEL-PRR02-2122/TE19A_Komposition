using System;

namespace TE19A_Komposition
{
  public class Hero
  {
    public int hp = 100;

    public Hero target;

    public Hat headwear = new Hat();

    public void Drink(Potion p)
    {
      p.Affect(this);
    }
  }
}