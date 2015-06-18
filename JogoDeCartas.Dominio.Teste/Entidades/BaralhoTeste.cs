using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JogoDeCartas.Dominio.Entidades;

namespace JogoDeCartas.Dominio.Teste.Entidades
{
    [TestClass]
    public class BaralhoTeste
    {
        [TestMethod]
        public void NovoBaralhoTeste()
        {
            Baralho baralho = new Baralho();
            Assert.AreEqual(baralho.Cartas.Count, 52);
        }

        [TestMethod]
        public void EmbaralharCartasTeste()
        {
            Baralho baralho = new Baralho();
            baralho.EmbaralharCartas();

            Assert.AreEqual(baralho.Cartas.Count, 52);
        }
    }
}
