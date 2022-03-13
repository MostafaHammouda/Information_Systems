using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;

namespace HiServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(trial5.Service1)))
            {
                host.Open();
                {
                    string csvFile = "Name_Date_DB.csv";
                    string searchString = Console.ReadLine();
                    char csvSeparator = ',';

                    foreach (string line in File.ReadLines(csvFile))
                        foreach (string value in line.Replace("\"", "").Split('\r', '\n', csvSeparator))

                           if (value.Trim() == searchString.Trim())
                            {
                                Console.WriteLine("Name Found");
                                goto AfterLoop;

                            }
                    Console.WriteLine("Name Not Found");
                AfterLoop:
                            Console.WriteLine("program works");

                    

                }

            }
        }
    }
}
