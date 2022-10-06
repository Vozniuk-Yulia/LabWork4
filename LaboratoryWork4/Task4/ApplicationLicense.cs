using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Your mode - trial mode");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Your mode - free version");
        }
        public void AllowPro()
        {
            Console.WriteLine("Your mode - pro version");
        }
    }
}
