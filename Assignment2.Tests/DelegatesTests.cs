namespace Assignment2.Tests;
using System.Linq;

public class DelegatesTests
{
    [Fact]
    public void takes_string_and_prints_in_reverse_order()
    {
        //Arrange
        var text = "These aren't the droids you're looking for.";
        Func<string, string> MyMethod = c => new string(c.Reverse().ToArray());

        //Act
        var result = MyMethod(text);

        //Assert
        result.Should().Be(".rof gnikool er'uoy sdiord eht t'nera esehT");
    }

    [Fact]
    public void takes_two_decimals_and_returns_the_product()
    {
        //Arrange
        var num1 = 263346.87654;
        var num2 = 3453.3645;
        Func<double, double, double> MyMethod = (x, y) => x * y;

        //Act
        var res = MyMethod(num1, num2);

        //Assert
        res.Should().Be(num1*num2);
    }

    [Fact]
    public void takes_int__and_string_returns_true_if_equal()
    {
        //Arrange
        var num = 42;
        var str = "0042";
        Func<int, string, bool> MyMethod = (number, text) => int.Parse(text) == number;

        //Act
        var res = MyMethod(num, str);

        //Assert
        res.Should().Be(true);
    }

    [Fact]
    public void takes_int__and_string_returns_true_if_equal_false()
    {
        //Arrange
        var num = 42;
        var str = "004200000";
        Func<int, string, bool> MyMethod = (number, text) => int.Parse(text) == number;

        //Act
        var res = MyMethod(num, str);

        //Assert
        res.Should().Be(false);
    }

  
}
