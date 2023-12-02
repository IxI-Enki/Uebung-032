# Uebung-032  --  Logarithmus Dualis
<!--
## Lernziele:

## Aufgabenstellung:

### Beispiel:
### Beispielausgabe:

#### Hinweis:

-------------------------------
## *Zusatzaufgabe:*



-->
-------------------------------
# **SPOILER**

```c#
namespace LogarithmusDualis
{
  internal class Programm
  {
    static void Main()
    {
      string userInput;
      int userInteger,
          originalInput,
          output = 0;

      Console.Write("\n       LogarithmusDualis        " +
                    "\n================================" +
                    "\n Geben Sie eine ganze Zahl ein." +
                    "\n ");
      userInput = Console.ReadLine();
      int.TryParse(userInput, out userInteger);

      originalInput = userInteger;
      while (userInteger / 2 > 0)
      {
        userInteger = userInteger / 2;
        output++;
      }
      Console.Write($"\n {originalInput} kann {output} x durch Zwei dividiert werden. ");

      Console.Write("\nZum Beenden bitte Eingabetaste drücken ...");
      Console.ReadLine();
      Console.Clear();
    }
  }
}
```
