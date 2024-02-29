using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BartenderStudy
{
    public partial class Form1 : Form
    {
        private Engine engine = null; // The BarTender Print Engine
        private LabelFormatDocument format = null; // The currently open Format
        private List<string> listCodes;
        private string previewPath = ""; // The path to the folder where the previews will be exported.
        private Messages messages;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtDateFrom.Format = DateTimePickerFormat.Custom;
            dtDateFrom.CustomFormat = "yyyy-MM-dd";
            dtDateTo.Format = DateTimePickerFormat.Custom;
            dtDateTo.CustomFormat = "yyyy-MM-dd";
            
            lstYear.SetSelected(1,true);
            
            try
            {
                engine = new Engine(true);
            }
            catch (PrintEngineException exception)
            {
                // If the engine is unable to start, a PrintEngineException will be thrown.
                MessageBox.Show(this, exception.Message, Application.ProductName);
                //this.Close(); // Close this app. We cannot run without connection to an engine.
                return;
            }

            //打印机列表
            Printers printers = new Printers();
            foreach (Printer printer in printers)
            {
                listPrinter.Items.Add(printer.PrinterName);
                comboBox1.Items.Add(printer.PrinterName);
            }

            if (printers.Count > 0)
            {
                // Automatically select the default printer.
                listPrinter.SelectedItem = printers.Default.PrinterName;
            }

            listCodes = new List<string>();
            txtTemplateFile.Text = Application.StartupPath + "\\" + "bartenderTest.btw";

            if(File.Exists(txtTemplateFile.Text))
            {
                format = engine.Documents.Open(txtTemplateFile.Text);

            }

            //创建临时文件夹
            // Create a temporary folder to hold the images.
            string tempPath = Path.GetTempPath(); // Something like "C:\Documents and Settings\<username>\Local Settings\Temp\"
            string newFolder;

            // It's not likely we'll have a path that already exists, but we'll check for it anyway.
            do
            {
                newFolder = Path.GetRandomFileName();
                previewPath = tempPath + newFolder; // newFolder is something crazy like "gulvwdmt.3r4"
            } while (Directory.Exists(previewPath));
            Directory.CreateDirectory(previewPath);
            
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = "btw";
                dlg.Filter = "Bartender模板文件(*.btw)|*.btw";

                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    txtTemplateFile.Text = dlg.FileName;
                    

                    if(OpenBtw())
                    {
                       
                        textBox1.Enabled = true;
                    }
                }
            }
            
        }

        private bool OpenBtw()
        {
            string errorMessage = "";

            try
            {
                if (format != null)
                    format.Close(SaveOptions.DoNotSaveChanges);
                format = engine.Documents.Open(txtTemplateFile.Text);

                return true;
            }
            catch (System.Runtime.InteropServices.COMException comException)
            {
                errorMessage = String.Format("Unable to open format: {0}\nReason: {1}", txtTemplateFile.Text, comException.Message);
                format = null;
                MessageBox.Show(this, errorMessage, "出现错误");

                return false;
            }
        }

       

       


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (engine != null)
                engine.Stop(SaveOptions.DoNotSaveChanges);

            // Remove the temporary path and all the images.
            if (previewPath.Length != 0)
                Directory.Delete(previewPath, true);
        }

        private void OnPrintCodes(List<string> codes)
        {
            Cursor.Current = Cursors.WaitCursor;

			//format.SubStrings["xuhao"].Value = textBox1.Text;

			//setData_onlySerial();
			if (!setData_longFormat())
			{
               
                return;
			}

            // Get the printer from the dropdown and assign it to the format.

            if (listPrinter.SelectedItem != null)
                format.PrintSetup.PrinterName = listPrinter.SelectedItem.ToString();
            Messages messages;
            //int waitForCompletionTimeout = 10000; // 10 seconds
            format.PrintSetup.IdenticalCopiesOfLabel = Convert.ToInt32(numCodesQuantity.Value);
            //format.PrintSetup.NumberOfSerializedLabels=1;
            Result result = format.Print(Application.ProductName, out messages);//开始打印

            string messageString = "\n\nMessages:";

            foreach (Seagull.BarTender.Print.Message message in messages)
            {
                messageString += "\n\n" + message.Text;
            }

            if (result == Result.Failure)
                MessageBox.Show(this, "Print Failed" + messageString, Application.ProductName);

            Cursor.Current = Cursors.Default;

             Cursor.Current = Cursors.WaitCursor;

            // Get the printer from the dropdown and assign it to the format.
            if (listPrinter.SelectedItem != null)
                format.PrintSetup.PrinterName = comboBox1.SelectedItem.ToString();
            format.PrintSetup.IdenticalCopiesOfLabel = Convert.ToInt32(numericUpDown1.Value);
            //format.PrintSetup.NumberOfSerializedLabels=1;
            Result result1 = format.Print(Application.ProductName, out messages);//开始打印

            string messageString1 = "\n\nMessages:";

            foreach (Seagull.BarTender.Print.Message message in messages)
            {
                messageString += "\n\n" + message.Text;
            }

            if (result == Result.Failure)
                MessageBox.Show(this, "Print Failed" + messageString, Application.ProductName);
            textBox1.Clear();
            Cursor.Current = Cursors.Default;
        }


       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            OnPrintCodes(listCodes);
            //setData_longFormat();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkAutoPrint.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBox1.Focused)
                    {
                        if (!string.IsNullOrEmpty(textBox1.Text))
                        {
                                OnPrintCodes(listCodes);    
                        }

                    }
                    else
                    {
                        textBox1.SelectAll();
                        textBox1.Focus();
                    }


                }
            }

        }

        private void checkAutoPrint_CheckedChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = !checkAutoPrint.Checked;
        }

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			

		}
		private Boolean setData_longFormat()
		{
			//10304 219 19
			String sBarCode = "";
			const string BAR_CODE_DEMO = "1030421919";
			//1			+ 0304	+	 219	+		19
			//产品类别	+ 批号	+ 序号		+	19	
			//string sProductClass = "";  //1 或 2
			//string sBatchPart = "";       //0304
			//string sSerialNum = "";     //219
			//string sYear = "";          //19		
			sBarCode = textBox1.Text;
			if (sBarCode.Length != BAR_CODE_DEMO.Length)
			{
                MessageBox.Show("序列号长度应该是10位!\n", "JWMS提示");
                return false;
            }

            string sSnFirstChar = getSubString(sBarCode, 1, 1);
            string sSnBatchRight4Chars = getSubString(sBarCode, 2, 5);
            string sSnQty = getSubString(sBarCode, 6, 8);
            string sSnYear = getSubString(sBarCode, 9, 10);
            int iBatchAdd1 = 0; //补充位数
            string sBatchNo = txtBatchNo.Text;
			if (!(sBatchNo.Length == 9 || sBatchNo.Length == 10))
			{
                MessageBox.Show("批次号长度应该是9位或10位数!\n", "JWMS提示");
                return false;
            }
			if (sBatchNo.Length == 10)
			{
                iBatchAdd1 = 1;
            }
            string sBatchRight4Chars = getSubString(sBatchNo, 6+ iBatchAdd1, 9+ iBatchAdd1);
            string sBatchLeft3Chars = getSubString(sBatchNo, 1+ iBatchAdd1, 3+ iBatchAdd1);
            string sBatchYear = getSubString(sBatchNo, 4+ iBatchAdd1, 5+ iBatchAdd1);

			switch (sSnFirstChar)
			{
                case "2":
					if (!sBatchLeft3Chars.Equals("211"))
					{
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return false;
                    }
                    break;
                case "5":
                    if (!sBatchLeft3Chars.Equals("212"))
                    {
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return false;
                    }
                    break;
                case "3":
                    if (!sBatchLeft3Chars.Equals("711"))
                    {
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return false;
                    }
                    break;
                case "9":
                  
                    break;
                default:                     
                    MessageBox.Show("序号第一个字符是未知类型!\n", "JWMS提示");
                    break;
            }
            if (!sSnBatchRight4Chars.Equals(sBatchRight4Chars))
            {
                MessageBox.Show("序号第2~5位字符与批号最后4位字符对应错误!\n", "JWMS提示");
                return false;
            }
            if (!sSnYear.Equals(sBatchYear))
            {
                MessageBox.Show("序号第9~10位字符与批号4~5位字符对应错误!\n", "JWMS提示");
                return false;
            }
			try {
                int iSnQty = Int32.Parse(sSnQty);
				if (txtPlanQty.Text.Equals(""))
				{
                    MessageBox.Show("计划数量不能为空！\n", "JWMS提示");
                    return false;
                }
                if (iSnQty> Int32.Parse(txtPlanQty.Text))
                {
                    MessageBox.Show("序号字符6~8位的流水号不能超过计划数量！\n", "JWMS提示");
                    return false;
                }
            }
			catch
			{
                MessageBox.Show("序号第6~8位字符的流水号不是数字！\n", "JWMS提示");
                return false;
            }
            
            format.SubStrings["pihao"].Value = sBatchNo;
			format.SubStrings["shengchanriqi"].Value = dtDateFrom.Value.ToString("yyyy-MM-dd");
			format.SubStrings["xuhao"].Value = sBarCode;
			format.SubStrings["youxiaoqi"].Value = dtDateTo.Value.ToString("yyyy-MM-dd");
            //Log.LogPrint(sBarCode);
            Log.LogPrint(sBatchNo+" " + dtDateFrom.Value.ToString("yyyy-MM-dd") + " "+ dtDateTo.Value.ToString("yyyy-MM-dd") + " "+ sBarCode);
            return true;
        }
        /// <summary>
        /// 按位号截取字符串。 （1234567 ，2,4） -》2,3,4
        /// </summary>
        /// <param name="sText"></param>
        /// <param name="startNo"></param>
        /// <param name="iEndNo"></param>
        /// <returns></returns>
        private string  getSubString(string sText,int startNo,int iEndNo)
		{            
            return sText.Substring(startNo-1, iEndNo - startNo +1);

        }
        private void setData_onlySerial()
        {
            //10304 219 19
            String sBarCode = "";
            const string BAR_CODE_DEMO = "1234567890";
            string sBatchNo = "";    //9位数
            //1			+ 0304	+	Space	+ 219	+	Space	+	19
            //产品类别	+ 批号	+	空格	+ 序号	+	空格	+	19	
            //string sProductClass = "";  //1 或 2
            //string sBatchNo = "";       //0304
            string sSerialNum = "";     //219
            //string sYear = "";          //19		
            sBarCode = textBox1.Text;
            if (sBarCode.Length != BAR_CODE_DEMO.Length)
            {
                MessageBox.Show("代码应该是10位序号!\n" , "JWMS提示");
            }
            else
            {                            
                sSerialNum = sBarCode;              
                format.SubStrings["xuhao"].Value = sSerialNum;             
            }
        }



		private void lstYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateDateTo();
			//MessageBox.Show(lstYear.SelectedItem.ToString());            
		}
        //更新失效日期
        void updateDateTo()
		{
            DateTime.TryParse(textBox1.Text, out DateTime dt);
            //dtDateTo.Value = dtDateFrom.Value.AddYears(int.Parse(lstYear.SelectedItem.ToString())).AddDays(-1);
            if (IsLeapYear(dtDateFrom.Value.Year) && dtDateFrom.Value.Month == 2 && dtDateFrom.Value.Day == 29)
            {
                dtDateTo.Value = dtDateTo.Value.AddDays(1);
            }
        }
        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void dtDateFrom_ValueChanged(object sender, EventArgs e)
		{
			updateDateTo();
		}

		private void txtPlanQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
			{
                e.Handled = true;
			}
		}

		private void txtBatchNo_TextChanged(object sender, EventArgs e)
		{
			if (txtBatchNo.Text.Length > 10)
			{
                txtBatchNo.ForeColor=Color.Red;
			}
			else
			{
                txtBatchNo.ForeColor = Color.Black;
            }
		}

		
        //to make batch scan override exists text
		private void txtBatchNo_MouseClick(object sender, MouseEventArgs e)
		{
            txtBatchNo.SelectAll();
        }
	}
}
