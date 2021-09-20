using System;

namespace TE19A_Komposition
{
  class Program
  {
    
    static void Main(string[] args)
    {
      Hero luigi = new Hero();
      Hero waluigi = new Hero();

      luigi.target = waluigi;
      waluigi.target = luigi;

      luigi.target.target.target.hp -= 10;

      Console.WriteLine(luigi.hp);
      Console.WriteLine(waluigi.hp);



      Potion healthPotion = new Potion();

      // h.Drink(healthPotion);

      // h.Drink(new Potion());

      // Console.WriteLine(h.headwear.niceness);

      // int i = 100;

      // int k = i;
      // Hero h2 = h;

      // DamageFromEnvironment(h);
      // LowerValue(i);

      // Console.WriteLine(h2.hp);
      // Console.WriteLine(i);
      Console.ReadLine();
    }

    static void DamageFromEnvironment(Hero target)
    {
      target.hp -= 50;
    }

    static void LowerValue(int original)
    {
      original -= 50;
    }
  }
}
