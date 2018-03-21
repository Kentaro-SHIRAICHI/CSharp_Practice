using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Reactive.Bindings;
using System.ComponentModel;

namespace FourArithmeticCalculator
{
	public class FourArithmeticCalculatorModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>左辺値</summary>
		private double _Left = 0.0;
		public double Left {
			get
			{
				return _Left;
			}
			set
			{
				_Left = value;
				OnPropertyChanged(nameof(Left));
			}
		}


		/// <summary>右辺値</summary>
		private double _Right = 0.0;
		public double Right
		{
			get
			{
				return _Right;
			}
			set
			{
				_Right = value;
				OnPropertyChanged(nameof(Right));
			}
		}
		/// <summary>選択されている演算子</summary>
		private OperatorEnum _SelectedOp = OperatorEnum.足し算;
		public OperatorEnum SelectedOp {
			get
			{
				return _SelectedOp;
			}
			set
			{
				_SelectedOp = value;
				OnPropertyChanged(nameof(SelectedOp));
			}
		}

		/// <summary>計算結果値</summary>
		private double _Result = 0.0;
		public double Result
		{
			get
			{
				return _Result;
			}
			set
			{
				_Result = value;
				OnPropertyChanged(nameof(Result));
			}
		}
		/// <summary>
		/// 結果表示用の式
		/// 1.3 + 2.5 = 3.8のような形
		/// </summary>
		private string _AllFormula = "";
		public string AllFormula {
			get
			{
				return _AllFormula;
			}
			set
			{
				_AllFormula = value;
				OnPropertyChanged(nameof(AllFormula));
			}
		} 

		/// <summary>
		/// 計算結果を表示するとき用
		/// SelectedOpをそのまま使うと見栄えが良くないから
		/// </summary>
		public string FourArithmeticOperator { get; set; }

		/// <summary>計算結果があるかどうか</summary>
		private bool _CalculationResultExist = false;
		public bool CalculationResultExist
		{
			get
			{
				return _CalculationResultExist;
			}
			set
			{
				_CalculationResultExist = value;
				OnPropertyChanged(nameof(CalculationResultExist));
			}
		}


		/*------------------------------------------------------------------------------------//
		 * コンストラクタ
		 ------------------------------------------------------------------------------------*/
		public FourArithmeticCalculatorModel()
		{
		}

		protected void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}


		//------------------------------------------------------------------------------------//
		/// <summary>計算結果とその式を求める関数</summary>
		/// 
		//! @author Kentaro_SHIRAICHI
		//------------------------------------------------------------------------------------//
		public void CalculateResult()
		{
			switch (SelectedOp) {
				case OperatorEnum.足し算:
					Result = Left + Right;
					FourArithmeticOperator = "+";
					break;
				case OperatorEnum.引き算:
					Result = Left - Right;
					FourArithmeticOperator = "-";
					break;
				case OperatorEnum.掛け算:
					Result = Left * Right;
					FourArithmeticOperator = "*";
					break;
				case OperatorEnum.割り算:
					Result = Left / Right;
					FourArithmeticOperator = "/";
					break;
				default:
					MessageBox.Show("Error!!");
					break;
			}

			AllFormula = $"{Left} "	+ FourArithmeticOperator + $" {Right} = {Result}";

			if (CalculationResultExist) {

			} else {
				CalculationResultExist = true;
			}
		}
	}
}
