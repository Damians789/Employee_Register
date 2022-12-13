using NUnit.Framework;
using Pracownicy;
using System;
namespace PracownicyTest
{
    [TestFixture]
    internal class BiurowyTest
    {
        private Adres ad;
        private Biurowy _sut;

        [SetUp]
        public void Setup()
        {
            ad = new Adres("Zakrzewski",5, 7, "Krajenka");
            _sut = new Biurowy("Marian", "Dolny", 37, 12, ad, 110);
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckIfCanCreateSut()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckIfNameCorrect()
        {
            Assert.That(_sut.Imie, Is.EqualTo("Marian"));
        }
        [Test]
        public void CheckIfNazwiskoCorrect()
        {
            Assert.That(_sut.Nazwisko, Is.EqualTo("Dolny"));
        }
        [Test]
        public void CheckIfWiekCorrect()
        {
            Assert.That(_sut.Wiek, Is.EqualTo(37));
        }
        [Test]
        public void CheckIfExpCorrect()
        {
            Assert.That(_sut.Doswiadczenie, Is.EqualTo(12));
        }
        [Test]
        public void CheckIfIQCorrect()
        {
            Assert.That(_sut.Intelekt, Is.EqualTo(110));
        }
        [Test]
        public void CheckIfIQChangeCorrect()
        {
            _sut.Intelekt = 95;
            Assert.That(_sut.Intelekt, Is.EqualTo(95));
        }
        [Test]
        public void CheckIfNameChangeCorrect()
        {
            _sut.Imie = "Stefan";
            Assert.That(_sut.Imie, Is.EqualTo("Stefan"));
        }
        [Test]
        public void CheckIfNazwiskoChangeCorrect()
        {
            _sut.Nazwisko = "Marlinski";
            Assert.That(_sut.Nazwisko, Is.EqualTo("Marlinski"));
        }
        [Test]
        public void CheckIfWiekChangeCorrect()
        {
            _sut.Wiek = 38;
            Assert.That(_sut.Wiek, Is.EqualTo(38));
        }
        [Test]
        public void CheckIfExpChangeCorrect()
        {
            _sut.Doswiadczenie = 13;
            Assert.That(_sut.Doswiadczenie, Is.EqualTo(13));
        }
        [Test]
        public void CheckIfStreetCorrect()
        {
            Assert.That(_sut.Adres.Ulica, Is.EqualTo("Zakrzewski"));
        }
        [Test]
        public void CheckIfNumerBudynkuCorrect()
        {
            Assert.That(_sut.Adres.NumerBudynku, Is.EqualTo(5));
        }
        [Test]
        public void CheckIfNumerLokaluCorrect()
        {
            Assert.That(_sut.Adres.NumerLokalu, Is.EqualTo(7));
        }
        [Test]
        public void CheckIfCityCorrect()
        {
            Assert.That(_sut.Adres.Miasto, Is.EqualTo("Krajenka"));
        }
        [Test]
        public void CheckIfStreetChange()
        {
            _sut.Adres.Ulica = "Biernacki";
            Assert.That(_sut.Adres.Ulica, Is.EqualTo("Biernacki"));
        }
        [Test]
        public void CheckIfNumerBudynkuChange()
        {
            _sut.Adres.NumerBudynku = 6;
            Assert.That(_sut.Adres.NumerBudynku, Is.EqualTo(6));
        }
        [Test]
        public void CheckIfNumerLokaluChange()
        {
            _sut.Adres.NumerLokalu = 8;
            Assert.That(_sut.Adres.NumerLokalu, Is.EqualTo(8));
        }
        [Test]
        public void CheckIfCityChange()
        {
            _sut.Adres.Miasto = "Zduny";
            Assert.That(_sut.Adres.Miasto, Is.EqualTo("Zduny"));
        }
        [Test]
        public void CheckIfIQ2Low_ThrowsException()
        {
            Biurowy b;
            Assert.Throws<ArgumentOutOfRangeException>(() => b = new Biurowy("Marian", "Dolny", 37, 12, ad, 69));
        }
        [Test]
        public void CheckIfIQ2High_ThrowsException()
        {
            Biurowy b;
            Assert.Throws<ArgumentOutOfRangeException>(() => b = new Biurowy("Marian", "Dolny", 37, 12, ad, 171));
        }
        [Test]
        public void CheckIfWartoscCorrect()
        {
            Assert.That(_sut.Wartosc(), Is.EqualTo(_sut.Doswiadczenie * _sut.Intelekt));
        }
    }
}
