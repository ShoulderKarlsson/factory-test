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
    public abstract class View
    {
        public abstract void Render();

        public model.PersonalNumber GetSSN()
        {
            System.Console.WriteLine("Enter personal number..");
            try
            {
                return new model.PersonalNumber(Console.ReadLine());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                GetSSN();
            }
            return null;
        }

        public virtual void SsnMessage()
        {
            System.Console.WriteLine("Busy ssn!");
        }
    }
}

