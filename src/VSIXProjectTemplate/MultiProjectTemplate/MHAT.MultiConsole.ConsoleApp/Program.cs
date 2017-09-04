using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHAT.ConsoleWithOption.Process;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new EchoProcess();
            process.StartProcess(args);
        }
    }
}
