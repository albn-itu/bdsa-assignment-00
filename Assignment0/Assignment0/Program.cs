using System;

namespace Assignment0
{
    public class Program
    {
        /*
         * Due to console input, we no longer test this class
         */
        public static void Main(string[] args)
        {
            IConsole console = new ConsoleWrapper();
            new LeapYearProgram(console).Main();
        }
    }

    /**
     * Testable program class
     */
    public class LeapYearProgram
    {
        private IConsole console;

        public LeapYearProgram(IConsole console)
        {
            this.console = console;
        }

        /**
         * Replacement main
         */
        public void Main()
        {
            PrintInputMessage();
            bool isLeapYear;

            try
            {
                int year = GetInputYear();
                isLeapYear = LeapYearChecker.IsLeapYear(year);
            }
            catch (FormatException e)
            {
                console.WriteLine("That year is not a number");
                return;
            }
            catch (InvalidYearException e)
            {
                console.WriteLine(e.Message);
                return;
            }

            PrintOutputMessage(isLeapYear);
        }
        
        public void PrintInputMessage()
        {
            console.WriteLine("Please input a year to check:");
        }

        public void PrintOutputMessage(bool isLeapYear)
        {
            if (isLeapYear)
            {
                console.WriteLine("yay");
            }
            else
            {
                console.WriteLine("nay");
            }
        }
        
        public int GetInputYear()
        {
            string input = console.ReadLine().Trim();
            int parsed = Int32.Parse(input);

            return parsed;
        }
    }

}
