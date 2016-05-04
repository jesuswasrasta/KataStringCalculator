using System;


namespace StringCalculator
{
    public class Calculator
    {
	    public int Add(string inputString)
	    {
			if (string.IsNullOrEmpty(inputString))
			{
				return 0;
			}

			//work incrementally... This code works only for 1 or 2 numbers.
			var result = 0;
			var numbers = inputString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var number in numbers)
			{
				var tempNumber = 0;
				int.TryParse(number, out tempNumber);
				result += tempNumber;
			}

			return result;
		}
	}
}
