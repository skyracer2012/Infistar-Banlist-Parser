using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infistar_Download
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Infistar parser";
            InfiHelper ih = new InfiHelper();
            ConsoleHelper ch = new ConsoleHelper();
            ch.printLineLoop(ih.recieveData());
            ch.exit();
        }
    }
}
