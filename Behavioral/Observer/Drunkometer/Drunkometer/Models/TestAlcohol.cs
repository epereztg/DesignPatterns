namespace Drunkometer.Models
{
    using System;
    using System.Collections.Generic;


    class TestAlcohol : IDrunkObservable
    {
        private readonly List<ITestAlcoholObserver> _observers = new List<ITestAlcoholObserver>();
     
        public void Sople()
        {
           string inputString = Console.ReadLine();


            if (!String.IsNullOrEmpty(inputString))
            {
                try
                {
                    // Do test and notify observers
                    NotifyTestAlcohol(decimal.Parse(inputString));
                }
                catch (FormatException ex)
                {
                    Console.Write("Por favor sople de nuevo. " + ex.Message + "\n\n");
                }
            }
        }

        public void Attach(ITestAlcoholObserver testAlcoholObserver)
        {
            _observers.Add(testAlcoholObserver);
        }

        public void Detach(ITestAlcoholObserver testAlcoholObserver)
        {
            _observers.Remove(testAlcoholObserver);
        }

        public void NotifyTestAlcohol(decimal rate)
        {
            _observers.ForEach(x => x.OnTestAlcohol(rate));
        }
    }
}
