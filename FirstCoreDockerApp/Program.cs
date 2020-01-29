using System;

namespace FirstCoreDockerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var max = args.Length != 0 ? int.Parse(args[0]) : -1;
            while (max == -1 || count < max)
            {
                count++;
                Console.WriteLine($"Counter : {count}");
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }
        }
    }
}
