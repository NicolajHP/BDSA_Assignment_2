namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void return_true_if_uri_uses_https()
    {
        //Arrange
        var uri = new Uri("https://dotnetpearls.com");

        //Act
        var result = uri.isSecure();

        //Assert
        result.Should().Be(true);
    }

    [Fact]
    public void return_false_if_uri_uses_http()
    {
        //Arrange
        var uri = new Uri("http://dotnetpearls.com");

        //Act
        var result = uri.isSecure();

        //Assert
        result.Should().Be(false);
    }

    [Fact]
    public void test_for_wordcount()
    {
        //Arrange
        var text = "Hello my friend !";

        //Act
        var result = text.WordCount();

        //Assert
        result.Should().Be(3);
    }

    [Fact]
    public void test_for_wordcount_return_11()
    {
        //Arrange
        var text = "Hello my friend, this is a very awesome string @ ? with symbols!! !! 42";

        //Act
        var result = text.WordCount();

        //Assert
        result.Should().Be(11);
    }
}

