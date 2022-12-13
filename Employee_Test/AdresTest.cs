using NUnit.Framework;
using Pracownicy;
using System;

namespace PracownicyTest
{

    [TestFixture]
    public class AdresTest
    {
        private Adres _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new Adres("Zakrzewski", 5, 7, "Krajenka");
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
        public void CheckIfStreetCorrect()
        {
            Assert.That(_sut.Ulica, Is.EqualTo("Zakrzewski"));
        }
        [Test]
        public void CheckIfLocalCorrect()
        {
            Assert.That(_sut.NumerBudynku, Is.EqualTo(5));
        }
        [Test]
        public void CheckIfZipCorrect()
        {
            Assert.That(_sut.NumerLokalu, Is.EqualTo(7));
        }
        [Test]
        public void CheckIfCityCorrect()
        {
            Assert.That(_sut.Miasto, Is.EqualTo("Krajenka"));
        }
        [Test]
        public void CheckIfStreetChange()
        {
            _sut.Ulica = "Biernacki";
            Assert.That(_sut.Ulica, Is.EqualTo("Biernacki"));
        }
        [Test]
        public void CheckIfLocalChange()
        {
            _sut.NumerBudynku = 6;
            Assert.That(_sut.NumerBudynku, Is.EqualTo(6));
        }
        [Test]
        public void CheckIfZipChange()
        {
            _sut.NumerLokalu = 8;
            Assert.That(_sut.NumerLokalu, Is.EqualTo(8));
        }
        [Test]
        public void CheckIfCityChange()
        {
            _sut.Miasto = "Zduny";
            Assert.That(_sut.Miasto, Is.EqualTo("Zduny"));
        }
        [Test]
        public void CheckIfStreetNameIncorrect_ThrowsException()
        {
            Adres a;
            Assert.Throws<Exception>(() => a = new Adres("Malinowa 58", 7, 8, "Gdańsk"));
        }
        [Test]
        public void CheckIfCityNameIncorrect_ThrowsException()
        {
            Adres a;
            Assert.Throws<Exception>(() => a = new Adres("Malinowa", 7, 8, "Gdańsk32"));
        }
        [Test]
        public void CheckIfIncorrectNumer_ThrowsException()
        {
            Adres a;
            Assert.Throws<Exception>(() => a = new Adres("Malinowa", -7, 8, "Gdańsk"));
        }
        [Test]
        public void CheckIfIncorrectNumer2_ThrowsException()
        {
            Adres a;
            Assert.Throws<Exception>(() => a = new Adres("Malinowa", 7, -8, "Gdańsk"));
        }

    }
}