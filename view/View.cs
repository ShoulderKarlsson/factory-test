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
            model.PersonalNumber ssn = null;
            bool loop = true;
            do
            {
                System.Console.Write("Enter personal number: ");
                try
                {
                    ssn = new model.PersonalNumber(Console.ReadLine());
                    loop = false;
                }
                catch (Exception e)
                {
                    PresentErrorMessage(e.Message);
                }
            } while(loop);

            return ssn;
        }

        public void PresentErrorMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}

