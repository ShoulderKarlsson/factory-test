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
    public class MainController
    {
        public void init()
        {
            view.MainView mV = new view.MainView();
            string choice = mV.GetChoice();
            view.View desiredView = GetViewFromFactory(choice);
            controller.Controller desiredController = GetControllerFromFactory(desiredView);
            desiredController.init();

        }

        private view.View GetViewFromFactory(string choice)
        {
            view.ViewFactory vF = new view.ViewFactory();
            return vF.GenerateView(int.Parse(choice));
        }

        private controller.Controller GetControllerFromFactory(view.View v)
        {
            controller.ControllerFactory cF = new controller.ControllerFactory(v);
            return cF.GenerateController();
        }
    }
}