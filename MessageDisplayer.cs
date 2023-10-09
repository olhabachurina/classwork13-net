using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork13_net
{
    public delegate void DisplayMessageDelegate(string message);
    public class MessageDisplayer
    {
        public void DisplayUpperCase(string message)
        {
            Console.WriteLine($"Uppercase: {message.ToUpper()}");
        }

        public void DisplayLowerCase(string message)
        {
            Console.WriteLine($"lower case: {message.ToLower()}");
        }

        public void DisplayLength(string message)
        {
            Console.WriteLine($"Message length: {message.Length}");
        }
        public void DisplayRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Red color: {message}");
            Console.ResetColor();
        }
    }
}

