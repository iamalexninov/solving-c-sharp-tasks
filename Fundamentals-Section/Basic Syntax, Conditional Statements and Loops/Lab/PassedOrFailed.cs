namespace Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab
{
    public class PassedOrFailed
    {
        private double _number;
        public PassedOrFailed(double number) => _number = number;
        private string IsExamPassedOrFailed(double number) => number >= 3.00 ? "Passed!" : "Failed!";
        public void PrintExamResult() => Console.WriteLine(IsExamPassedOrFailed(_number));
    }
}
