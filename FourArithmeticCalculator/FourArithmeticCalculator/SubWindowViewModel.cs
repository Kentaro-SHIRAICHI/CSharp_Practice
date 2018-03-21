using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace FourArithmeticCalculator
{
	public class SubWindowViewModel
	{
		public ReactiveProperty<double> Left { get; set; }
		public ReactiveProperty<double> Right { get; set; }

		public SubWindowViewModel(FourArithmeticCalculatorModel fourArithmeticCalculatorModel)
		{
			Left = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.Left);
			Right = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.Right);
		}
	}
}
