using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourArithmeticOperations
{
	public class FourArithmeticCalculator
	{
		public double LeftValue { get; set; }

		public double RightValue { get; set; }

		public string Operator { get; set; }

		public double ResultValue { get; private set; }

		public string LastResult { get; private set; }

		public FourArithmeticCalculator()
		{
			LeftValue = 1.0;
			RightValue = 1.0;
			Operator = "+";
			ResultValue = CalculateResult();
			LastResult = "";
		}

		public double CalculateResult()
		{
			switch (Operator) {
				case "+":
					ResultValue = LeftValue + RightValue;
					break;
				case "-":
					ResultValue = LeftValue - RightValue;
					break;
				case "*":
					ResultValue = LeftValue * RightValue;
					break;
				case "/":
					ResultValue = LeftValue / RightValue;
					break;
			}

			LastResult = GetAllFormula();

			return ResultValue;
		}

		public string GetAllFormula()
		{
			return $"{LeftValue} {Operator} {RightValue} = {ResultValue}";
		}
	}
}
