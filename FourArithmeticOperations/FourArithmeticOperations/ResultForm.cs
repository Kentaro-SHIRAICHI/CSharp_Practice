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
	public partial class ResultForm : Form
	{
		private FourArithmeticCalculator fourArithmeticCalculator_;

		public ResultForm()
		{
			InitializeComponent();
		}

		public ResultForm(FourArithmeticCalculator fourArithmeticCalculator)
		{
			InitializeComponent();
			this.fourArithmeticCalculator_ = fourArithmeticCalculator;
			CalculationResult.Text = this.fourArithmeticCalculator_.LastResult;
		}
	}
}
