using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Utilities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PäivämääräTestit()
        {
            // kelvollinen päivämäärä
            string syöte = "14.8.2018";
            DateTime tulos = DateParsing.ParseFinnishDate(syöte);
            DateTime odotettu = new DateTime(2018, 8, 14);
            Assert.AreEqual(odotettu, tulos);

            // kelvollinen päivämäärä2
            syöte = "29.2.2000";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = new DateTime(2000, 2, 29);
            Assert.AreEqual(odotettu, tulos);

            // virheellinen syöte
            syöte = "";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            // null-syöte
            syöte = null;
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            // virheellinen päivämäärä
            syöte = "14/8/2018";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);
        }
    }
}
