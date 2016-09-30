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
    enum Views 
    {
        Register = 0
    }
    public class ViewFactory 
    {
        public View GenerateView(int choice) 
        {
            string viewChoice = Views.GetName(typeof(Views), choice);

            if (viewChoice == Views.Register.ToString())
            {
                return new RegisterView();
            }

            return new view.RegisterView();
        }
    }
}