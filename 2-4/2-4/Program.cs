using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName1 = new FullName("naruse","masanobu");
            Console.WriteLine(fullName1.LastName);

            var fullName2 = new FullName("john", "smith");
            Console.WriteLine(fullName2.LastName);
        }
    }
}
