using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.view
{
    public class RegisterView : View
    {
        public override void Render()
        {
            System.Console.WriteLine("Enter information about new member!");
        }
    }
}
