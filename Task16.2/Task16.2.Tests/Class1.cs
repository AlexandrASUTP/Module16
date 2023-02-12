using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._2.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(1, 1) == 2);
        }
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(1, 1) == 0);
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(2, 1) == 2);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }
    }
}
