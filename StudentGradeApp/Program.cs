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
    
    while (!double.TryParse(input, out marks[i]) || marks[i] < 0 || marks[i] > 100)
    {
        Console.Write($"Invalid input. Please enter valid marks (0-100) for {subjects[i]}: ");
        input = Console.ReadLine();
    }
    
    totalMarks += marks[i];
}

// Calculate percentage
double percentage = totalMarks / subjects.Length;

// Determine grade
string grade;
if (percentage >= 80 && percentage <= 99)
{
    grade = "A";
}
else if (percentage >= 50 && percentage <= 79)
{
    grade = "B";
}
else if (percentage >= 30 && percentage <= 49)
{
    grade = "C";
}
else if (percentage < 30)
{
    grade = "F";
}
else // percentage is 100 or above
{
    grade = "A";
}

// Display results
Console.WriteLine();
Console.WriteLine("=== Results ===");
Console.WriteLine($"Total Marks: {totalMarks}/400");
Console.WriteLine($"Percentage: {percentage:F2}%");
Console.WriteLine($"Grade: {grade}");
