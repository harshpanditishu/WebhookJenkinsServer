using StudentGradeApp;

// Student Grade Calculator Console Application
Console.WriteLine("=== Student Grade Calculator ===");
Console.WriteLine();

// Define the subjects
string[] subjects = { "SubA", "SubB", "SubC", "SubD" };
double[] marks = new double[4];
double totalMarks = 0;

// Get marks for each subject
for (int i = 0; i < subjects.Length; i++)
{
    Console.Write($"Enter marks for {subjects[i]}: ");
    string? input = Console.ReadLine();
    
    while (!double.TryParse(input, out marks[i]) || !GradeCalculator.ValidateMarks(marks[i]))
    {
        Console.Write($"Invalid input. Please enter valid marks (0-100) for {subjects[i]}: ");
        input = Console.ReadLine();
    }
    
    totalMarks += marks[i];
}

// Calculate percentage
double percentage = GradeCalculator.CalculatePercentage(totalMarks, subjects.Length);

// Determine grade
string grade = GradeCalculator.DetermineGrade(percentage);

// Display results
Console.WriteLine();
Console.WriteLine("=== Results ===");
Console.WriteLine($"Total Marks: {totalMarks}/400");
Console.WriteLine($"Percentage: {percentage:F2}%");
Console.WriteLine($"Grade: {grade}");
