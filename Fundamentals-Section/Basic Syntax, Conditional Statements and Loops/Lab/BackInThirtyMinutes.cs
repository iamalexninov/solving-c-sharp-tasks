namespace Fundamentals_Section.Basic_Syntax__Conditional_Statements_and_Loops.Lab
{
    public class BackInThirtyMinutes
    {
        private int _hours;
        private int _minutes;

        public BackInThirtyMinutes(int hours, int minutes)
        {
            _hours = hours;
            _minutes = minutes;
        }

        private string FormatTime(int hours, int minutes) =>
            minutes < 10 ? $"{hours}:0{minutes}" : $"{hours}:{minutes}";

        private string CalculateTimeAfterThirtyMinutes(int hours, int minutes)
        {
            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
                hours = 0;

            return FormatTime(hours, minutes);
        }

        public void PrintExamResult() => Console.WriteLine(CalculateTimeAfterThirtyMinutes(_hours, _minutes));
    }
}
