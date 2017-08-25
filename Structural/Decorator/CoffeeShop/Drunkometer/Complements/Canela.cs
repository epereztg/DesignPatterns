namespace CoffeeShop.Complements
{
    public class Canela : IDrink
    {
        private readonly IDrink _drink;

        private readonly decimal _precioCanela = 0.15m;
        public decimal Precio()
        {
            return _drink.Precio() + _precioCanela;
        }
        public Canela(IDrink drink)
        {
            this._drink = drink;
        }

    }
}