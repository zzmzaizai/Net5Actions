using System;
using System.Collections;

namespace SpiderTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "";
            foreach(var c in string.Join('-', args).ToCharArray())
            {
                cs += $" {c}";
            }
            Console.WriteLine("Hello World! args:{0} {1}", cs, cs.Length);
            //Console.WriteLine("Hello World! args:{0} {1}", string.Join(',', args).ToCharArray().,args.Length);



 

            Console.WriteLine("进程的环境变量");

            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables())
            {
                if(item.Key.ToString().StartsWith("Config_", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("{0}:{1}", item.Key, item.Value);
                }
               
            }
             

        }







    }
}
