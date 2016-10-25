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
      //Fenstertitel umstellen
      Console.Title = "Rate eine Zahl";

      //Variabelen 
      //c ist hierbei eine Zählvariabele die angibt, wie viele Versuche man hat
      int eingabe, zuratendezahl, c = 3;

      //Einweisung
      Console.WriteLine("Bitte geben Sie die zu erratene Zahl ein.Sie muss zwichen 1 und 10 liegen.");
      //Schriftfarbe zu Schwarz ändern
      Console.ForegroundColor = ConsoleColor.Black;
      //Einlesen der Ergebnisvariabel
      int.TryParse(Console.ReadLine(), out zuratendezahl);
      //Schriftfarbe zu Grau ändern
      Console.ForegroundColor = ConsoleColor.Gray;

      //Testen, ob Variabele im Bereich ist
      if (zuratendezahl < 1 || zuratendezahl > 10) { Console.WriteLine("Die Zahl war üngültig"); Console.ReadLine(); return; }

      //Einlesen der Eingabevariabel
      Console.WriteLine("Raten Sie nun die Zahl");
      int.TryParse(Console.ReadLine(), out eingabe);

      //Schleife, die so lange läuft, wie eingabe != zuratendezahl UND c > 1 ist
      while (eingabe != zuratendezahl && c > 1)
      {
        //Testen, ob Variabele im Bereich ist
        if (eingabe < 1 || eingabe > 10) { Console.WriteLine("Die Zahl war üngültig"); Console.ReadLine(); return; }

        //Ausgabe "Leider Falsch"
        Console.WriteLine("Leider Falsch");

        //Prüfen ob Zahl größer oder kleiner ist
        if (eingabe > zuratendezahl)
        { Console.WriteLine("Die Zahl ist zu groß"); }
        else
        { Console.WriteLine("Die Zahl ist zu klein"); }


        Console.WriteLine("Raten Sie nun die Zahl");
        //c = c-1
        c--;
        //Anzeigen wie viele Versuche verbleiben
        Console.WriteLine("Sie haben noch " + c + " Versuche");
        int.TryParse(Console.ReadLine(), out eingabe);
      }

      if (eingabe == zuratendezahl)
      {
        //Hier hat man gewonnen
        Console.WriteLine("Herzlichen glückwunsch, Sie haben gewonnen");
        Console.ReadLine();
        return;
      }
      else
      {
        //Hier sind die Versuche ausgegangen
        Console.WriteLine("Sie haben alle Versuche aufgebraucht. Die richte Zahl war: " + zuratendezahl);
        Console.ReadLine();
      }
    }
  }
}
