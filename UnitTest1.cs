using NUnit.Framework;
using PowerStruct;

namespace PowerStruct.UnitTests
{
    [TestFixture]
    public class RealPowerTests
    {
        [Test]
        public void ConstructorTest()
        {
            var power = new RealPower(2.5, 3.1);
            Assert.That(power.Base, Is.EqualTo(2.5));
            Assert.That(power.Exponent, Is.EqualTo(3.1));
        }

        [Test]
        public void BaseSet_NegativeValue_ArgumentException()
        {
            var power = new RealPower();
            Assert.That(() => power.Base = -1.0, Throws.ArgumentException);
        }

        [Test]
        public void ValueTest()
        {
            var power1 = new RealPower(2.0, 3.0);
            Assert.That(power1.Value, Is.EqualTo(8.0).Within(1e-10));

            var power2 = new RealPower(3.0, 2.0);
            Assert.That(power2.Value, Is.EqualTo(9.0).Within(1e-10));
        }

        [TestCase(2.0, 3.0, "2E3")]
        [TestCase(1.5, -2.3, "1.5E-2.3")]
        [TestCase(3.14159, 1.61803, "3.14159E1.61803")]
        public void ToStringTest(double baseValue, double exponent, string expected)
        {
            var power = new RealPower(baseValue, exponent);
            Assert.That(power.ToString(), Is.EqualTo(expected));
        }

        [TestCase(2.0, 3.0, 2.0, 3.0, true)]
        [TestCase(2.0, 3.0, 2.0, 2.0, false)]
        [TestCase(4.0, 0.5, 2.0, 1.0, true)] // 4^0.5 = 2^1.0
        public void Equals_TwoPowers_ExpectedResult(
            double base1, double exp1, double base2, double exp2, bool result)
        {
            var power1 = new RealPower(base1, exp1);
            var power2 = new RealPower(base2, exp2);
            Assert.That(power1.Equals(power2), Is.EqualTo(result));
        }

        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var power = new RealPower();
            var obj = new object();
            Assert.That(() => power.Equals(obj), Throws.ArgumentException);
        }

        [Test]
        public void GetHashCodeTest()
        {
            var x = new RealPower(2.0, 3.0);
            var y = new RealPower(2.0, 3.0);
            var z = new RealPower(3.0, 2.0);
            Assert.That(x.GetHashCode(), Is.EqualTo(y.GetHashCode()));
            Assert.That(x.GetHashCode(), Is.Not.EqualTo(z.GetHashCode()));
        }

        [Test]
        public void ComparisonTest()
        {
            var x = new RealPower(2.0, 3.0);
            var y = new RealPower(2.0, 3.0);
            var z = new RealPower(3.0, 2.0);

            Assert.That(x == y, Is.True);
            Assert.That(x != y, Is.False);
            Assert.That(x == z, Is.False);
            Assert.That(x != z, Is.True);
        }

        [TestCase(2.0, 3.0, 2.0, 4.0, 2.0, 7.0)]
        [TestCase(3.0, 1.5, 3.0, -2.5, 3.0, -1.0)]
        public void MultiplicationTest(
            double base1, double exp1, double base2, double exp2,
            double resultBase, double resultExp)
        {
            var power1 = new RealPower(base1, exp1);
            var power2 = new RealPower(base2, exp2);
            var result = power1 * power2;

            Assert.That(result.Base, Is.EqualTo(resultBase));
            Assert.That(result.Exponent, Is.EqualTo(resultExp).Within(1e-10));
        }

        [Test]
        public void Multiplication_DifferentBases_ArgumentException()
        {
            var power1 = new RealPower(2.0, 3.0);
            var power2 = new RealPower(3.0, 2.0);
            Assert.That(() => power1 * power2, Throws.ArgumentException);
        }

        [TestCase(2.0, 5.0, 2.0, 3.0, 2.0, 2.0)]
        [TestCase(3.0, 1.5, 3.0, 2.5, 3.0, -1.0)]
        public void DivisionTest(
            double base1, double exp1, double base2, double exp2,
            double resultBase, double resultExp)
        {
            var power1 = new RealPower(base1, exp1);
            var power2 = new RealPower(base2, exp2);
            var result = power1 / power2;

            Assert.That(result.Base, Is.EqualTo(resultBase));
            Assert.That(result.Exponent, Is.EqualTo(resultExp).Within(1e-10));
        }

        [Test]
        public void Division_DifferentBases_ArgumentException()
        {
            var power1 = new RealPower(2.0, 5.0);
            var power2 = new RealPower(3.0, 2.0);
            Assert.That(() => power1 / power2, Throws.ArgumentException);
        }
    }
}