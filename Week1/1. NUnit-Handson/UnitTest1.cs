using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            Assert.That(calculator.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.That(calculator.Subtract(5, 2), Is.EqualTo(3));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.That(calculator.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.That(calculator.Divide(10, 2), Is.EqualTo(5));
        }

        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(
                () => calculator.Divide(10, 0));
        }
    }
}