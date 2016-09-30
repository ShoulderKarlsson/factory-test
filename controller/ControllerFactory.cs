using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.controller
{
    public class ControllerFactory
    {
        private view.View _desiredView;
        public ControllerFactory (view.View v)
        {
            _desiredView = v;
        }

        public controller.Controller GenerateController() 
        {
            if (_desiredView is view.RegisterView)
            {
                return new controller.RegisterController(_desiredView);
            }

            return new controller.RegisterController(_desiredView);
        }
    }
}