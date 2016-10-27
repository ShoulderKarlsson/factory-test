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
    public class Controller
    {
        private view.IView _view;
        private model.Person _person;

        public Controller (view.IView v, model.Person p)
        {
          this._view = v;
          this._person = p;
        }

        public void PresentPerson()
        {
            _view.Present(_person);
        }
    }
}
