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
			this.label2 = new System.Windows.Forms.Label();
			this.listPrinter = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numCodesQuantity = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkAutoPrint = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtPlanQty = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.txtBatchNo = new System.Windows.Forms.TextBox();
			this.txt = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lstYear = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(17, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "模板文件";
			// 
			// txtTemplateFile
			// 
			this.txtTemplateFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtTemplateFile.Location = new System.Drawing.Point(105, 26);
			this.txtTemplateFile.Name = "txtTemplateFile";
			this.txtTemplateFile.ReadOnly = true;
			this.txtTemplateFile.Size = new System.Drawing.Size(487, 26);
			this.txtTemplateFile.TabIndex = 1;
			// 
			// btnFileOpen
			// 
			this.btnFileOpen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnFileOpen.Location = new System.Drawing.Point(598, 23);
			this.btnFileOpen.Name = "btnFileOpen";
			this.btnFileOpen.Size = new System.Drawing.Size(82, 33);
			this.btnFileOpen.TabIndex = 2;
			this.btnFileOpen.Text = "浏览...";
			this.btnFileOpen.UseVisualStyleBackColor = true;
			this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(33, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "打印机";
			// 
			// listPrinter
			// 
			this.listPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.listPrinter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listPrinter.FormattingEnabled = true;
			this.listPrinter.Location = new System.Drawing.Point(106, 22);
			this.listPrinter.Name = "listPrinter";
			this.listPrinter.Size = new System.Drawing.Size(490, 24);
			this.listPrinter.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(29, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "条码数量";
			// 
			// numCodesQuantity
			// 
			this.numCodesQuantity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.numCodesQuantity.Location = new System.Drawing.Point(105, 52);
			this.numCodesQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCodesQuantity.Name = "numCodesQuantity";
			this.numCodesQuantity.Size = new System.Drawing.Size(68, 26);
			this.numCodesQuantity.TabIndex = 9;
			this.numCodesQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTemplateFile);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnFileOpen);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(686, 64);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "打印模板";
			// 
			// btnPrint
			// 
			this.btnPrint.Enabled = false;
			this.btnPrint.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnPrint.Location = new System.Drawing.Point(29, 539);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(633, 35);
			this.btnPrint.TabIndex = 13;
			this.btnPrint.Text = "打印";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(106, 22);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(490, 24);
			this.comboBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(54, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "打印机";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(42, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "条码数量";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.numericUpDown1.Location = new System.Drawing.Point(105, 56);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(68, 26);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.numCodesQuantity);
			this.groupBox2.Controls.Add(this.listPrinter);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(12, 91);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(686, 104);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "打印机1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Controls.Add(this.numericUpDown1);
			this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox3.Location = new System.Drawing.Point(12, 201);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(686, 95);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "打印机2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(14, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 18);
			this.label6.TabIndex = 16;
			this.label6.Text = "扫描/输入";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(105, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(438, 29);
			this.textBox1.TabIndex = 17;
			// 
			// checkAutoPrint
			// 
			this.checkAutoPrint.AutoSize = true;
			this.checkAutoPrint.Checked = true;
			this.checkAutoPrint.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAutoPrint.Location = new System.Drawing.Point(574, 26);
			this.checkAutoPrint.Name = "checkAutoPrint";
			this.checkAutoPrint.Size = new System.Drawing.Size(94, 20);
			this.checkAutoPrint.TabIndex = 18;
			this.checkAutoPrint.Text = "自动打印";
			this.checkAutoPrint.UseVisualStyleBackColor = true;
			this.checkAutoPrint.CheckedChanged += new System.EventHandler(this.checkAutoPrint_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.checkAutoPrint);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox4.Location = new System.Drawing.Point(12, 313);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(686, 60);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "SN号录入";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtPlanQty);
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.comboBox3);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.comboBox2);
			this.groupBox5.Controls.Add(this.txtBatchNo);
			this.groupBox5.Controls.Add(this.txt);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.lstYear);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.dtDateTo);
			this.groupBox5.Controls.Add(this.dtDateFrom);
			this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox5.Location = new System.Drawing.Point(12, 387);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(686, 133);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "信息";
			// 
			// txtPlanQty
			// 
			this.txtPlanQty.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtPlanQty.Location = new System.Drawing.Point(386, 37);
			this.txtPlanQty.MaxLength = 4;
			this.txtPlanQty.Name = "txtPlanQty";
			this.txtPlanQty.Size = new System.Drawing.Size(75, 29);
			this.txtPlanQty.TabIndex = 29;
			this.txtPlanQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanQty_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(303, 46);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 14);
			this.label12.TabIndex = 28;
			this.label12.Text = "计划数量：";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(303, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 14);
			this.label11.TabIndex = 27;
			this.label11.Text = "产品规则：";
			this.label11.Visible = false;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(386, 122);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(294, 24);
			this.comboBox3.TabIndex = 26;
			this.comboBox3.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(22, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 14);
			this.label10.TabIndex = 25;
			this.label10.Text = "产品类别：";
			this.label10.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(105, 122);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(180, 24);
			this.comboBox2.TabIndex = 24;
			this.comboBox2.Visible = false;
			// 
			// txtBatchNo
			// 
			this.txtBatchNo.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtBatchNo.Location = new System.Drawing.Point(107, 36);
			this.txtBatchNo.MaxLength = 15;
			this.txtBatchNo.Name = "txtBatchNo";
			this.txtBatchNo.Size = new System.Drawing.Size(178, 29);
			this.txtBatchNo.TabIndex = 23;
			this.txtBatchNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBatchNo_MouseClick);
			this.txtBatchNo.TextChanged += new System.EventHandler(this.txtBatchNo_TextChanged);
			// 
			// txt
			// 
			this.txt.AutoSize = true;
			this.txt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt.Location = new System.Drawing.Point(24, 45);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(77, 14);
			this.txt.TabIndex = 22;
			this.txt.Text = "生产批号：";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(554, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 14);
			this.label9.TabIndex = 21;
			this.label9.Text = "年：";
			// 
			// lstYear
			// 
			this.lstYear.FormattingEnabled = true;
			this.lstYear.ItemHeight = 16;
			this.lstYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.lstYear.Location = new System.Drawing.Point(591, 61);
			this.lstYear.Name = "lstYear";
			this.lstYear.Size = new System.Drawing.Size(62, 52);
			this.lstYear.TabIndex = 20;
			this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(303, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 14);
			this.label8.TabIndex = 19;
			this.label8.Text = "失效日期：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(24, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 14);
			this.label7.TabIndex = 2;
			this.label7.Text = "生产日期：";
			// 
			// dtDateTo
			// 
			this.dtDateTo.CustomFormat = "yyyy-MM-dd";
			this.dtDateTo.Enabled = false;
			this.dtDateTo.Location = new System.Drawing.Point(386, 74);
			this.dtDateTo.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.dtDateTo.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
			this.dtDateTo.Name = "dtDateTo";
			this.dtDateTo.Size = new System.Drawing.Size(157, 26);
			this.dtDateTo.TabIndex = 18;
			// 
			// dtDateFrom
			// 
			this.dtDateFrom.CustomFormat = "yyyy-MM-dd";
			this.dtDateFrom.Location = new System.Drawing.Point(107, 74);
			this.dtDateFrom.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
			this.dtDateFrom.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
			this.dtDateFrom.Name = "dtDateFrom";
			this.dtDateFrom.Size = new System.Drawing.Size(178, 26);
			this.dtDateFrom.TabIndex = 1;
			this.dtDateFrom.ValueChanged += new System.EventHandler(this.dtDateFrom_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 590);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Bartender标签打印 V20240229 X64";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemplateFile;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listPrinter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCodesQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkAutoPrint;
        private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox lstYear;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtDateTo;
		private System.Windows.Forms.DateTimePicker dtDateFrom;
		private System.Windows.Forms.TextBox txtBatchNo;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox txtPlanQty;
		private System.Windows.Forms.Label label12;
	}
}

