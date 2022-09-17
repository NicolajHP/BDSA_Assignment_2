namespace StudentLib.Tests;

public class StudentTest
{
    [Fact]
    public void Test_status_given_dates_returns_active()
    {
        //Arrange
        var student1 = new Student{Id = 42};
        student1.StartDate = new DateTime(2020, 8, 1);
        student1.EndDate = new DateTime(2023, 6, 1);
        student1.GraduationDate = new DateTime(2023, 6, 1);

        //Act
        var result = student1.Status;

        //Assert
        result.Should().Be(Status.Active);
        
    }

    [Fact]
    public void Test_status_given_dates_returns_new()
    {
        //Arrange
        var student1 = new Student{Id = 42};
        student1.StartDate = new DateTime(2022, 8, 1);
        student1.EndDate = new DateTime(2025, 6, 1);
        student1.GraduationDate = new DateTime(2025, 6, 1);

        //Act
        var result = student1.Status;

        //Assert
        result.Should().Be(Status.New);
        
    }

    [Fact]
    public void Test_status_given_dates_returns_dropout()
    {
        //Arrange
        var student1 = new Student{Id = 42};
        student1.StartDate = new DateTime(2020, 8, 1);
        student1.EndDate = new DateTime(2022, 6, 1);
        student1.GraduationDate = new DateTime(2023, 6, 1);

        //Act
        var result = student1.Status;

        //Assert
        result.Should().Be(Status.Dropout);
        
    }

        [Fact]
    public void Test_status_given_dates_returns_graduated()
    {
        //Arrange
        var student1 = new Student{Id = 42};
        student1.StartDate = new DateTime(2019, 8, 1);
        student1.EndDate = new DateTime(2022, 6, 1);
        student1.GraduationDate = new DateTime(2022, 6, 1);

        //Act
        var result = student1.Status;

        //Assert
        result.Should().Be(Status.Graduated);
        
    }
}