using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;
namespace OperazioniTests
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestSommaPositivi()
        {
            int a = 3;
            int b = 7;
            int somma_aspettata = 10;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNulli()
        {
            int a = 0;
            int b = 0;
            int somma_aspettata = 0;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNegativi()
        {
            int a = -3;
            int b = -2;
            int somma_aspettata = -5;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaPositivoNegativo()
        {
            int a = -10;
            int b = +2;
            int somma_aspettata = -8;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaDouble()
        {
            double a = 10.2;
            double b = 4.8;
            double somma_aspettata = 15;
            double somma_effettiva;
            somma_effettiva = Gestione.SommaDouble(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaPositivi()
        {
            int a = 10;
            int b = 5;
            int somma_aspettata = 5;
            int somma_effettiva;
            somma_effettiva = Gestione.Differenza(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaNulli()
        {
            int a = 0;
            int b = 0;
            int somma_aspettata = 0;
            int somma_effettiva;
            somma_effettiva = Gestione.Differenza(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaNegativi()
        {
            int a = -10;
            int b = -5;
            int somma_aspettata = -5;
            int somma_effettiva;
            somma_effettiva = Gestione.Differenza(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaDiversi()
        {
            int a = -10;
            int b = +5;
            int somma_aspettata = -15;
            int somma_effettiva;
            somma_effettiva = Gestione.Differenza(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaDouble()
        {
            double a = 15.2;
            double b = 5.2;
            double somma_aspettata = 10.0;
            double somma_effettiva;
            somma_effettiva = Gestione.DifferenzaDouble(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazionePositivi()
        {
            int a = 10;
            int b = 2;
            int somma_aspettata = 20;
            int somma_effettiva;
            somma_effettiva = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazioneNulli()
        {
            int a = 0;
            int b = 0;
            int somma_aspettata = 0;
            int somma_effettiva;
            somma_effettiva = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);

        }
        [TestMethod]
        public void TestMoltiplicazioneNegativi()
        {
            int a = -5;
            int b = -2;
            int somma_aspettata = +10;
            int somma_effettiva;
            somma_effettiva = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);

        }
        [TestMethod]
        public void TestMoltiplicazioneDiversi()
        {
            int a = -5;
            int b = +2;
            int somma_aspettata = -10;
            int somma_effettiva;
            somma_effettiva = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazioneDouble()
        {
            double a = 15.2;
            double b = 2.2;
            double somma_aspettata = 33.44;
            double somma_effettiva;
            somma_effettiva = Gestione.MoltiplicazioneDouble(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisionePositivi()
        {
            int a = 10;
            int b = 2;
            int somma_aspettata = 5;
            int somma_effettiva;
            somma_effettiva = Gestione.Divisione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisioneNegativi()
        {
            int a = -10;
            int b = -2;
            int somma_aspettata = +5;
            int somma_effettiva;
            somma_effettiva = Gestione.Divisione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);

        }
        [TestMethod]
        public void TestDivisioneDiversi()
        {
            int a = -10;
            int b = +2;
            int somma_aspettata = -5;
            int somma_effettiva;
            somma_effettiva = Gestione.Divisione(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]      
        public void TestDivisioneDouble()
        {
            double a = 6.6;
            double b = 3.3;
            double somma_aspettata = 2;
            double somma_effettiva;
            somma_effettiva = Gestione.DivisioneDouble(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
    }
}