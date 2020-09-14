using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infistar_Download
{
    class ConsoleHelper
    {
        public void exit()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        public void printLineLoop(List<string> data)
        {
            Console.Clear();
            foreach(string pid in data)
            {
                Console.WriteLine(pid);
            }
        }
    }
}
