using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourArithmeticOperations
{
	public partial class FourArithmeticForm : Form
	{
		private FourArithmeticCalculator fourArithmeticCalculator_ = new FourArithmeticCalculator();

		public FourArithmeticForm()
		{
			InitializeComponent();

			FourArithmetic.SelectedItem = "+";
			uxValueLeft_.Text = "1.0";
			uxValueRight_.Text = "1.0";

			ShowResultButton.Enabled = false;
		}

		private void Calculation_Click(object sender, EventArgs e)
		{
			Result.Text = fourArithmeticCalculator_.CalculateResult().ToString();

			if (ShowResultButton.Enabled) {
			} else {
				ShowResultButton.Enabled = true;
			}
		}

		private void uxValueLeft__KeyPress(object sender, KeyPressEventArgs e)
		{
			InputOnlyValue(uxValueLeft_, e);
		}

		private void uxValueRight__KeyPress(object sender, KeyPressEventArgs e)
		{
			InputOnlyValue(uxValueRight_, e);
		}

		private void uxValueLeft__Validated(object sender, EventArgs e)
		{
			InitializeTextBox(uxValueLeft_);
		}

		private void uxValueRight__Validated(object sender, EventArgs e)
		{
			InitializeTextBox(uxValueRight_);
		}

		private void ShowResultButton_Click(object sender, EventArgs e)
		{
			var resultForm = new ResultForm(fourArithmeticCalculator_);

			resultForm.Text = "計算結果";
			resultForm.Show();
			
		}

		private void FourArithmetic_SelectedIndexChanged(object sender, EventArgs e)
		{
			fourArithmeticCalculator_.Operator = FourArithmetic.SelectedItem.ToString();
		}

		public void InitializeTextBox(TextBox textBox)
		{
			if (textBox.Text == "") {
				MessageBox.Show("この項目は必須入力です！");
				textBox.Text = "1.0";
			}

			if (textBox.Text.Contains("-")) {
				if (textBox.Text.StartsWith("-")) {

				} else {
					MessageBox.Show("-（マイナス）は最初につけてください。");
					textBox.Text = "-1.0";
				}
			}

			if (textBox.Name.Contains("Left")) {
				fourArithmeticCalculator_.LeftValue = Convert.ToDouble(textBox.Text);
			} else if (textBox.Name.Contains("Right")) {
				fourArithmeticCalculator_.RightValue = Convert.ToDouble(textBox.Text);
			}
		}

		public void InputOnlyValue(TextBox textbox, KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b') {
				if (e.KeyChar == '.') {
					if (textbox.Text.Contains('.')) {
						e.Handled = true;
					} else {
						e.Handled = false;
					}
				} else if (e.KeyChar == '-') {
					if (textbox.Text.StartsWith("-")) {
						e.Handled = true;
					} else {
						textbox.Text = "-" + textbox.Text;
						e.Handled = true;
					}
				} else {
					e.Handled = true;
				}
			}
		}

		private void FourArithmetic_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
