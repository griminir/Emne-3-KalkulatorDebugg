using System.Diagnostics;
using Emne_3_KalkulatorDebugg.console;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace KalkulatorDebugg.test
{
    public class KalkulatorTest
    {
        [Test]
        public void testLeggSammenPositiveTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.LeggSammen(3, 1);

            //Assert
            //ClassicAssert.AreEqual(4, sum);
            Assert.That(4, Is.EqualTo(sum));
        }

        [Test]
        public void testLeggSammenNull()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.LeggSammen(0, 0);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testLeggSammenEtNegativtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.LeggSammen(-3, 0);

            //Assert
            Assert.That(-3, Is.EqualTo(sum));
        }

        [Test]
        public void testLeggSammen2NegativTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.LeggSammen(-3, -3);

            //Assert
            Assert.That(-6, Is.EqualTo(sum));
        }

        [Test]
        public void testTrekkFraNull()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.TrekkFra(0, 0);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testTrekkFraEtNegativtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.TrekkFra(0, -3);

            //Assert
            Assert.That(3, Is.EqualTo(sum));
        }

        [Test]
        public void testTrekkFra2NegativeTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.TrekkFra(-3, -3);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testTrekkFraPositivtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.TrekkFra(15, 6);

            //Assert
            Assert.That(9, Is.EqualTo(sum));
        }

        [Test]
        public void testMutipliserMedNull()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Multipliser(0, 0);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testMutipliserMedNullogEtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Multipliser(0, 15);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testMutipliser()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Multipliser(3, 8);

            //Assert
            Assert.That(24, Is.EqualTo(sum));
        }

        [Test]
        public void testMutipliserMed1NegativtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Multipliser(3, -2);

            //Assert
            Assert.That(-6, Is.EqualTo(sum));
        }

        [Test]
        public void testMutipliserMed2NegativtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Multipliser(-3, -2);

            //Assert
            Assert.That(6, Is.EqualTo(sum));
        }

        [Test]
        public void testDelNullMedNull()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(0, 5);

            //Assert
            Assert.That(0, Is.EqualTo(sum));
        }

        [Test]
        public void testDel2PositiveTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(8, 2);

            //Assert
            Assert.That(4, Is.EqualTo(sum));
        }

        [Test]
        public void testDelMinderetallMedStørreTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(5, 10);

            //Assert
            Assert.That(0.5, Is.EqualTo(sum));
        }

        [Test]
        public void testDel1NegativtTalldelpåstørretall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(-5, 10);

            //Assert
            Assert.That(-0.5, Is.EqualTo(sum));
        }

        [Test]
        public void testDel1NegativtTalldeltpåMindreTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(10, -5);

            //Assert
            Assert.That(-2, Is.EqualTo(sum));
        }

        [Test]
        public void testDel2NegativtTall()
        {
            //arrange
            var calc = new Kalkulator();

            //act
            var sum = calc.Divider(-5, -10);

            //Assert
            Assert.That(0.5, Is.EqualTo(sum));
        }
    }
}