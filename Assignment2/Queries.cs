namespace Assignment2;

public class Queries
{
    public static List<String> WizardsByRowling(WizardCollection wizCol){
        var wizByRowl = from w in wizCol
                       where w.Creator.Contains("J.K. Rowling")
                       select w.Name;
        return wizByRowl.ToList();
    }
}
