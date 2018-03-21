using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Reactive.Bindings;

namespace FourArithmeticCalculator
{
    public class ResultWindowViewModel
    {
		public ReactiveProperty<string> CalculatedResult { get; set; }

		public ResultWindowViewModel(ReactiveProperty<string> result)
		{
			CalculatedResult = result;
		}
    }
}
