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

