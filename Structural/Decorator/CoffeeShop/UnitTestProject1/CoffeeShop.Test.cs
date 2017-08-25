namespace UnitTestProject1
{

    using CoffeeShop.Complements;
    using CoffeeShop.Drinks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoffeeShopTest
    {
        [TestMethod]
        public void Cafe()
        {
            var cafe = new Coffee();
            Assert.AreEqual(1, cafe.Precio());
        }

        [TestMethod]
        public void Carajillo()
        {
            var carajillo = new Orujo(new Coffee());
            Assert.AreEqual(2, carajillo.Precio());
        }
        [TestMethod]
        public void Colacao()
        {
            Assert.AreEqual(1.20m, new Colacao().Precio());
        }

        [TestMethod]
        public void ColacaoConCanela()
        {
            var colacaoConCanela = new Canela(new Colacao());
            Assert.AreEqual(1.35m, colacaoConCanela.Precio());
        }
        [TestMethod]
        public void DesayunoJose()
        {
            var desayunoJose = new Soja(new Coffee());
            Assert.AreEqual(1.20m, desayunoJose.Precio()); //Café + soja
        }
        [TestMethod]
        public void Vienes()
        {
            var vienes = new Leche(new Nata(new Coffee()));
            Assert.AreEqual(1.60m, vienes.Precio()); //café + leche + nata
        }
        [TestMethod]
        public void Especial()
        {
            var especial = new Orujo(new Nata(new Leche(new Leche(new Coffee()))));
            Assert.AreEqual(2.70m, especial.Precio()); //café + doble de leche + nata + Orujo
        }
    }
}
