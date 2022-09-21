namespace StudentLib;
public class Student{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status Status{ get {return calcStatus(StartDate, EndDate, GraduationDate);} }
    public DateTime StartDate{ get; set; }
    public DateTime EndDate{ get; set; }
    public DateTime GraduationDate{ get; set; }

    public static Status calcStatus(DateTime Start, DateTime End, DateTime Graduation){
        //Check if EndDate is passed and if true check if EndDate and GraduationDate matches
        if (DateTime.Compare(DateTime.Now, End) > 0) return DateTime.Compare(End, Graduation) == 0 ? Status.Graduated : Status.Dropout;
        //Else see if student is new or just active
        else return DateTime.Compare(Start.AddYears(1), DateTime.Now) > 0 ? Status.New : Status.Active;
    }

    public override string ToString() => $"Student name: {GivenName} {Surname} \n Status: {Status}";

}

public enum Status{
    New,
    Active,
    Dropout,
    Graduated
}

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate) {   
    public Status Status{ get {return Student.calcStatus(StartDate, EndDate, GraduationDate);} }

}

