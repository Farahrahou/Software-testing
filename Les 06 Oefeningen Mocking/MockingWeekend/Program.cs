using System;

namespace OefeningMockingWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter(new DateGetter());
            Console.WriteLine(greeter.GetMessage());

            Console.ReadKey();
        }
    }
}
