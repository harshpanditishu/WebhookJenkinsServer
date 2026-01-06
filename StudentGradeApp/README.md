# Student Grade Calculator

A simple console application that calculates student grades based on marks in 4 subjects.

## Subjects
- SubA
- SubB
- SubC
- SubD

## Grading System

The application calculates the percentage based on the average marks and assigns grades as follows:

- **Grade A**: 80% to 99%
- **Grade B**: 50% to 79%
- **Grade C**: 30% to 49%
- **Grade F**: Less than 30%

## How to Run

1. Navigate to the StudentGradeApp directory:
   ```bash
   cd StudentGradeApp
   ```

2. Build the application:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Enter marks for each subject when prompted (values between 0-100)

5. The application will display:
   - Total marks out of 400
   - Percentage
   - Grade

## Example

```
=== Student Grade Calculator ===

Enter marks for SubA: 85
Enter marks for SubB: 90
Enter marks for SubC: 88
Enter marks for SubD: 92

=== Results ===
Total Marks: 355/400
Percentage: 88.75%
Grade: A
```
