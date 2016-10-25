using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate_eine_Zahl
{
  class Program
  {
    static void Main(string[] args)
    {
      int eingabe, zuratendezahl, c = 3;

      Console.WriteLine("Bitte geben Sie die zu erratene Zahl ein.Sie muss zwichen 1 und 10 liegen.");
      Console.ForegroundColor = ConsoleColor.Black;
      int.TryParse(Console.ReadLine(), out zuratendezahl);
      Console.ForegroundColor = ConsoleColor.Gray;
      if (zuratendezahl < 1 || zuratendezahl > 10) { Console.WriteLine("Die Zahl war üngültig"); Console.ReadLine(); return; }

      Console.WriteLine("Raten Sie nun die Zahl");
      int.TryParse(Console.ReadLine(), out eingabe);

      while (eingabe != zuratendezahl && c > 1)
      {
        if (eingabe < 1 || eingabe > 10) { Console.WriteLine("Die Zahl war üngültig"); Console.ReadLine(); return; }
        Console.WriteLine("Leider Falsch");
        if (eingabe > zuratendezahl)
        {
          Console.WriteLine("Die Zahl ist zu groß");
        }
        else
        {
          Console.WriteLine("Die Zahl ist zu klein");
        }
        Console.WriteLine("Raten Sie nun die Zahl");
        c--;
        Console.WriteLine("Sie haben noch " + c + " Versuche");
        int.TryParse(Console.ReadLine(), out eingabe);
      }
      if (eingabe == zuratendezahl)
      {
        Console.WriteLine("Herzlichen glückwunsch, Sie haben gewonnen");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("Sie haben alle Versuche aufgebraucht. Die richte Zahl war: " + zuratendezahl);
        Console.ReadLine();
      }
    }
  }
}
