using Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        StudentInformation[] studentInformationTasksTests = new StudentInformation[3]
        {
            new StudentInformation("John", 15, 5.40),
            new StudentInformation("Steve", 16, 2.50),
            new StudentInformation("Marry", 12, 6.00),
        };

        // Exercise 2
        Passed[] passedTasksTests = new Passed[2]
        {
            new Passed(5.32),
            new Passed(2.34),
        };

        // TODO: Executing Tasks
        foreach (var item in passedTasksTests)
        {
            item.PrintExamResult();
        }
    }
}