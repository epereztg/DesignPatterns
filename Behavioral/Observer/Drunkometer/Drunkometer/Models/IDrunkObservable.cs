namespace Drunkometer.Models
{
  /// <summary>
  /// 'Observable' interface for Observer pattern
  /// </summary>
  interface IDrunkObservable
  {
    void Attach(ITestAlcoholObserver testAlcoholObserver);
    void Detach(ITestAlcoholObserver testAlcoholObserver);

    void NotifyTestAlcohol(decimal rate);
  }

}
