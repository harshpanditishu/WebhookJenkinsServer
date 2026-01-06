namespace StudentGradeApp.Tests;

public class GradeCalculatorTests
{
    #region DetermineGrade Tests
    
    [Fact]
    public void DetermineGrade_WithPercentage80_ReturnsA()
    {
        // Arrange
        double percentage = 80;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("A", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage90_ReturnsA()
    {
        // Arrange
        double percentage = 90;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("A", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage100_ReturnsA()
    {
        // Arrange
        double percentage = 100;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("A", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage50_ReturnsB()
    {
        // Arrange
        double percentage = 50;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("B", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage65_ReturnsB()
    {
        // Arrange
        double percentage = 65;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("B", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage79_ReturnsB()
    {
        // Arrange
        double percentage = 79;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("B", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage30_ReturnsC()
    {
        // Arrange
        double percentage = 30;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("C", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage40_ReturnsC()
    {
        // Arrange
        double percentage = 40;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("C", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage49_ReturnsC()
    {
        // Arrange
        double percentage = 49;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("C", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage0_ReturnsF()
    {
        // Arrange
        double percentage = 0;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("F", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage15_ReturnsF()
    {
        // Arrange
        double percentage = 15;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("F", grade);
    }
    
    [Fact]
    public void DetermineGrade_WithPercentage29_ReturnsF()
    {
        // Arrange
        double percentage = 29;
        
        // Act
        string grade = GradeCalculator.DetermineGrade(percentage);
        
        // Assert
        Assert.Equal("F", grade);
    }
    
    #endregion
    
    #region CalculatePercentage Tests
    
    [Fact]
    public void CalculatePercentage_WithValidInputs_ReturnsCorrectPercentage()
    {
        // Arrange
        double totalMarks = 355;
        int numberOfSubjects = 4;
        
        // Act
        double percentage = GradeCalculator.CalculatePercentage(totalMarks, numberOfSubjects);
        
        // Assert
        Assert.Equal(88.75, percentage);
    }
    
    [Fact]
    public void CalculatePercentage_WithZeroMarks_ReturnsZero()
    {
        // Arrange
        double totalMarks = 0;
        int numberOfSubjects = 4;
        
        // Act
        double percentage = GradeCalculator.CalculatePercentage(totalMarks, numberOfSubjects);
        
        // Assert
        Assert.Equal(0, percentage);
    }
    
    [Fact]
    public void CalculatePercentage_WithMaxMarks_Returns100()
    {
        // Arrange
        double totalMarks = 400;
        int numberOfSubjects = 4;
        
        // Act
        double percentage = GradeCalculator.CalculatePercentage(totalMarks, numberOfSubjects);
        
        // Assert
        Assert.Equal(100, percentage);
    }
    
    [Fact]
    public void CalculatePercentage_WithZeroSubjects_ThrowsArgumentException()
    {
        // Arrange
        double totalMarks = 100;
        int numberOfSubjects = 0;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => GradeCalculator.CalculatePercentage(totalMarks, numberOfSubjects));
    }
    
    [Fact]
    public void CalculatePercentage_WithNegativeSubjects_ThrowsArgumentException()
    {
        // Arrange
        double totalMarks = 100;
        int numberOfSubjects = -1;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => GradeCalculator.CalculatePercentage(totalMarks, numberOfSubjects));
    }
    
    #endregion
    
    #region ValidateMarks Tests
    
    [Fact]
    public void ValidateMarks_WithValidMarks_ReturnsTrue()
    {
        // Arrange & Act & Assert
        Assert.True(GradeCalculator.ValidateMarks(0));
        Assert.True(GradeCalculator.ValidateMarks(50));
        Assert.True(GradeCalculator.ValidateMarks(100));
        Assert.True(GradeCalculator.ValidateMarks(75.5));
    }
    
    [Fact]
    public void ValidateMarks_WithNegativeMarks_ReturnsFalse()
    {
        // Arrange
        double marks = -1;
        
        // Act
        bool result = GradeCalculator.ValidateMarks(marks);
        
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void ValidateMarks_WithMarksAbove100_ReturnsFalse()
    {
        // Arrange
        double marks = 101;
        
        // Act
        bool result = GradeCalculator.ValidateMarks(marks);
        
        // Assert
        Assert.False(result);
    }
    
    #endregion
}
