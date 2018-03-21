using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace FourArithmeticCalculator
{
	/// <summary>
	/// 演算子の列挙型
	/// </summary>
	//! @author Kentaro_SHIRAICHI
	public enum OperatorEnum
	{
		足し算,
		引き算,
		掛け算,
		割り算
	}

	public class MainWindowViewModel
	{
		/// <summary>左辺値</summary>
		public ReactiveProperty<double> Left { get; set; }
		/// <summary>右辺値</summary>
		public ReactiveProperty<double> Right { get; set; }
		/// <summary>計算結果値</summary>
		public ReactiveProperty<double> Result { get; set; }

		/// <summary>選択できる演算子</summary>
		public ReactiveProperty<OperatorEnum[]> Op { get; set; }
			= new ReactiveProperty<OperatorEnum[]>(Enum.GetValues(typeof(OperatorEnum)) as OperatorEnum[]);
		/// <summary>選択している演算子</summary>
		public ReactiveProperty<OperatorEnum> SelectedOp { get; set; }

		/// <summary>計算結果を求めるコマンド</summary>
		public ReactiveCommand CalculateCommand { get; }
		/// <summary>計算結果を表示するコマンド</summary>
		public ReactiveCommand ShowResultCommand { get; }

		/// <summary>
		/// 結果表示用の式
		/// 1.3 + 2.5 = 3.8のような形
		/// </summary>
		public ReactiveProperty<string> AllFormula { get; set; }

		/// <summary>計算結果があるかどうか</summary>
		public ReactiveProperty<bool> CalculationResultExist { get; set; }

		/// <summary>計算用のコマンドなどが入ったクラス</summary>
		public FourArithmeticCalculatorModel fourArithmeticCalculatorModel;

		/*----------------------------------------------------------
		 * コンストラクタ
		 *----------------------------------------------------------*/
		public MainWindowViewModel()
		{
			fourArithmeticCalculatorModel = new FourArithmeticCalculatorModel();

			Left = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.Left);
			Right = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.Right);
			Result = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.Result);
			SelectedOp = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.SelectedOp);
			AllFormula = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.AllFormula);
			CalculationResultExist = fourArithmeticCalculatorModel
				.ToReactivePropertyAsSynchronized(x => x.CalculationResultExist);

			this.CalculateCommand = new[] {
				this.Right.ObserveHasErrors,
				this.Left.ObserveHasErrors,
				this.SelectedOp.ObserveHasErrors
			}
			.CombineLatest(x => x.All(y => !y))
			.ToReactiveCommand();

			this.CalculateCommand.Subscribe(fourArithmeticCalculatorModel.CalculateResult);

			this.ShowResultCommand = CalculationResultExist.ToReactiveCommand();

			this.ShowResultCommand.Subscribe(ShowResult);

			var win = new SubWindow(fourArithmeticCalculatorModel);
			win.Show();
		}

		//------------------------------------------------------------------------------------//
		/// <summary>結果を別画面に表示するコマンド</summary>
		/// 
		//! @author Kentaro_SHIRAICHI
		//------------------------------------------------------------------------------------//
		public void ShowResult()
		{
			ResultWindow ResultWindow = new ResultWindow(AllFormula);

			ResultWindow.Show();
		}
	}
}
