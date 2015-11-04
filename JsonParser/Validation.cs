using System;
using System.IO;
using System.Linq;

namespace JsonParser
{
    public static class Validation
    {
        public static bool ValidateArgs(string[] args)
        {
            if (args.Count() != 1)
            {
                Console.WriteLine("Please add file path only");
                Console.ReadLine();
                return false;
            }
            if (!new FileInfo(args[0]).Exists)
            {
                Console.WriteLine("File Does Not Exist");
                Console.ReadLine();
                return false;
            }
            return true;
        }
    }
}