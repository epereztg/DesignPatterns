namespace CoffeeShop.Complements
{
    public class Soja : IDrink
    {
        private readonly IDrink _drink;
        private readonly decimal _precioSoja = 0.20m;

        public decimal Precio()
        {
            return _drink.Precio() + _precioSoja;
        }

        public Soja(IDrink drink)
        {
            this._drink = drink;
        }

    }



}

