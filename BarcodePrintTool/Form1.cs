using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTender;

namespace BarcodePrintTool
{
    public partial class BarcodePrintTool : Form
    {
        private static BarTender.Application btApp = new BarTender.Application();
        private static BarTender.Format btFormat = new BarTender.Format();

        public BarcodePrintTool()
        {
            InitializeComponent();
        }

        private void BarcodePrintTool_Load(object sender, EventArgs e)
        {
            PrintLabNum.Text = "1";

            //获取打印机
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                InitprinterComboBox.Items.Add(printer);
            }
            InitprinterComboBox.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string sn_string = BarcodeTextBox.Text;

            InitprinterComboBox.Enabled = false;
            BarcodeTextBox.Enabled = false;
            PrintLabNum.Enabled = false;

            //判断两次SN号是否相等，若不相等则进行生成条形码和打印
            if (sn_string != string.Empty)
            {
                try
                {
                    btFormat = btApp.Formats.Open(AppDomain.CurrentDomain.BaseDirectory + "SN.btw", false, "");

                    //向bartender模板传递变量,SN为条形码数据的一个共享名称
                    btFormat.SetNamedSubStringValue("SN", sn_string);

                    //选择打印机
                    btFormat.Printer = InitprinterComboBox.Text;

                    //设置打印份数
                    int CopiesOfLabel = Int32.Parse(this.PrintLabNum.Text.ToString());
                    btFormat.IdenticalCopiesOfLabel = CopiesOfLabel;

                    //设置打印时是否跳出打印属性
                    btFormat.PrintOut(false, false);

                    //退出时是否保存标签
                    btFormat.Close(BarTender.BtSaveOptions.btSaveChanges);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误信息: " + ex.Message);
                    return;
                }
            }

            InitprinterComboBox.Enabled = true;
            BarcodeTextBox.Enabled = true;
            PrintLabNum.Enabled = true;
        }

        //界面退出时同步退出bartender进程
        private void Form_Stb_Sn_FormClosed(object sender, FormClosedEventArgs e)
        {
            btApp.Quit(BarTender.BtSaveOptions.btSaveChanges);
        }
    }
}
