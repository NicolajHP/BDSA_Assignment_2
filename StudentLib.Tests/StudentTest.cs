namespace StudentLib.Tests;

public class StudentTest
{
    [Fact]
    public void Test_status_given_dates_returns_active()
    {
        //Arrange
        var student = new Student{Id = 42, StartDate = new DateTime(2020, 8, 1), EndDate = new DateTime(2023, 6, 1), GraduationDate = new DateTime(2023, 6, 1)};

        //Act
        var result = student.Status;

        //Assert
        result.Should().Be(Status.Active);
        
    }

    [Fact]
    public void Test_status_given_dates_returns_new()
    {
        //Arrange
        var student = new Student{Id = 42, StartDate = new DateTime(2022, 8, 1), EndDate = new DateTime(2025, 6, 1), GraduationDate = new DateTime(2025, 6, 1)};

        //Act
        var result = student.Status;

        //Assert
        result.Should().Be(Status.New);
        
    }

    [Fact]
    public void Test_status_given_dates_returns_dropout()
    {
        //Arrange
        var student = new Student{Id = 42, StartDate = new DateTime(2020, 8, 1), EndDate = new DateTime(2022, 6, 1), GraduationDate = new DateTime(2023, 6, 1)};

        //Act
        var result = student.Status;

        //Assert
        result.Should().Be(Status.Dropout);
        
    }

    [Fact]
    public void Test_status_given_dates_returns_graduated()
    {
        //Arrange
        var student = new Student{Id = 42, StartDate = new DateTime(2019, 8, 1), EndDate = new DateTime(2022, 6, 1), GraduationDate = new DateTime(2022, 6, 1)};

        //Act
        var result = student.Status;

        //Assert
        result.Should().Be(Status.Graduated);
        
    }

    [Fact]
    public void Test_tostring_method()
    {
        //Arrange
        var student = new Student{Id = 42, GivenName = "John", Surname = "Doe", 
            StartDate = new DateTime(2019, 8, 1), EndDate = new DateTime(2022, 6, 1),GraduationDate = new DateTime(2022, 6, 1)};

        //Act
        var result = student.ToString();

        //Assert
        result.Should().Be("Student name: John Doe \n Status: Graduated");
        
    }

    [Fact]
    public void records_built_in_comparer_true()
    {
        //Arrange
        var student1 = new ImmutableStudent(42, "John", "Doe", new DateTime(2019, 8, 1), new DateTime(2022, 6, 1), new DateTime(2022, 6, 1));
        var student2 = new ImmutableStudent(42, "John", "Doe", new DateTime(2019, 8, 1), new DateTime(2022, 6, 1), new DateTime(2022, 6, 1));

        //Act
        var result = student1.Equals(student2);

        //Assert
        result.Should().Be(true);
        
    }

       [Fact]
    public void records_built_in_comparer_false()
    {
        //Arrange
        var student1 = new ImmutableStudent(24, "John", "Doe", new DateTime(2019, 8, 1), new DateTime(2022, 6, 1), new DateTime(2022, 6, 1));
        var student2 = new ImmutableStudent(42, "John", "Doe", new DateTime(2019, 8, 1), new DateTime(2022, 6, 1), new DateTime(2022, 6, 1));

        //Act
        var result = student1.Equals(student2);

        //Assert
        result.Should().Be(false);
        
    }

    [Fact]
    public void record_to_string_properties()
    {
        //Arrange
        var student = new ImmutableStudent(42, "John", "Doe", new DateTime(2019, 8, 1), new DateTime(2022, 6, 1), new DateTime(2022, 6, 1));

        //Act
        var result = student.ToString();

        //Assert
        result.Should().Be("ImmutableStudent { Id = 42, GivenName = John, Surname = Doe, StartDate = 8/1/2019 12:00:00 AM, EndDate = 6/1/2022 12:00:00 AM, GraduationDate = 6/1/2022 12:00:00 AM, Status = Graduated }");
    }
}