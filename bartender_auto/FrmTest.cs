using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartenderStudy
{
	public partial class FrmTest : Form
	{
		public FrmTest()
		{
			InitializeComponent();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
            setData_longFormat();

        }
        private void setData_longFormat()
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
                return;
            }

            string sSnFirstChar = getSubString(sBarCode, 1, 1);
            string sSnBatchRight4Chars = getSubString(sBarCode, 2, 5);
            string sSnQty = getSubString(sBarCode, 6, 8);
            string sSnYear = getSubString(sBarCode, 9, 10);

            string sBatchNo = txtBatchNo.Text;
            if (sBatchNo.Length != 8)
            {
                MessageBox.Show("批次号长度应该是8位!\n", "JWMS提示");
                return;
            }
            string sBatchRight4Chars = getSubString(sBatchNo, 5, 8);
            string sBatchLeft3Chars = getSubString(sBatchNo, 1, 3);
            string sBatchYear = getSubString(sBatchNo, 4, 5);

            switch (sSnFirstChar)
            {
                case "2":
                    if (!sBatchLeft3Chars.Equals("211"))
                    {
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return;
                    }
                    break;
                case "5":
                    if (!sBatchLeft3Chars.Equals("212"))
                    {
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return;
                    }
                    break;
                case "3":
                    if (!sBatchLeft3Chars.Equals("711"))
                    {
                        MessageBox.Show("序号第一个字符与批号的前三位对应错误!\n", "JWMS提示");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("序号第一个字符是未知类型!\n", "JWMS提示");
                    break;
            }
            if (!sSnBatchRight4Chars.Equals(sBatchRight4Chars))
            {
                MessageBox.Show("序号第2~5位字符与批号最后4位字符对应错误!\n", "JWMS提示");
                return;
            }
            if (!sSnYear.Equals(sBatchYear))
            {
                MessageBox.Show("序号第9~10位字符与批号4~5位字符对应错误!\n", "JWMS提示");
                return;
            }
            try
            {
                int iSnQty = Int32.Parse(sSnQty);
                if (!txtPlanQty.Text.Equals(""))
                {
                    MessageBox.Show("计划数量不能为空！\n", "JWMS提示");
                    return;
                }
                if (iSnQty > Int32.Parse(txtPlanQty.Text))
                {
                    MessageBox.Show("序号字符6~8位的流水号不能超过计划数量！\n", "JWMS提示");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("序号第6~8位字符的流水号不是数字！\n", "JWMS提示");
                return;
            }

            //format.SubStrings["pihao"].Value = sBatchNo;
            //format.SubStrings["shengchanriqi"].Value = dtDateFrom.Value.ToString("yyyy-MM-dd");
            //format.SubStrings["xuhao"].Value = sBarCode;
            //format.SubStrings["youxiaoqi"].Value = dtDateTo.Value.ToString("yyyy-MM-dd");
            //Log.LogPrint(sBarCode);
            Log.LogPrint(sBatchNo + " " + dtDateFrom.Value.ToString("yyyy-MM-dd") + " " + dtDateFrom.Value.ToString("yyyy-MM-dd") + " " + sBarCode);
        }
        /// <summary>
        /// 按位号截取字符串。 （1234567 ，2,4） -》2,3,4
        /// </summary>
        /// <param name="sText"></param>
        /// <param name="startNo"></param>
        /// <param name="iEndNo"></param>
        /// <returns></returns>
        private string getSubString(string sText, int startNo, int iEndNo)
        {
            return sText.Substring(startNo - 1, iEndNo - startNo + 1);

        }
    }
}
