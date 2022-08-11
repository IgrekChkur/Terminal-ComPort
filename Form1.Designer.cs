
namespace ComPort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnUpdatePorts = new System.Windows.Forms.Button();
            this.cBoxPorts = new System.Windows.Forms.ComboBox();
            this.gBoxProperties = new System.Windows.Forms.GroupBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblParityBits = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreamble = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCountTxData = new System.Windows.Forms.Label();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnClearTXData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxCharFormat = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxDecFormat = new System.Windows.Forms.CheckBox();
            this.chBoxBinFormat = new System.Windows.Forms.CheckBox();
            this.chBoxHexFormat = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.lblCountRxData = new System.Windows.Forms.Label();
            this.chBoxSaveToTxt = new System.Windows.Forms.CheckBox();
            this.cBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.btnClearRxData = new System.Windows.Forms.Button();
            this.tBoxReceiveData = new System.Windows.Forms.TextBox();
            this.gBoxProperties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnUpdatePorts
            // 
            this.btnUpdatePorts.Location = new System.Drawing.Point(2, 37);
            this.btnUpdatePorts.Name = "btnUpdatePorts";
            this.btnUpdatePorts.Size = new System.Drawing.Size(148, 54);
            this.btnUpdatePorts.TabIndex = 0;
            this.btnUpdatePorts.Text = "Обновить список портов";
            this.btnUpdatePorts.UseVisualStyleBackColor = true;
            this.btnUpdatePorts.Click += new System.EventHandler(this.btnUpdatePorts_Click);
            // 
            // cBoxPorts
            // 
            this.cBoxPorts.FormattingEnabled = true;
            this.cBoxPorts.Location = new System.Drawing.Point(156, 2);
            this.cBoxPorts.Name = "cBoxPorts";
            this.cBoxPorts.Size = new System.Drawing.Size(106, 28);
            this.cBoxPorts.TabIndex = 1;
            // 
            // gBoxProperties
            // 
            this.gBoxProperties.Controls.Add(this.checkBoxRTS);
            this.gBoxProperties.Controls.Add(this.checkBoxDTR);
            this.gBoxProperties.Controls.Add(this.cBoxParityBits);
            this.gBoxProperties.Controls.Add(this.cBoxStopBits);
            this.gBoxProperties.Controls.Add(this.cBoxDataBits);
            this.gBoxProperties.Controls.Add(this.cBoxBaudRate);
            this.gBoxProperties.Controls.Add(this.lblParityBits);
            this.gBoxProperties.Controls.Add(this.lblStopBits);
            this.gBoxProperties.Controls.Add(this.lblDataBits);
            this.gBoxProperties.Controls.Add(this.lblBaudRate);
            this.gBoxProperties.Location = new System.Drawing.Point(3, 97);
            this.gBoxProperties.Name = "gBoxProperties";
            this.gBoxProperties.Size = new System.Drawing.Size(259, 218);
            this.gBoxProperties.TabIndex = 2;
            this.gBoxProperties.TabStop = false;
            this.gBoxProperties.Text = "Properties ComPort";
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Location = new System.Drawing.Point(130, 187);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(104, 24);
            this.checkBoxRTS.TabIndex = 6;
            this.checkBoxRTS.Text = "RTS Enable";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBoxRTS_CheckedChanged);
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Location = new System.Drawing.Point(6, 187);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(107, 24);
            this.checkBoxDTR.TabIndex = 6;
            this.checkBoxDTR.Text = "DTR Enable";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(93, 153);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(151, 28);
            this.cBoxParityBits.TabIndex = 5;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxStopBits.Location = new System.Drawing.Point(93, 108);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(151, 28);
            this.cBoxStopBits.TabIndex = 5;
            this.cBoxStopBits.Text = "1";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(93, 63);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(151, 28);
            this.cBoxDataBits.TabIndex = 5;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(93, 20);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(151, 28);
            this.cBoxBaudRate.TabIndex = 5;
            this.cBoxBaudRate.Text = "9600";
            // 
            // lblParityBits
            // 
            this.lblParityBits.AutoSize = true;
            this.lblParityBits.Location = new System.Drawing.Point(0, 153);
            this.lblParityBits.Name = "lblParityBits";
            this.lblParityBits.Size = new System.Drawing.Size(73, 20);
            this.lblParityBits.TabIndex = 3;
            this.lblParityBits.Text = "Parity Bits";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(0, 108);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(68, 20);
            this.lblStopBits.TabIndex = 2;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(0, 63);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(69, 20);
            this.lblDataBits.TabIndex = 1;
            this.lblDataBits.Text = "Data Bits";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(0, 23);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(77, 20);
            this.lblBaudRate.TabIndex = 0;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 234);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(107, 33);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(156, 36);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(106, 53);
            this.progressBar.TabIndex = 4;
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 26);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(424, 160);
            this.tBoxDataOut.TabIndex = 5;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreamble);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnReadFile);
            this.groupBox1.Controls.Add(this.btnClearTXData);
            this.groupBox1.Controls.Add(this.tBoxDataOut);
            this.groupBox1.Controls.Add(this.btnSendData);
            this.groupBox1.Location = new System.Drawing.Point(268, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmitter Control";
            // 
            // btnPreamble
            // 
            this.btnPreamble.Location = new System.Drawing.Point(131, 192);
            this.btnPreamble.Name = "btnPreamble";
            this.btnPreamble.Size = new System.Drawing.Size(94, 36);
            this.btnPreamble.TabIndex = 10;
            this.btnPreamble.Text = "Preamble";
            this.btnPreamble.UseVisualStyleBackColor = true;
            this.btnPreamble.Click += new System.EventHandler(this.btnEncypt_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCountTxData);
            this.groupBox3.Controls.Add(this.lblDataOutLength);
            this.groupBox3.Location = new System.Drawing.Point(284, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 64);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // lblCountTxData
            // 
            this.lblCountTxData.AutoSize = true;
            this.lblCountTxData.Location = new System.Drawing.Point(124, 23);
            this.lblCountTxData.Name = "lblCountTxData";
            this.lblCountTxData.Size = new System.Drawing.Size(25, 20);
            this.lblCountTxData.TabIndex = 6;
            this.lblCountTxData.Text = "00";
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(0, 23);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(118, 20);
            this.lblDataOutLength.TabIndex = 6;
            this.lblDataOutLength.Text = "Data Out Length";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(8, 193);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(105, 35);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnClearTXData
            // 
            this.btnClearTXData.Location = new System.Drawing.Point(6, 273);
            this.btnClearTXData.Name = "btnClearTXData";
            this.btnClearTXData.Size = new System.Drawing.Size(107, 34);
            this.btnClearTXData.TabIndex = 7;
            this.btnClearTXData.Text = "Clear TxData";
            this.btnClearTXData.UseVisualStyleBackColor = true;
            this.btnClearTXData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chBoxCharFormat);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.chBoxSaveToTxt);
            this.groupBox2.Controls.Add(this.cBoxAddToOldData);
            this.groupBox2.Controls.Add(this.btnClearRxData);
            this.groupBox2.Controls.Add(this.tBoxReceiveData);
            this.groupBox2.Location = new System.Drawing.Point(710, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 313);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver Control";
            // 
            // chBoxCharFormat
            // 
            this.chBoxCharFormat.AutoSize = true;
            this.chBoxCharFormat.Location = new System.Drawing.Point(291, 212);
            this.chBoxCharFormat.Name = "chBoxCharFormat";
            this.chBoxCharFormat.Size = new System.Drawing.Size(112, 24);
            this.chBoxCharFormat.TabIndex = 14;
            this.chBoxCharFormat.Text = "Char Format";
            this.chBoxCharFormat.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxDecFormat);
            this.groupBox5.Controls.Add(this.chBoxBinFormat);
            this.groupBox5.Controls.Add(this.chBoxHexFormat);
            this.groupBox5.Location = new System.Drawing.Point(154, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 115);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Format";
            // 
            // chBoxDecFormat
            // 
            this.chBoxDecFormat.AutoSize = true;
            this.chBoxDecFormat.Location = new System.Drawing.Point(6, 85);
            this.chBoxDecFormat.Name = "chBoxDecFormat";
            this.chBoxDecFormat.Size = new System.Drawing.Size(108, 24);
            this.chBoxDecFormat.TabIndex = 0;
            this.chBoxDecFormat.Text = "Dec Format";
            this.chBoxDecFormat.UseVisualStyleBackColor = true;
            // 
            // chBoxBinFormat
            // 
            this.chBoxBinFormat.AutoSize = true;
            this.chBoxBinFormat.Location = new System.Drawing.Point(6, 55);
            this.chBoxBinFormat.Name = "chBoxBinFormat";
            this.chBoxBinFormat.Size = new System.Drawing.Size(103, 24);
            this.chBoxBinFormat.TabIndex = 0;
            this.chBoxBinFormat.Text = "Bin Format";
            this.chBoxBinFormat.UseVisualStyleBackColor = true;
            // 
            // chBoxHexFormat
            // 
            this.chBoxHexFormat.AutoSize = true;
            this.chBoxHexFormat.Location = new System.Drawing.Point(7, 27);
            this.chBoxHexFormat.Name = "chBoxHexFormat";
            this.chBoxHexFormat.Size = new System.Drawing.Size(108, 24);
            this.chBoxHexFormat.TabIndex = 0;
            this.chBoxHexFormat.Text = "Hex Format";
            this.chBoxHexFormat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDataInLength);
            this.groupBox4.Controls.Add(this.lblCountRxData);
            this.groupBox4.Location = new System.Drawing.Point(290, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 58);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Location = new System.Drawing.Point(0, 22);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(118, 20);
            this.lblDataInLength.TabIndex = 6;
            this.lblDataInLength.Text = "Data Out Length";
            // 
            // lblCountRxData
            // 
            this.lblCountRxData.AutoSize = true;
            this.lblCountRxData.Location = new System.Drawing.Point(116, 22);
            this.lblCountRxData.Name = "lblCountRxData";
            this.lblCountRxData.Size = new System.Drawing.Size(25, 20);
            this.lblCountRxData.TabIndex = 6;
            this.lblCountRxData.Text = "00";
            // 
            // chBoxSaveToTxt
            // 
            this.chBoxSaveToTxt.AutoSize = true;
            this.chBoxSaveToTxt.Location = new System.Drawing.Point(6, 199);
            this.chBoxSaveToTxt.Name = "chBoxSaveToTxt";
            this.chBoxSaveToTxt.Size = new System.Drawing.Size(132, 24);
            this.chBoxSaveToTxt.TabIndex = 11;
            this.chBoxSaveToTxt.Text = "Save To Txt File";
            this.chBoxSaveToTxt.UseVisualStyleBackColor = true;
            // 
            // cBoxAddToOldData
            // 
            this.cBoxAddToOldData.AutoSize = true;
            this.cBoxAddToOldData.Location = new System.Drawing.Point(6, 229);
            this.cBoxAddToOldData.Name = "cBoxAddToOldData";
            this.cBoxAddToOldData.Size = new System.Drawing.Size(143, 24);
            this.cBoxAddToOldData.TabIndex = 8;
            this.cBoxAddToOldData.Text = "Add To Old Data";
            this.cBoxAddToOldData.UseVisualStyleBackColor = true;
            // 
            // btnClearRxData
            // 
            this.btnClearRxData.Location = new System.Drawing.Point(6, 266);
            this.btnClearRxData.Name = "btnClearRxData";
            this.btnClearRxData.Size = new System.Drawing.Size(125, 41);
            this.btnClearRxData.TabIndex = 7;
            this.btnClearRxData.Text = "Clear RxData";
            this.btnClearRxData.UseVisualStyleBackColor = true;
            this.btnClearRxData.Click += new System.EventHandler(this.btnClearRxData_Click);
            // 
            // tBoxReceiveData
            // 
            this.tBoxReceiveData.Location = new System.Drawing.Point(6, 26);
            this.tBoxReceiveData.Multiline = true;
            this.tBoxReceiveData.Name = "tBoxReceiveData";
            this.tBoxReceiveData.Size = new System.Drawing.Size(436, 160);
            this.tBoxReceiveData.TabIndex = 5;
            this.tBoxReceiveData.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gBoxProperties);
            this.Controls.Add(this.cBoxPorts);
            this.Controls.Add(this.btnUpdatePorts);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMINAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxProperties.ResumeLayout(false);
            this.gBoxProperties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }
        public System.IO.Ports.SerialPort serialPort1;

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnUpdatePorts;
        private System.Windows.Forms.ComboBox cBoxPorts;
        private System.Windows.Forms.GroupBox gBoxProperties;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label lblParityBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountTxData;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Button btnClearTXData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountRxData;
        private System.Windows.Forms.TextBox tBoxReceiveData;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Button btnClearRxData;
        private System.Windows.Forms.CheckBox cBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxSaveToTxt;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPreamble;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxDecFormat;
        private System.Windows.Forms.CheckBox chBoxBinFormat;
        private System.Windows.Forms.CheckBox chBoxHexFormat;
        private System.Windows.Forms.CheckBox chBoxCharFormat;
    }
}

