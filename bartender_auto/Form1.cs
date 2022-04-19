using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        private List<EAN_GuiGe> aEAN_GuiGeList = new List<EAN_GuiGe>();   
        #region 获取String值
        /// <summary>
        /// 获取String值
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
            );
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        public void ReadSIniFile()
        {
            string iniFileName = AppDomain.CurrentDomain.BaseDirectory + "EAN规格对应表.ini";
            string section = "DATA";
            string key = "LIST";
            string defaultValue="";

            StringBuilder vRetSb = new StringBuilder(2048);		
            GetPrivateProfileString(section, key, defaultValue, vRetSb, 2048, iniFileName);
            string sFileValue= vRetSb.ToString();
            //MessageBox.Show(sFileValue);
            sFileValue=sFileValue.Replace("；", ";");
            sFileValue = sFileValue.Replace(" ", "");
            sFileValue = sFileValue.Replace(" ", "");
            String[] sArray = sFileValue.Split(";".ToCharArray());
            aEAN_GuiGeList.Clear();
            for(int i=0;i< sArray.Length; i++)
			{
				if (sArray[i].Length < 16)
				{
                    continue;
				}
                aEAN_GuiGeList.Add(new EAN_GuiGe {EAN=sArray[i].Substring(0,14),GuiGe= sArray[i].Substring(14) });
            }

            string aa = sFileValue;
        }
        public void ReadSIniFile_Test()
        {
            string iniFileName = AppDomain.CurrentDomain.BaseDirectory + "EAN规格对应表.ini";
            string section = "EAN规格对应表";
            string key = "url";
            string defaultValue = "";

            StringBuilder vRetSb = new StringBuilder(2048);
            GetPrivateProfileString(section, key, defaultValue, vRetSb, 2048, iniFileName);
            string sFileValue = vRetSb.ToString();
            MessageBox.Show(sFileValue);
            string aa = sFileValue;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtExpiredDays.Text = "";
            radExpiredDays.Checked = true;
            radExpiredDays_CheckedChanged(sender,e);
			ReadSIniFile();
			// ReadSIniFile_Test();
			String sGuiGe_EAN_List = "";
        
            //setData();
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
				//comboBox1.Items.Add(printer.PrinterName);
			}

			if (printers.Count > 0)
			{
				// Automatically select the default printer.
				listPrinter.SelectedItem = printers.Default.PrinterName;
			}

			listCodes = new List<string>();
			txtTemplateFile.Text = Application.StartupPath + "\\" + "bartenderTest.btw";

			if (File.Exists(txtTemplateFile.Text))
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
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = "btw";
                dlg.Filter = "Bartender模板文件(*.btw)|*.btw";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtTemplateFile.Text = dlg.FileName;


                    if (OpenBtw())
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

			if (!setData())
			{
                //核验错误，取消打印
                textBox1.Clear();
                Cursor.Current = Cursors.Default;
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
                MessageBox.Show(this, "打印失败：" + messageString, Application.ProductName);

            Cursor.Current = Cursors.Default;
            Cursor.Current = Cursors.WaitCursor;

          
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
        private void setData_序号()
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
                            "\n 产品类别	+ 批号	+	空格	+ 序号	+	空格	+	年	", "JWMS提示");
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

        private bool setData()
        {
            //textBox1.Text = "01088888930327881724010210W21120531G|21211213956";

            Barcode barcode = new Barcode();
            Barcode.Scanning scanning = barcode.getScanningObj();
            string sUDI = textBox1.Text;
            sUDI = barcode.replaceGSseparator(sUDI);
            scanning.fullScanCode = sUDI;
            scanning.valid = true;
            scanning.tmp_fullScanCode = sUDI;
            barcode.parseBarcode(scanning);
            barcode.checkInfoComplete(scanning);

            if (!scanning.valid)
            {
                MessageBox.Show("无效的UDI条码!", "JWMS提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }         
            
            string sSerialNum = scanning.serialNo;     //219
            string sBatchNo = scanning.BATCH;          //19		            
            string sEAN = scanning.EAN;          //19		

            string sTmpExpiredDate = "20" + scanning.BATCH_SLED.Substring(0, 2) + "-" + scanning.BATCH_SLED.Substring(2, 2) + "-" + scanning.BATCH_SLED.Substring(4, 2);
            DateTime dtTmp=DateTime.Parse(sTmpExpiredDate);
            string sExpiredDate = dtTmp.ToString("yyyy-MM-dd");      //
            string sProductionDate = getProductionDateString(dtTmp);          //19	
			if (sProductionDate == "")
			{
                MessageBox.Show("请先设置保质期天数!", "JWMS提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //String sGuiGe = sEAN;
			String sGuiGe = getGuiGe(sEAN);  //
			if (sGuiGe == "")
			{
				MessageBox.Show("未找到该产品规格，信息请检查程序目录下的配置文件《EAN规格对应表.ini》!", "JWMS提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

			//string aAA = "" + sEAN  + "--" + sSerialNum + "--" + sBatchNo + "--" + sProductionDate + "--" + sExpiredDate+ "---" + sGuiGe;
			// MessageBox.Show(aAA, "JWMS提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			format.SubStrings["EAN2"].Value = sEAN.Substring(0,13);    //EAN
            
            format.SubStrings["ggxh"].Value = sGuiGe;    //规格型号
			format.SubStrings["ph"].Value = sBatchNo;           //批号
			if (sSerialNum != "")
			{
				format.SubStrings["sn"].Value = sSerialNum;         //序列号
		    }
            

            format.SubStrings["scrq"].Value = sProductionDate;    //生产日期
			format.SubStrings["sxrq"].Value = sExpiredDate;         //失效日期
            return true;
        }
        private String getProductionDateString(DateTime ExpiredDate)
		{
            String productionDateString = "";
            if (radExpiredDays.Checked)
			{
				if (txtExpiredDays.Text == "")
				{
                    
                    return "";
				}
				else
				{
                    int aa = Int16.Parse(txtExpiredDays.Text);
                    productionDateString=ExpiredDate.AddDays(-1 * aa).ToString("yyyy-MM-dd");
				}             
			}
			else
			{
                productionDateString = dtProductionDate.Value.ToString("yyyy-MM-dd");

            }
            return productionDateString;
        }

        private String getGuiGe(String EAN)
		{
            String sGuige = "";
			foreach(EAN_GuiGe item in aEAN_GuiGeList)
			{
                if(item.EAN == EAN)
				{
                    sGuige = item.GuiGe;
                    break;
				}
			}
            return sGuige;
        }

		private void radExpiredDays_CheckedChanged(object sender, EventArgs e)
		{
            txtExpiredDays.Enabled = true;
            dtProductionDate.Enabled=false;
		}

		private void radProductionDate_CheckedChanged(object sender, EventArgs e)
		{
            txtExpiredDays.Enabled = false;
            dtProductionDate.Enabled = true;
        }
	}


    class EAN_GuiGe
    {
        public string EAN { get; set; } = "";
        public string GuiGe { get; set; } = "";
    }
}
