using System;
using NUnit.Framework;

namespace PRG.Tests.Equality
{
    [TestFixture]
    public class calcTests
    {
        [Test]
        public void TwentyYearOldMale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(20, "male");

            Assert.That(result, Is.EqualTo(6.0));
        }
        [Test]
        public void SixtyYearOldMale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(60, "male");

            Assert.That(result, Is.EqualTo(0.75));
        }
        [Test]
        public void FifteenYearOldMale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(15, "male");

            Assert.That(result, Is.EqualTo(0.0));
        }


        [Test]
        public void TwentyYearOldFemale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(20, "female");

            Assert.That(result, Is.EqualTo(5.0));
        }

        [Test]
        public void SixtyYearOldFemale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(60, "female");

            Assert.That(result, Is.EqualTo(0.375));
        }
        [Test]
        public void FifteenYearOldFemale()
        {
            var sut = new CalcPremium();

            var result = sut.calc(15, "female");

            Assert.That(result, Is.EqualTo(0.0));
        }



        [Test]
        public void TwentyYearOldNonGender()
        {
            var sut = new CalcPremium();

            var result = sut.calc(20, "na");

            Assert.That(result, Is.EqualTo(0.0));
        }

    }
}
