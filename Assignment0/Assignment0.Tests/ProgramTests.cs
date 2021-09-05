using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Assignment0.Tests
{
    public class ProgramTests : IDisposable
    {
        private ConsoleWrapper _console;
        private LeapYearProgram _program;

        public ProgramTests()
        {
            _console = new ConsoleWrapper();
            _program = new LeapYearProgram(_console);
        }

        public void Dispose()
        {
            _console = null;
            _program = null;
        }

        public string GetConsoleOutput(Action func)
        {
            var writer = new StringWriter();
            _console.SetOut(writer);

            func();
            
            var output = writer.GetStringBuilder().ToString().Trim();
            return output;
        }
        
        [Fact]
        public void PrintInputMessage_prints_message()
        { 
            // Act
            var output = GetConsoleOutput(() => _program.PrintInputMessage());
            
            // Assert
            Assert.Equal("Please input a year to check:", output);
        }
       
        [Fact]
        public void PrintOutputMessage_prints_message()
        { 
            Assert.Equal("yay", GetConsoleOutput(() => _program.PrintOutputMessage(true)));
            Assert.Equal("nay", GetConsoleOutput(() => _program.PrintOutputMessage(false)));
        }

        [Fact]
        public void GetInputYear_parses_int()
        {
            // Arrange
            _console.Message = "1982";
            
            // Act and assert
            Assert.Equal(1982, _program.GetInputYear());
            
            // Arrange
            _console.Message = "2020";
            
            // Act and assert
            Assert.Equal(2020, _program.GetInputYear());
        }

        [Fact]
        public void GetInputYear_invalid_int_throws_error()
        {
            // Arrange
            _console.Message = "Not an int";
            
            // Act and assert
            Assert.Throws<FormatException>(() => _program.GetInputYear());
        }

        [Fact]
        public void Main_prints_input_and_output()
        {
            // Arrange
            _console.Message = "2020";
            
            // Act
            var output = GetConsoleOutput(() => _program.Main());
            
            // Assert
            // The year is not actually written, so we only test the input message and output message
            Assert.Equal("Please input a year to check:\nyay", output);
        }
        
        [Fact]
        public void Main_prints_input_and_error()
        {
            // Arrange
            _console.Message = "1581";
            // Act and assert
            Assert.Equal("Please input a year to check:\nYear too low", GetConsoleOutput(() => _program.Main()));

            // Arrange
            _console.Message = "Not an int";
            // Act and assert
            Assert.Equal("Please input a year to check:\nThat year is not a number", GetConsoleOutput(() => _program.Main()));
         }
    }
    
    class ConsoleWrapper : IConsole
    {
        public string Message { get; set; }

        public ConsoleWrapper()
        {
            Message = "";
        }
        
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void SetOut(TextWriter writer)
        {
            Console.SetOut(writer);
        }

        public string ReadLine()
        {
            return Message;
        }
    }
}