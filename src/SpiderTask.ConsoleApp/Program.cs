using System;

namespace SpiderTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "";
            foreach(var c in string.Join('-', args).ToCharArray())
            {
                cs += $" [{c}]";
            }
            Console.WriteLine("Hello World! args:{0} {1}", cs, cs.Length);
            //Console.WriteLine("Hello World! args:{0} {1}", string.Join(',', args).ToCharArray().,args.Length);
        }


         




    }
}
