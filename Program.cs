using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            controller.MainController mC = new controller.MainController();
            mC.init();
        }
    }
}
