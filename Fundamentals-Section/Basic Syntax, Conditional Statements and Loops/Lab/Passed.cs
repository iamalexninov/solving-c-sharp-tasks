namespace Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab
{
    public class Passed
    {
        private double _number;

        public Passed(double number) => _number = number;

        private string CheckIsExamPassed(double grade) => grade >= 3.00 ? "Passed!" : "(no output)";

        public void PrintExamResult() => Console.WriteLine(this.CheckIsExamPassed(_number));
    }
}
