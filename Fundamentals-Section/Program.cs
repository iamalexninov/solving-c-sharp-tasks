using Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1 - StudentInformation
        StudentInformation[] studentInformationTasksTests = new StudentInformation[3]
        {
            new StudentInformation("John", 15, 5.40),
            new StudentInformation("Steve", 16, 2.50),
            new StudentInformation("Marry", 12, 6.00),
        };

        // Exercise 2 - Passed
        Passed[] passedTasksTests = new Passed[2]
        {
            new Passed(5.32),
            new Passed(2.34),
        };

        // Exercise 3 - PassedOrFailed
        PassedOrFailed[] passedOrFailedTasksTests = new PassedOrFailed[2]
        {
            new PassedOrFailed(5.32),
            new PassedOrFailed(2.36),
        };

        // Exercise 4 - BackInThirtyMinutes
        BackInThirtyMinutes[] backInThirtyMinTasksTests = new BackInThirtyMinutes[5]
        {
            new BackInThirtyMinutes(1,46),
            new BackInThirtyMinutes(0,01),
            new BackInThirtyMinutes(23,59),
            new BackInThirtyMinutes(11,08),
            new BackInThirtyMinutes(11,32)
        };

        // TODO: Executing Tasks
        foreach (var item in backInThirtyMinTasksTests)
        {
            item.PrintExamResult();
        }
    }
}