using System;
using System.Threading.Tasks;

namespace FormFactory.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).RunSynchronously();
        }

        public static async Task MainAsync(string[] args)
        {
            var someObject = new { SomeProperty = "SomeValue" };
            var properties = FF.PropertiesFor(someObject);

            var s = properties.Render();
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
