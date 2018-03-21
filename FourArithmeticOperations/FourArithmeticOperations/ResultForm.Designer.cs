namespace FourArithmeticOperations
{
	partial class ResultForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CalculationResult = new System.Windows.Forms.TextBox();
			this.Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CalculationResult
			// 
			this.CalculationResult.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CalculationResult.Location = new System.Drawing.Point(12, 127);
			this.CalculationResult.Name = "CalculationResult";
			this.CalculationResult.Size = new System.Drawing.Size(821, 71);
			this.CalculationResult.TabIndex = 0;
			this.CalculationResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Label.Location = new System.Drawing.Point(250, 36);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(284, 64);
			this.Label.TabIndex = 1;
			this.Label.Text = "計算結果";
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 263);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.CalculationResult);
			this.Name = "ResultForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ResultForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CalculationResult;
		private System.Windows.Forms.Label Label;
	}
}