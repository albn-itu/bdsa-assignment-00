
// TODO: This is so over engineered it's not even funny

using System;

namespace Assignment0
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year <= 1582)
            {
                throw new InvalidYearException("Year too low");
            }
            
            if (!DividesBy4(year))
            {
                return false;
            }

            if (!DividesBy100(year))
            {
                return true;
            }

            if (!DividesBy400(year))
            {
                return false;
            }

            return true;
        }

        public static bool DividesBy(int divider, int number)
        {
            return number % divider == 0;
        }

        public static bool DividesBy4(int number)
        {
            return DividesBy(4, number);
        }

        public static bool DividesBy100(int number)
        {
            return DividesBy(100, number);
        }
        
        public static bool DividesBy400(int number)
        {
            return DividesBy(400, number);
        }
    }
    
    
    public class InvalidYearException : Exception
    {
        public InvalidYearException()
        {
        }

        public InvalidYearException(string message) : base(message)
        {
        }
    }
}