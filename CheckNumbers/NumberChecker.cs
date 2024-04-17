namespace CheckNumbers
{
  public class NumberChecker
  {
    [Obsolete ("Refactored")]
    public static List<string> AcceptNumbers_old(int number)
    {

      var list = new List<string>();


      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          list.Add("Brad Mruzek");
        }
        else if (i % 3 == 0)
        {
          list.Add("Brad");
        }
        else if (i % 5 == 0)
        {
          list.Add("Mruzek");
        }
        else
        {
          list.Add(i.ToString());
        }
      }
      return list;
    }
    
    public static IEnumerable<string> AcceptNumbers(int number)
    {

      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          yield return "Brad Mruzek";
        }
        else if (i % 3 == 0)
        {
          yield return "Brad";
        }
        else if (i % 5 == 0)
        {
          yield return "Mruzek";
        }
        else
        {
          yield return i.ToString();
        }
      }
    }
  }
}
