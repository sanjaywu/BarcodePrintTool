namespace BarcodePrintTool
{
    partial class BarcodePrintTool
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
            this.InitprinterComboBox = new System.Windows.Forms.ComboBox();
            this.PrintLabNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitprinterComboBox
            // 
            this.InitprinterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitprinterComboBox.FormattingEnabled = true;
            this.InitprinterComboBox.Location = new System.Drawing.Point(12, 48);
            this.InitprinterComboBox.Name = "InitprinterComboBox";
            this.InitprinterComboBox.Size = new System.Drawing.Size(260, 20);
            this.InitprinterComboBox.TabIndex = 0;
            // 
            // PrintLabNum
            // 
            this.PrintLabNum.Location = new System.Drawing.Point(13, 108);
            this.PrintLabNum.Name = "PrintLabNum";
            this.PrintLabNum.Size = new System.Drawing.Size(259, 21);
            this.PrintLabNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择打印机:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "设置打印份数:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(101, 221);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(73, 73);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "打印";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(14, 163);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(258, 21);
            this.BarcodeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "条码号：";
            // 
            // BarcodePrintTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintLabNum);
            this.Controls.Add(this.InitprinterComboBox);
            this.Name = "BarcodePrintTool";
            this.Text = "BarcodePrintTool";
            this.Load += new System.EventHandler(this.BarcodePrintTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InitprinterComboBox;
        private System.Windows.Forms.TextBox PrintLabNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Label label3;
    }
}

