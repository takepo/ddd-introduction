using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var fullName = "naruse masanobu";
            var fullName = "john smith";
            var tokens = fullName.Split(' ');
            var lastname = tokens[0];
            Console.WriteLine(lastname);
        }
    }
}
