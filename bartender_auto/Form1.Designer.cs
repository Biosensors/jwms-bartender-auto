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
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "模板文件";
			// 
			// txtTemplateFile
			// 
			this.txtTemplateFile.Location = new System.Drawing.Point(79, 26);
			this.txtTemplateFile.Name = "txtTemplateFile";
			this.txtTemplateFile.ReadOnly = true;
			this.txtTemplateFile.Size = new System.Drawing.Size(240, 23);
			this.txtTemplateFile.TabIndex = 1;
			// 
			// btnFileOpen
			// 
			this.btnFileOpen.Location = new System.Drawing.Point(325, 26);
			this.btnFileOpen.Name = "btnFileOpen";
			this.btnFileOpen.Size = new System.Drawing.Size(57, 23);
			this.btnFileOpen.TabIndex = 2;
			this.btnFileOpen.Text = "浏览...";
			this.btnFileOpen.UseVisualStyleBackColor = true;
			this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "打印机";
			// 
			// listPrinter
			// 
			this.listPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.listPrinter.FormattingEnabled = true;
			this.listPrinter.Location = new System.Drawing.Point(114, 111);
			this.listPrinter.Name = "listPrinter";
			this.listPrinter.Size = new System.Drawing.Size(240, 20);
			this.listPrinter.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "条码数量";
			// 
			// numCodesQuantity
			// 
			this.numCodesQuantity.Location = new System.Drawing.Point(114, 142);
			this.numCodesQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCodesQuantity.Name = "numCodesQuantity";
			this.numCodesQuantity.Size = new System.Drawing.Size(68, 21);
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
			this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(388, 64);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "打印模板";
			// 
			// btnPrint
			// 
			this.btnPrint.Enabled = false;
			this.btnPrint.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnPrint.Location = new System.Drawing.Point(25, 348);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(365, 35);
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
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(114, 206);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(240, 20);
			this.comboBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "打印机";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 5;
			this.label5.Text = "条码数量";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(114, 237);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(68, 21);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(12, 91);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(388, 84);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "打印机1";
			// 
			// groupBox3
			// 
			this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox3.Location = new System.Drawing.Point(11, 182);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(388, 84);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "打印机2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 16;
			this.label6.Text = "扫描/输入";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(114, 295);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(151, 21);
			this.textBox1.TabIndex = 17;
			// 
			// checkAutoPrint
			// 
			this.checkAutoPrint.AutoSize = true;
			this.checkAutoPrint.Checked = true;
			this.checkAutoPrint.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAutoPrint.Location = new System.Drawing.Point(282, 298);
			this.checkAutoPrint.Name = "checkAutoPrint";
			this.checkAutoPrint.Size = new System.Drawing.Size(72, 16);
			this.checkAutoPrint.TabIndex = 18;
			this.checkAutoPrint.Text = "自动打印";
			this.checkAutoPrint.UseVisualStyleBackColor = true;
			this.checkAutoPrint.CheckedChanged += new System.EventHandler(this.checkAutoPrint_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox4.Location = new System.Drawing.Point(12, 272);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(388, 60);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "SN号录入";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 392);
			this.Controls.Add(this.checkAutoPrint);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.numCodesQuantity);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listPrinter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Bartender标签打印 V201905 X64";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numCodesQuantity)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
	}
}

