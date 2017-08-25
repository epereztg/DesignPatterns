namespace CoffeeShop.Complements
{
    public class Leche : IDrink
    {
        private readonly IDrink _drink;
        private readonly decimal _precioNata = 0.1m;

        public decimal Precio()
        {
            return _drink.Precio() + _precioNata;
        }
        public Leche(IDrink drink)
        {
            this._drink = drink;
        }

    }
}