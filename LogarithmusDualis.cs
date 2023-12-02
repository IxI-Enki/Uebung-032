/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF
 *------------------------------------------------------------------------------
 *                      Jan Ritt
 *------------------------------------------------------------------------------
 *  Description:  The program reads in a Number and outputs a guess of the ln
 *                of said number, eg. how often can said number be divided by 2
 *------------------------------------------------------------------------------
*/

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