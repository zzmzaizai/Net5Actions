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



            //依次打印三种级别的环境变量

            Console.WriteLine("计算机的环境变量");
            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            Console.WriteLine();


            Console.WriteLine("用户的环境变量");

            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            Console.WriteLine();

            Console.WriteLine("进程的环境变量");

            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }

            //一次性打印所有三种环境变量（直接利用枚举器的遍历

            var targets = Enum.GetNames(typeof(EnvironmentVariableTarget));
            foreach (var target in targets)
            {
                Console.WriteLine("{0}级别的环境变量", target);
                EnvironmentVariableTarget t = (EnvironmentVariableTarget)Enum.Parse(typeof(EnvironmentVariableTarget), target);

                foreach (DictionaryEntry item in Environment.GetEnvironmentVariables(t))
                {
                    Console.WriteLine("{0}:{1}", item.Key, item.Value);
                }

            }

        }







    }
}
