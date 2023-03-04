using System;
using System.Diagnostics;
using System.Linq;

namespace ChildProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"I am the child program. (process-id: {Process.GetCurrentProcess().Id})");
            Console.WriteLine($"args: [{string.Join(", ", args.Select(arg => $"\"{arg.Replace(@"\", @"\\").Replace(@"""", @"\""")}\""))}]");
        }
    }
}
