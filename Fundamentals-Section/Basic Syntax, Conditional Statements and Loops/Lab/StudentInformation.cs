namespace Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab
{
    public class StudentInformation
    {
        private string _studentName;
        private int _studentAge;
        private double _studentAverageGrade;

        public StudentInformation(string name, int age, double grade)
        {
            _studentName = name;
            _studentAge = age;
            _studentAverageGrade = grade;
        }

        private string FormattingString(string name, int age, double grade) => $"Name: {name}, Age: {age}, Grade: {grade}";

        public void PrintTaskResult()
        {
            string outputMessage = this.FormattingString(_studentName, _studentAge, _studentAverageGrade);
            Console.WriteLine(outputMessage);
        }
    }
}