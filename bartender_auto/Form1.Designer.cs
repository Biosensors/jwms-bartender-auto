namespace BartenderStudy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtTemplateFile = new System.Windows.Forms.TextBox();
			this.btnFileOpen = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkAutoPrint = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radExpiredDays = new System.Windows.Forms.RadioButton();
			this.radProductionDate = new System.Windows.Forms.RadioButton();
			this.txtExpiredDays = new System.Windows.Forms.TextBox();
			this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
			this.numCodesQuantity = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listPrinter = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "模板文件";
			// 
			// txtTemplateFile
			// 
			this.txtTemplateFile.Location = new System.Drawing.Point(105, 32);
			this.txtTemplateFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtTemplateFile.Name = "txtTemplateFile";
			this.txtTemplateFile.ReadOnly = true;
			this.txtTemplateFile.Size = new System.Drawing.Size(382, 23);
			this.txtTemplateFile.TabIndex = 1;
			// 
			// btnFileOpen
			// 
			this.btnFileOpen.Location = new System.Drawing.Point(513, 30);
			this.btnFileOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnFileOpen.Name = "btnFileOpen";
			this.btnFileOpen.Size = new System.Drawing.Size(76, 28);
			this.btnFileOpen.TabIndex = 2;
			this.btnFileOpen.Text = "浏览...";
			this.btnFileOpen.UseVisualStyleBackColor = true;
			this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTemplateFile);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnFileOpen);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(613, 80);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "打印模板";
			// 
			// btnPrint
			// 
			this.btnPrint.Enabled = false;
			this.btnPrint.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnPrint.Location = new System.Drawing.Point(16, 550);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(605, 43);
			this.btnPrint.TabIndex = 13;
			this.btnPrint.Text = "打印";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numCodesQuantity);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.listPrinter);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(16, 265);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Size = new System.Drawing.Size(613, 105);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "打印机";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkAutoPrint);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox4.Location = new System.Drawing.Point(13, 386);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox4.Size = new System.Drawing.Size(616, 137);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "UDI码录入";
			// 
			// checkAutoPrint
			// 
			this.checkAutoPrint.AutoSize = true;
			this.checkAutoPrint.Checked = true;
			this.checkAutoPrint.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAutoPrint.Location = new System.Drawing.Point(120, 97);
			this.checkAutoPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkAutoPrint.Name = "checkAutoPrint";
			this.checkAutoPrint.Size = new System.Drawing.Size(82, 18);
			this.checkAutoPrint.TabIndex = 21;
			this.checkAutoPrint.Text = "自动打印";
			this.checkAutoPrint.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(129, 26);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(469, 23);
			this.textBox1.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(41, 29);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 14);
			this.label6.TabIndex = 19;
			this.label6.Text = "扫描/输入";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label4.Location = new System.Drawing.Point(28, 109);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(475, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "注意：1、将输入法设置为英文 2、将EAN码和规格清单放到程序目录下";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radExpiredDays);
			this.groupBox3.Controls.Add(this.radProductionDate);
			this.groupBox3.Controls.Add(this.txtExpiredDays);
			this.groupBox3.Controls.Add(this.dtProductionDate);
			this.groupBox3.Location = new System.Drawing.Point(16, 150);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(613, 85);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "生产日期";
			// 
			// radExpiredDays
			// 
			this.radExpiredDays.AutoSize = true;
			this.radExpiredDays.Location = new System.Drawing.Point(367, 39);
			this.radExpiredDays.Name = "radExpiredDays";
			this.radExpiredDays.Size = new System.Drawing.Size(130, 19);
			this.radExpiredDays.TabIndex = 28;
			this.radExpiredDays.Text = "指定保质期天数";
			this.radExpiredDays.UseVisualStyleBackColor = true;
			this.radExpiredDays.CheckedChanged += new System.EventHandler(this.radExpiredDays_CheckedChanged);
			// 
			// radProductionDate
			// 
			this.radProductionDate.AutoSize = true;
			this.radProductionDate.Location = new System.Drawing.Point(18, 41);
			this.radProductionDate.Name = "radProductionDate";
			this.radProductionDate.Size = new System.Drawing.Size(85, 19);
			this.radProductionDate.TabIndex = 27;
			this.radProductionDate.TabStop = true;
			this.radProductionDate.Text = "指定日期";
			this.radProductionDate.UseVisualStyleBackColor = true;
			this.radProductionDate.CheckedChanged += new System.EventHandler(this.radProductionDate_CheckedChanged);
			// 
			// txtExpiredDays
			// 
			this.txtExpiredDays.Location = new System.Drawing.Point(510, 37);
			this.txtExpiredDays.Name = "txtExpiredDays";
			this.txtExpiredDays.Size = new System.Drawing.Size(72, 25);
			this.txtExpiredDays.TabIndex = 26;
			// 
			// dtProductionDate
			// 
			this.dtProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtProductionDate.Location = new System.Drawing.Point(115, 36);
			this.dtProductionDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
			this.dtProductionDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
			this.dtProductionDate.Name = "dtProductionDate";
			this.dtProductionDate.Size = new System.Drawing.Size(152, 25);
			this.dtProductionDate.TabIndex = 25;
			this.dtProductionDate.Value = new System.DateTime(2022, 4, 18, 0, 0, 0, 0);
			// 
			// numCodesQuantity
			// 
			this.numCodesQuantity.Location = new System.Drawing.Point(114, 61);
			this.numCodesQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.numCodesQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCodesQuantity.Name = "numCodesQuantity";
			this.numCodesQuantity.Size = new System.Drawing.Size(91, 23);
			this.numCodesQuantity.TabIndex = 13;
			this.numCodesQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 66);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 14);
			this.label3.TabIndex = 12;
			this.label3.Text = "条码数量";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 14);
			this.label2.TabIndex = 10;
			this.label2.Text = "打印机";
			// 
			// listPrinter
			// 
			this.listPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.listPrinter.FormattingEnabled = true;
			this.listPrinter.Location = new System.Drawing.Point(114, 21);
			this.listPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.listPrinter.Name = "listPrinter";
			this.listPrinter.Size = new System.Drawing.Size(469, 22);
			this.listPrinter.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 632);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "国外产品中文标签UDI打印 V20220415";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemplateFile;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkAutoPrint;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radExpiredDays;
		private System.Windows.Forms.RadioButton radProductionDate;
		private System.Windows.Forms.TextBox txtExpiredDays;
		private System.Windows.Forms.DateTimePicker dtProductionDate;
		private System.Windows.Forms.NumericUpDown numCodesQuantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox listPrinter;
	}
}

