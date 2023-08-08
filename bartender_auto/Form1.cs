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
            try
            {
                engine = new Engine(true);
            }
            catch (PrintEngineException exception)
            {
                // If the engine is unable to start, a PrintEngineException will be thrown.
                MessageBox.Show(this, exception.Message, Application.ProductName);
                this.Close(); // Close this app. We cannot run without connection to an engine.
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

			setData_onlySerial();

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
		private void setData_longFormat()
		{
			//10304 219 19
			String sBarCode = "";
			const string BAR_CODE_DEMO = "10304 219 19";
			//1			+ 0304	+	Space	+ 219	+	Space	+	19
			//产品类别	+ 批号	+	空格	+ 序号	+	空格	+	19	
			string sProductClass = "";  //1 或 2
			string sBatchNo = "";       //0304
			string sSerialNum = "";     //219
			string sYear = "";          //19		
			sBarCode = textBox1.Text;
			if (sBarCode.Length != BAR_CODE_DEMO.Length)
			{
				MessageBox.Show("代码格式与系统预定义不一致!\n" + "应该使用如下格式：" + 
							BAR_CODE_DEMO + 
							"\n 产品类别	+ 批号	+	空格	+ 序号	+	空格	+	年	","JWMS提示");
			}
			else
			{
				sProductClass = textBox1.Text.Substring(0, 1);
				sBatchNo = textBox1.Text.Substring(1, 4);
				sSerialNum = textBox1.Text.Substring(6, 3);
				sYear = textBox1.Text.Substring(10, 2);

				format.SubStrings["LeiBie"].Value = sProductClass;
				format.SubStrings["PiHao"].Value = sBatchNo;
				format.SubStrings["XuHao"].Value = sSerialNum;
				format.SubStrings["Nian"].Value = sYear;

			}
		}
        private void setData_onlySerial()
        {
            //10304 219 19
            String sBarCode = "";
            const string BAR_CODE_DEMO = "1234567890";
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
    }
}
