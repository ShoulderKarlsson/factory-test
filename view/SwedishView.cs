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
    public class SwedishView : IView
    {
        public void Present(model.Person p)
        {
            System.Console.WriteLine($"Namn: {p.Name} - Ålder: {p.Age}");
        }
    }
}
