namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.WizardsByRowling(wizards);
        var wizardsbyJK = new List<String> {"harry", "vold"};
        //Assert
        wizbyrowl.Should().BeEquivalentTo("Lord Voldemort", "Harry Potter");
    }
}
