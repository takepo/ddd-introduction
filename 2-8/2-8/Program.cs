using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var greet = "こんにちは";

            // こんなメソッド存在しない
            greet.ChangeTo("Hello"); 
            Console.WriteLine(greet);
        }
    }
}
