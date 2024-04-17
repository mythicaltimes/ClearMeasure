using CheckNumbers;
using Xunit.Abstractions;

namespace CheckNumbersTests
{
  public class NumberCheckerTests
  {
    private static ITestOutputHelper _output;

    public NumberCheckerTests(ITestOutputHelper output)
    {
      _output = output;
    }

    [Fact]
    public void CheckNumbersTest()
    {

      //Arrange

      //Act
      var list = NumberChecker.AcceptNumbers(100);
      var result = string.Join(',', list);
      _output.WriteLine(result);

      //Assert
      Assert.True(string.IsNullOrEmpty(result) == false);

    }

    [Fact]
    public void CheckMaxValueTest()
    {
      //Arrange

      //Act
      var list = NumberChecker.AcceptNumbers(int.MaxValue);
      var result = string.Join(',', list.Take(10));
      _output.WriteLine(result);

      //Assert
      Assert.True(string.IsNullOrEmpty(result) == false);
    }
  }
}