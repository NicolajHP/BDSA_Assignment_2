namespace Assignment2;

public class Queries
{
    public static List<String> WizardsByRowling(WizardCollection wizCol){
        var wizByRowl = from w in wizCol
                       where w.Creator.Contains("J.K. Rowling")
                       select w.Name;
        return wizByRowl.ToList();
    }

    public static List<String> firstSithAppearance(WizardCollection wizCol){
        var FirstSith = from w in wizCol
                        where w.Name.Contains("Darth")
                        let y = w.Year
                        orderby y ascending
                        select w.Name;
        return FirstSith.Take(1).ToList();
    }

    public static IEnumerable<(String Name, int? Year)> AllWizardsInHP(WizardCollection wizCol){
        var allWiz = from w in wizCol
                     where w.Medium.Contains("Harry Potter")
                     select (w.Name, w.Year);
        return allWiz;
    }

    public static IEnumerable<System.Linq.IGrouping<String, Assignment2.Wizard>> ListOfWizByCreator(WizardCollection wizCol){
        var listWiz = from w in wizCol
                      let c = w.Creator
                      let n = w.Name
                      orderby c descending, n descending
                      group w by c into newGrp
                      select newGrp;
        return listWiz;

    }
}
