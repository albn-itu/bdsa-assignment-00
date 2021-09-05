using System;
using System.IO;

namespace Assignment0
{
    /**
     * Console abstraction for testing purposes
     */
    public interface IConsole
    {
        void WriteLine(string value);
        string ReadLine();
        void SetOut(TextWriter writer);
    }
    
    public class ConsoleWrapper : IConsole
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void SetOut(TextWriter writer)
        {
            Console.SetOut(writer);
        }
    }
}