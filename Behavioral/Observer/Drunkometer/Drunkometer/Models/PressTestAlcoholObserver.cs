namespace Drunkometer.Models {
  using System;
  class PressTestAlcoholObserver : ITestAlcoholObserver {
    private const int MinFineRate = 7;
    public void OnTestAlcohol(decimal rate) {
        if (rate > MinFineRate) {
            Display(rate);
        }
    }
    public void Display(decimal rate) {
      Console.WriteLine("Súper borracho detectado {0}% llamar a mi amigo de la prensa", rate);
    }
    }
}

