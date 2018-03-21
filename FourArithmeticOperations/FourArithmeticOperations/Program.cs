using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourArithmeticOperations
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var form1 = new FourArithmeticForm();

			form1.Text = "四則演算";
			Application.Run(form1);
		}
	}
}
