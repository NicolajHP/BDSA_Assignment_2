namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Test_Wizards_By_JKRowling_returns_LordVoldemort_and_HarryPotter()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.WizardsByRowling(wizards);
        //Assert
        wizbyrowl.Should().BeEquivalentTo("Lord Voldemort", "Harry Potter");
    }

    [Fact]
    public void Test_First_Sith_Returns_DarthVader()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.firstSithAppearance(wizards);
        //Assert
        wizbyrowl.Should().BeEquivalentTo("Darth Vader");
    }

    [Fact]
    public void Test_Return_all_Wizards_From_HP()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.AllWizardsInHP(wizards);
        //Assert
        wizbyrowl.Should().BeEquivalentTo(new[] {("Lord Voldemort", 1997), ("Harry Potter", 1997)});
    }

    [Fact]
    public void Test_list_By_Creator()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.ListOfWizByCreator(wizards);
        //Assert
        wizbyrowl.Take(2).Should().BeEquivalentTo(new[] {("Lord Voldemort", 1997), ("Harry Potter", 1997)});
    }
}
