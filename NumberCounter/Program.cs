using System.Xml;
using CheckNumbers;

namespace NumberCounter
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var list = NumberChecker.AcceptNumbers(int.MaxValue);
      foreach (var s in list)
      {
        Console.WriteLine(s);
      }
    }
  }
}
