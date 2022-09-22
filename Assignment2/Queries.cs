namespace Assignment2;

public class Queries
{

    //Queries that returns wizards made by J.K.Rowling
    public static List<String> WizardsByRowling(WizardCollection wizCol){
        var wizByRowl = from w in wizCol
                       where w.Creator.Contains("J.K. Rowling")
                       select w.Name;
        return wizByRowl.ToList();
    }

    public static List<String> WizardsByRowlingExtenstion(WizardCollection wizCol){
        var wizByRowl = wizCol.Where(w => w.Creator == "J.K. Rowling")
                        .Select(w => w.Name).ToList();
        return wizByRowl;
    }

    //Queries that returns the sith with the earliest appearance.

    public static List<String> firstSithAppearance(WizardCollection wizCol){
        var FirstSith = from w in wizCol
                        where w.Name.Contains("Darth")
                        let y = w.Year
                        orderby y ascending
                        select w.Name;
        return FirstSith.Take(1).ToList();
    }

    public static List<String> firstSithAppearanceExtension(WizardCollection wizCol){
        var FirstSith = wizCol.Where(w => w.Name.Contains("Darth"))
                        .OrderBy(w => w.Year)
                        .Select(w => w.Name);
        return FirstSith.Take(1).ToList();
    }

    //Queries that return all wizards in the "Harry Potter" medium
    public static IEnumerable<(String Name, int? Year)> AllWizardsInHP(WizardCollection wizCol){
        var allWiz = from w in wizCol
                     where w.Medium.Contains("Harry Potter")
                     select (w.Name, w.Year);
        return allWiz;
    }

        public static IEnumerable<(String Name, int? Year)> AllWizardsInHPExtension(WizardCollection wizCol){
        var allWiz = wizCol.Where(w => w.Medium.Contains("Harry Potter"))
                     .Select(w => (w.Name, w.Year));
        return allWiz;
    }


    //Querues that return the full list of wizards, ordered in reverse by creator, then by name.
    public static List<List<Wizard>> ListOfWizByCreator(WizardCollection wizCol){
        var listWiz = from w in wizCol
                      let c = w.Creator
                      let n = w.Name
                      orderby c descending, n descending
                      group w by c into newGrp
                      select newGrp.ToList();
        return listWiz.ToList();

    }

    public static IEnumerable<System.Linq.IGrouping<String, Wizard>> ListOfWizByCreatorExtension(WizardCollection wizCol){
        var listWiz = wizCol.OrderByDescending(w => w.Creator)
                      .ThenByDescending(w => w.Name)
                      .GroupBy(w => w.Creator);
        return listWiz;

    }
}
