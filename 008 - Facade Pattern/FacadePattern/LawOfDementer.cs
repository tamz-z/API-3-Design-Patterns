using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Principle of Least Knowledge: roep alleen methodes aan van deze 4 soorten "vrienden"
    internal class LawOfDementer
    {
        public LawOfDementer() { }

        public void doSomething() { }

        // 1. Het object zelf
        public void MethodCallOfObject()
        {
            doSomething();
        }

        // 2. Een object dat als parameter is meegegeven
        public void MethodCallOfParameter(LawOfDementer parameterClass)
        {
            parameterClass.doSomething();
        }

        // 3. Een object dat de methode zelf aanmaakt
        public void MethodCallOfCreation()
        {
            LawOfDementer creationClass = new LawOfDementer();
            creationClass.doSomething();
        }
        private LawOfDementer? uninstantiatedComponent;
        public void MethodCallOfInstantiation()
        {
            uninstantiatedComponent = new LawOfDementer();
            uninstantiatedComponent.doSomething();
        }

        // 4. Een component van het object (HAS-A)
        // Nullable (?): via de lege constructor wordt dit component niet gezet
        private LawOfDementer? ComposedComponent;
        public LawOfDementer(LawOfDementer lawOfDementer)
        {
            ComposedComponent = lawOfDementer;
        }
        public void MethodCallOfComponent()
        {
            ComposedComponent?.doSomething();
        }
    }
}
