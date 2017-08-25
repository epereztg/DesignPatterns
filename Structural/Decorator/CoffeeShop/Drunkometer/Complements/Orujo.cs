namespace CoffeeShop.Complements
{
    public class Orujo : IDrink
    {
        private readonly IDrink _drink;
        private readonly decimal _precioOrujo = 1;

        public decimal Precio()
        {
            return _drink.Precio() + _precioOrujo;
        }

        public Orujo(IDrink drink)
        {
            this._drink = drink;
        }

    }
}