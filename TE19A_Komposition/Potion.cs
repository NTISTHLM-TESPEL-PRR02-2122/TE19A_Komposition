using System;

namespace TE19A_Komposition
{
  public class Potion
  {
    // public int amount = 30;

    public void Affect(Hero target)
    {
      target.hp -= 50;
    }
  }
}