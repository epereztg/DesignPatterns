namespace CoffeeShop.Complements
{
    public class Nata : IDrink
    {
        private readonly IDrink _drink;
        private readonly decimal _precioNata = 0.5m;

        public decimal Precio()
        {
            return _drink.Precio() + _precioNata;
        }
        public Nata(IDrink drink)
        {
            this._drink = drink;
        }

    }
}