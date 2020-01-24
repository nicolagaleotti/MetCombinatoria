using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class FattorialeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int fatt = 2;
            long risposta = EquazioniLibrary.CalcoliCombinatori.Fattoriale(fatt);
            Assert.AreEqual(2, risposta);
        }
    }
}
