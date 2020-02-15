using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName = new FullName("masanobu", "naruse");
            fullName.chengeLastName("sato");
        }
    }
}
