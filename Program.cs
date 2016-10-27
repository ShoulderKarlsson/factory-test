using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            model.Person p = new model.Person("foo", 10);            
            view.IView v = new view.EnglishView();
            controller.Controller ctrl = new controller.Controller(v, p);
            
            ctrl.PresentPerson();
        }
    }
}
