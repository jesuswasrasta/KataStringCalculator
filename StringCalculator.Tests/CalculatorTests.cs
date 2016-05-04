using System;

using NUnit.Framework;


namespace StringCalculator.Tests
{
	[TestFixture]
    public class CalculatorTests
    {
		[Test]
		public void EmptyString_Returns_0()
		{
			var calculator = new Calculator();
			var actualResult = calculator.Add(String.Empty);

			Assert.That(actualResult, Is.EqualTo(0));
		}

		[Test]
		public void NonNumericString_Returns_0()
		{
			var calculator = new Calculator();
			var actualResult = calculator.Add("abc");

			Assert.That(actualResult, Is.EqualTo(0));
		}

		[Test]
		public void StringWithNumber3_Returns_3()
		{
			var calculator = new Calculator();
			var actualResult = calculator.Add("3");

			Assert.That(actualResult, Is.EqualTo(3));
		}

		[Test]
		public void StringWithNumber3comma4_Returns_7()
		{
			var calculator = new Calculator();
			var actualResult = calculator.Add("3,4");

			Assert.That(actualResult, Is.EqualTo(7));
		}

		[Test]
		public void StringWithNumber3comma4comma5_Returns_12()
		{
			var calculator = new Calculator();
			var actualResult = calculator.Add("3,4,5");

			Assert.That(actualResult, Is.EqualTo(12));
		}
	}
}
