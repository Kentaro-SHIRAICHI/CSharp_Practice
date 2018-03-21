namespace FourArithmeticOperations
{
	partial class FourArithmeticForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.uxValueLeft_ = new System.Windows.Forms.TextBox();
			this.Result = new System.Windows.Forms.TextBox();
			this.uxValueRight_ = new System.Windows.Forms.TextBox();
			this.FourArithmetic = new System.Windows.Forms.ComboBox();
			this.Calculation = new System.Windows.Forms.Button();
			this.ShowResultButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// uxValueLeft_
			// 
			this.uxValueLeft_.Location = new System.Drawing.Point(12, 86);
			this.uxValueLeft_.Name = "uxValueLeft_";
			this.uxValueLeft_.Size = new System.Drawing.Size(101, 19);
			this.uxValueLeft_.TabIndex = 0;
			this.uxValueLeft_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxValueLeft__KeyPress);
			this.uxValueLeft_.Validated += new System.EventHandler(this.uxValueLeft__Validated);
			// 
			// Result
			// 
			this.Result.BackColor = System.Drawing.Color.Yellow;
			this.Result.Location = new System.Drawing.Point(129, 195);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(133, 19);
			this.Result.TabIndex = 1;
			// 
			// uxValueRight_
			// 
			this.uxValueRight_.Location = new System.Drawing.Point(289, 86);
			this.uxValueRight_.Name = "uxValueRight_";
			this.uxValueRight_.Size = new System.Drawing.Size(101, 19);
			this.uxValueRight_.TabIndex = 1;
			this.uxValueRight_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxValueRight__KeyPress);
			this.uxValueRight_.Validated += new System.EventHandler(this.uxValueRight__Validated);
			// 
			// FourArithmetic
			// 
			this.FourArithmetic.BackColor = System.Drawing.Color.White;
			this.FourArithmetic.FormattingEnabled = true;
			this.FourArithmetic.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.FourArithmetic.Location = new System.Drawing.Point(141, 85);
			this.FourArithmetic.Name = "FourArithmetic";
			this.FourArithmetic.Size = new System.Drawing.Size(121, 20);
			this.FourArithmetic.TabIndex = 2;
			this.FourArithmetic.Text = "演算子";
			this.FourArithmetic.SelectedIndexChanged += new System.EventHandler(this.FourArithmetic_SelectedIndexChanged);
			this.FourArithmetic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FourArithmetic_KeyPress);
			// 
			// Calculation
			// 
			this.Calculation.Location = new System.Drawing.Point(159, 148);
			this.Calculation.Name = "Calculation";
			this.Calculation.Size = new System.Drawing.Size(75, 23);
			this.Calculation.TabIndex = 3;
			this.Calculation.Text = "計算";
			this.Calculation.UseVisualStyleBackColor = true;
			this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
			// 
			// ShowResultButton
			// 
			this.ShowResultButton.Location = new System.Drawing.Point(300, 230);
			this.ShowResultButton.Name = "ShowResultButton";
			this.ShowResultButton.Size = new System.Drawing.Size(75, 23);
			this.ShowResultButton.TabIndex = 4;
			this.ShowResultButton.Text = "表示";
			this.ShowResultButton.UseVisualStyleBackColor = true;
			this.ShowResultButton.Click += new System.EventHandler(this.ShowResultButton_Click);
			// 
			// FourArithmeticForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 275);
			this.Controls.Add(this.ShowResultButton);
			this.Controls.Add(this.Calculation);
			this.Controls.Add(this.FourArithmetic);
			this.Controls.Add(this.uxValueRight_);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.uxValueLeft_);
			this.Name = "FourArithmeticForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox uxValueLeft_;
		private System.Windows.Forms.TextBox Result;
		private System.Windows.Forms.TextBox uxValueRight_;
		private System.Windows.Forms.ComboBox FourArithmetic;
		private System.Windows.Forms.Button Calculation;
		private System.Windows.Forms.Button ShowResultButton;
	}
}

