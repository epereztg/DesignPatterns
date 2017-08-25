using Drunkometer.Models;

namespace Drunkometer
{
    using System;
    public class Drunkometer
    {
        public static void Main(string[] args)
        {
            var testAlcohol = new TestAlcohol();

            //Confgure & Attach observers
            var cGuard = new CivilGuardTestAlcoholObserver();
            var press = new PressTestAlcoholObserver();
            testAlcohol.Attach(cGuard);
            testAlcohol.Attach(press);

            while (true)
            {
                Console.WriteLine(cGuard.DetenerAlConductor());
                testAlcohol.Sople();
            }
        }
    }

}
