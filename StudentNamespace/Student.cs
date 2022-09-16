namespace StudentNamespace;
public class Student{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public  Status status{ get; }
    
    public DateTime StartDate{ get; set; }
    public DateTime EndDate{ get; set; }
    public DateTime GraduationDate{ get; set; }

    public Student(int id, string gName, string sName, DateTime startDate, DateTime endDate, DateTime gradDate){
        Id = id;
        GivenName = gName;
        Surname = sName;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = gradDate;
        status = calcStatus();
    }


    public Status calcStatus(){
    int calcStart = DateTime.Compare(StartDate, DateTime.Now);
    int calcActive = DateTime.Compare(EndDate, DateTime.Now);
    int calcGrad = DateTime.Compare(EndDate, GraduationDate);
    if (calcStart == 0) return Status.New;
    else if (calcActive > 0 && DateTime.Now > StartDate) return Status.Active;
    else if (calcGrad < 0) return Status.Dropout;
    else if (calcGrad == 0) return Status.Graduated;
    else return Status.Dropout;

}

}

public enum Status{
    New,
    Active,
    Dropout,
    Graduated
}

