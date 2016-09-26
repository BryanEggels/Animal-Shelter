using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_shelter;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Asiel asiel = new Asiel();
        [TestMethod]
        public void Walkdog()
        {
            Asiel asiel = new Asiel();
            asiel.naam = "naam";
            Hond dog = new Hond(300, "piet", asiel, true);
            dog.walkdog(DateTime.Now);

            Assert.AreEqual(1, dog.Uitlaatlijst.Count);
            Assert.AreEqual("naam", asiel.naam);
        }
        [TestMethod]
        public void cattest()
        {
            Kat cat = new Kat(300, "kat", asiel, true, "goede kat");

            Assert.AreEqual("kat goede kat", cat.ToString());
        }
    }
}
