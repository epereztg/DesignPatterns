using CoffeeShop.Models;

namespace CoffeeShop
{
    using System;
    public class Drunkometer
    {
        public static void Main(string[] args)
        {
            var cafe = new Coffee();
            var colacao = new Colacao();
            var carajillo = new Orujo(cafe);
            var colacaoConCanela = new Canela(colacao);
            var desayunoJose = new Soja(cafe);
            var vienes = new Leche(new Nata(cafe));

            var carajilloPrecio = carajillo.Precio();


            var desayunoJosePrecio = desayunoJose.Precio();



            var colacaoConCanelaPrecio = colacaoConCanela.Precio();
            Console.WriteLine(colacaoConCanelaPrecio);
            Console.WriteLine(carajilloPrecio);

        }
    }

}
