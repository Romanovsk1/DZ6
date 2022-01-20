using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DZ6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    Console.WriteLine($"{process.ProcessName}{process.Id}");
                }
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();


                try
                {
                    processes.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                    Console.WriteLine($"{name} deleted!");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Process {name} not found!");
                }

                Console.WriteLine("Хотите продолжить? Yes/No");
                string user = Console.ReadLine();

                if (user.ToUpper() == "No")
                {
                    run = false;
                }

                Console.ReadKey();



            }

        }

        
    }


   
}




