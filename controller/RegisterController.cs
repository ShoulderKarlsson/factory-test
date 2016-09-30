using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting.controller
{
    public class RegisterController : Controller
    {

        public RegisterController (view.View v) : base(v) { }

        public override void init()
        {
            _desiredView.Render();
            model.PersonalNumber SSN = GetSSN();
            System.Console.WriteLine(SSN._personalNumber);
        }

        private model.PersonalNumber GetSSN()
        {
            return _desiredView.GetSSN();
        }
    }
}