namespace Drunkometer.Models
{
  using System;

  class CivilGuardTestAlcoholObserver : ITestAlcoholObserver
  {

    private const int MinFineRate = 2;

    public void OnTestAlcohol(decimal rate)
    {      
      
      if (rate > MinFineRate)
        Display(rate);
    }
    public void Display(decimal rate)
    {
      Console.WriteLine("Borracho detectado con {0}% de alcohol ", rate);
    }

    
    public string DetenerAlConductor()
    {
      return "------------------------------------------------\n\nPor favor sople:";
    }
  }
}

