using System;
using System.Diagnostics;

namespace ParentProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"I am the parent program. (process-id: {Process.GetCurrentProcess().Id})");
            Console.WriteLine("----------  start of child program  ----------");
            ChildProgram.Program.Main(new[] { "first", "second", "third" });
            Console.WriteLine("----------  end of child program  ----------");
            Console.Beep();
            Console.WriteLine("completed");
            _ = Console.ReadLine();
        }
    }
}
