namespace Drunkometer.Models
{
  /// <summary>
  /// 'Observer' interface for Observer pattern
  /// </summary>
  interface ITestAlcoholObserver
    {
      void OnTestAlcohol(decimal rate);
    }
}
