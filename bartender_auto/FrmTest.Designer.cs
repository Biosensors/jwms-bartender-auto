namespace BartenderStudy
{
	partial class FrmTest
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
			if (disposing && (components != null))
			{
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
			this.txtPlanQty = new System.Windows.Forms.TextBox();
			this.txt = new System.Windows.Forms.Label();
			this.lstYear = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBatchNo = new System.Windows.Forms.TextBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPlanQty
			// 
			this.txtPlanQty.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtPlanQty.Location = new System.Drawing.Point(453, 195);
			this.txtPlanQty.MaxLength = 4;
			this.txtPlanQty.Name = "txtPlanQty";
			this.txtPlanQty.Size = new System.Drawing.Size(75, 29);
			this.txtPlanQty.TabIndex = 38;
			// 
			// txt
			// 
			this.txt.AutoSize = true;
			this.txt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt.Location = new System.Drawing.Point(91, 203);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(77, 14);
			this.txt.TabIndex = 36;
			this.txt.Text = "生产批号：";
			// 
			// lstYear
			// 
			this.lstYear.FormattingEnabled = true;
			this.lstYear.ItemHeight = 12;
			this.lstYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.lstYear.Location = new System.Drawing.Point(658, 219);
			this.lstYear.Name = "lstYear";
			this.lstYear.Size = new System.Drawing.Size(62, 52);
			this.lstYear.TabIndex = 35;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(91, 241);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 14);
			this.label7.TabIndex = 31;
			this.label7.Text = "生产日期：";
			// 
			// dtDateTo
			// 
			this.dtDateTo.CustomFormat = "yyyy-MM-dd";
			this.dtDateTo.Enabled = false;
			this.dtDateTo.Location = new System.Drawing.Point(453, 232);
			this.dtDateTo.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.dtDateTo.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
			this.dtDateTo.Name = "dtDateTo";
			this.dtDateTo.Size = new System.Drawing.Size(157, 21);
			this.dtDateTo.TabIndex = 34;
			// 
			// dtDateFrom
			// 
			this.dtDateFrom.CustomFormat = "yyyy-MM-dd";
			this.dtDateFrom.Location = new System.Drawing.Point(174, 232);
			this.dtDateFrom.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
			this.dtDateFrom.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
			this.dtDateFrom.Name = "dtDateFrom";
			this.dtDateFrom.Size = new System.Drawing.Size(178, 21);
			this.dtDateFrom.TabIndex = 30;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(174, 128);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(438, 29);
			this.textBox1.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(83, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 18);
			this.label6.TabIndex = 32;
			this.label6.Text = "扫描/输入";
			// 
			// txtBatchNo
			// 
			this.txtBatchNo.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtBatchNo.Location = new System.Drawing.Point(174, 194);
			this.txtBatchNo.MaxLength = 15;
			this.txtBatchNo.Name = "txtBatchNo";
			this.txtBatchNo.Size = new System.Drawing.Size(178, 29);
			this.txtBatchNo.TabIndex = 37;
			// 
			// btnPrint
			// 
			this.btnPrint.Enabled = false;
			this.btnPrint.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnPrint.Location = new System.Drawing.Point(110, 312);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(633, 35);
			this.btnPrint.TabIndex = 39;
			this.btnPrint.Text = "打印";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// FrmTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.txtPlanQty);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.lstYear);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtDateTo);
			this.Controls.Add(this.dtDateFrom);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtBatchNo);
			this.Name = "FrmTest";
			this.Text = "FrmTest";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPlanQty;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.ListBox lstYear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtDateTo;
		private System.Windows.Forms.DateTimePicker dtDateFrom;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBatchNo;
		private System.Windows.Forms.Button btnPrint;
	}
}