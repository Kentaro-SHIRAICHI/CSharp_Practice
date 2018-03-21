using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Reactive.Bindings;

namespace FourArithmeticCalculator
{
    /// <summary>
    /// ResultWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ResultWindow : Window
    {
		public ResultWindowViewModel ResultWindowViewModel;

        public ResultWindow(ReactiveProperty<string> Result)
        {
            InitializeComponent();

			ResultWindowViewModel = new ResultWindowViewModel(Result);

			this.DataContext = ResultWindowViewModel;
        }
    }
}
