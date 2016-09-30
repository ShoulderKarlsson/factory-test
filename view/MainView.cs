using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting.view
{
    public class MainView
    {
        public string GetChoice()
        {
                Console.WriteLine("Choose what todo: ");
                Console.WriteLine("Press '0' to register member");
                return Console.ReadLine();
        }
    }
}