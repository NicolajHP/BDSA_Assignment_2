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
    public void Test_Wizards_By_JKRowling_returns_LordVoldemort_and_HarryPotter_With_Extentions()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.WizardsByRowlingExtenstion(wizards);
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
    public void Test_First_Sith_Returns_DarthVader_Extension()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.firstSithAppearanceExtension(wizards);
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
        public void Test_Return_all_Wizards_From_HP_Extension()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        //Act
        var wizbyrowl = Queries.AllWizardsInHPExtension(wizards);
        //Assert
        wizbyrowl.Should().BeEquivalentTo(new[] {("Lord Voldemort", 1997), ("Harry Potter", 1997)});
    }

    [Fact]
    public void Test_list_By_Creator()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        var ListList = new List<List<Wizard>>();
        ListList.Add(new List<Wizard>{new Wizard("Mickey Mouse","Fantasia",1940,"Walt Disney")});
        ListList.Add(new List<Wizard>{new Wizard("Glinda The Good Witch","The Wizard of Oz",1939,"L. Frank Baum")});
        ListList.Add(new List<Wizard>{new Wizard("Zatanna Zatara","hawkman #4",1964,"Julius Schwartz")});
        ListList.Add(new List<Wizard>{new Wizard("Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien"), new Wizard("Gandalf","The Fellowship of the Ring",1954,"J.R.R. Tolkien")});
        ListList.Add(new List<Wizard>{new Wizard("Lord Voldemort","Harry Potter and The Philosopher's Stone",1997,"J.K. Rowling"), new Wizard("Harry Potter","Harry Potter and The Philosopher's Stone",1997,"J.K. Rowling")});
        ListList.Add(new List<Wizard>{new Wizard("Darth Vader","Star Wars",1977,"George Lucas"), new Wizard("Darth Sidious","Star Wars",1980,"George Lucas")});
        ListList.Add(new List<Wizard>{new Wizard("Merlin","Prophetiae Merlini",1200,"Geoffrey of Monmouth")});
        
        //Act
        var wizbyrowl = Queries.ListOfWizByCreator(wizards);
        
        //Assert
        wizbyrowl.Should().BeEquivalentTo(ListList);
        
    }

    [Fact]
    public void Test_list_By_CreatorExtension()
    {
        //Arrange
        var wizards = WizardCollection.Create();
        var ListList = new List<List<Wizard>>();
        ListList.Add(new List<Wizard>{new Wizard("Mickey Mouse","Fantasia",1940,"Walt Disney")});
        ListList.Add(new List<Wizard>{new Wizard("Glinda The Good Witch","The Wizard of Oz",1939,"L. Frank Baum")});
        ListList.Add(new List<Wizard>{new Wizard("Zatanna Zatara","hawkman #4",1964,"Julius Schwartz")});
        ListList.Add(new List<Wizard>{new Wizard("Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien"), new Wizard("Gandalf","The Fellowship of the Ring",1954,"J.R.R. Tolkien")});
        ListList.Add(new List<Wizard>{new Wizard("Lord Voldemort","Harry Potter and The Philosopher's Stone",1997,"J.K. Rowling"), new Wizard("Harry Potter","Harry Potter and The Philosopher's Stone",1997,"J.K. Rowling")});
        ListList.Add(new List<Wizard>{new Wizard("Darth Vader","Star Wars",1977,"George Lucas"), new Wizard("Darth Sidious","Star Wars",1980,"George Lucas")});
        ListList.Add(new List<Wizard>{new Wizard("Merlin","Prophetiae Merlini",1200,"Geoffrey of Monmouth")});
        
        //Act
        var wizbyrowl = Queries.ListOfWizByCreatorExtension(wizards);
        
        //Assert
        wizbyrowl.Should().BeEquivalentTo(ListList);
        
    }
}
