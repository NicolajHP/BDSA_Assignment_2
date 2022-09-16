namespace StudentTests;

public class StudentTest
{
    [Fact]
    public void Test_status_given_dates_active_returns_true()
    {
        //arr
        var student1 = new Student{42};
        student1.StartDate.set(2020);
        student1.EndDate.set(2023);
        student1.GraduationDate.set(2023);

        //act
        
        //asser
        student1.status.should.be(Active);
        

        
    }
}