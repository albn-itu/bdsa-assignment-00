using Xunit;

namespace Assignment0.Tests
{
    // TODO: Apart from the leap year tests, these are really bad. There are no edge cases, or error checking
    public class LeapYearCheckerTests
    {
        [Fact]
        public void IsLeapYear_every_leap_year_first_half_21st_century()
        {
            Assert.True(LeapYearChecker.IsLeapYear(2000));
            Assert.True(LeapYearChecker.IsLeapYear(2004));
            Assert.True(LeapYearChecker.IsLeapYear(2008));
            Assert.True(LeapYearChecker.IsLeapYear(2012));
            Assert.True(LeapYearChecker.IsLeapYear(2016));
            Assert.True(LeapYearChecker.IsLeapYear(2020));
            Assert.True(LeapYearChecker.IsLeapYear(2024));
            Assert.True(LeapYearChecker.IsLeapYear(2028));
            Assert.True(LeapYearChecker.IsLeapYear(2032));
            Assert.True(LeapYearChecker.IsLeapYear(2036));
            Assert.True(LeapYearChecker.IsLeapYear(2040));
            Assert.True(LeapYearChecker.IsLeapYear(2044));
            Assert.True(LeapYearChecker.IsLeapYear(2048)); 
        }

        [Fact]
        public void IsLeapYear_divisible_by_4()
        {
            Assert.True(LeapYearChecker.IsLeapYear(1996));
            Assert.True(LeapYearChecker.IsLeapYear(1992));
        }
        
        [Fact]
        public void IsLeapYear_not_divisible_by_4()
        { 
            Assert.False(LeapYearChecker.IsLeapYear(1994));
            Assert.False(LeapYearChecker.IsLeapYear(1995)); 
        }

        [Fact]
        public void IsLeapYear_divisible_by_100()
        {
            // Divisible by 4 and 100, not 400
            Assert.False(LeapYearChecker.IsLeapYear(1700));
            // Divisible by 4, 100 and 400
            Assert.True(LeapYearChecker.IsLeapYear(1600));
        }

        [Fact]
        public void IsLeapYear_not_divisible_100()
        {
            // Divisible by 4, not 100 and 400
            Assert.True(LeapYearChecker.IsLeapYear(1684));
            Assert.True(LeapYearChecker.IsLeapYear(1688));
            Assert.True(LeapYearChecker.IsLeapYear(1676));
        }

        [Fact]
        public void IsLeapYear_divisble_by_400()
        {
            // Divisible by 4, 100 and 400
            Assert.True(LeapYearChecker.IsLeapYear(1600));
            Assert.True(LeapYearChecker.IsLeapYear(2000));
        }

        [Fact]
        public void IsLeapYear_not_divisible_400()
        {
            // Divisible by 4 and 100 not 400
            Assert.False(LeapYearChecker.IsLeapYear(1700));
            Assert.False(LeapYearChecker.IsLeapYear(1800));  
            Assert.False(LeapYearChecker.IsLeapYear(1900));  
            Assert.False(LeapYearChecker.IsLeapYear(2100));  
            Assert.False(LeapYearChecker.IsLeapYear(2200));  
        }
        
        [Fact]
        public void DividesBy_divides()
        {
            Assert.True(LeapYearChecker.DividesBy(4, 8));
            Assert.True(LeapYearChecker.DividesBy(8, 8));
            Assert.True(LeapYearChecker.DividesBy(8, 440));
            Assert.True(LeapYearChecker.DividesBy(5, 440));
            Assert.True(LeapYearChecker.DividesBy(2, 11530));
        }

        [Fact]
        public void DividesBy_not_divides()
        {
            Assert.False(LeapYearChecker.DividesBy(3, 31));
            Assert.False(LeapYearChecker.DividesBy(14, 431));
            Assert.False(LeapYearChecker.DividesBy(15, 643));
            Assert.False(LeapYearChecker.DividesBy(463, 643));
            Assert.False(LeapYearChecker.DividesBy(51, 564));
            Assert.False(LeapYearChecker.DividesBy(543, 521));
            Assert.False(LeapYearChecker.DividesBy(643, 51));
        }

        [Fact]
        public void DividesBy4_divides()
        {
            Assert.True(LeapYearChecker.DividesBy4(4));
            Assert.True(LeapYearChecker.DividesBy4(8));
            Assert.True(LeapYearChecker.DividesBy4(16));
        }
        
        [Fact]
        public void DividesBy4_not_divides()
        {
            Assert.False(LeapYearChecker.DividesBy4(413));
            Assert.False(LeapYearChecker.DividesBy4(545));
            Assert.False(LeapYearChecker.DividesBy4(3211));
        }
        [Fact]
        public void DividesBy100_divides()
        {
            Assert.True(LeapYearChecker.DividesBy100(400));
            Assert.True(LeapYearChecker.DividesBy100(800));
            Assert.True(LeapYearChecker.DividesBy100(1600));
        }
        
        [Fact]
        public void DividesBy100_not_divides()
        {
            Assert.False(LeapYearChecker.DividesBy100(413));
            Assert.False(LeapYearChecker.DividesBy100(545));
            Assert.False(LeapYearChecker.DividesBy100(3211));
        }
        
        [Fact]
        public void DividesBy400_divides()
        {
            Assert.True(LeapYearChecker.DividesBy400(400));
            Assert.True(LeapYearChecker.DividesBy400(800));
            Assert.True(LeapYearChecker.DividesBy400(1600));
        }
        
        [Fact]
        public void DividesBy400_not_divides()
        {
            Assert.False(LeapYearChecker.DividesBy400(413));
            Assert.False(LeapYearChecker.DividesBy400(545));
            Assert.False(LeapYearChecker.DividesBy400(3211));
        }
    }
}