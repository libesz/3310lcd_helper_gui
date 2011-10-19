namespace Nokia3310AvrHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loadButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.widthLabelValue = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reloadButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightLabelValue = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.pathLabelValue = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.yOffsetValueLabel = new System.Windows.Forms.Label();
            this.yOffsetLabel = new System.Windows.Forms.Label();
            this.xOffsetLabel = new System.Windows.Forms.Label();
            this.xOffsetValueLabel = new System.Windows.Forms.Label();
            this.xOffsetPButton = new System.Windows.Forms.Button();
            this.xOffsetNButton = new System.Windows.Forms.Button();
            this.yOffsetNButton = new System.Windows.Forms.Button();
            this.yOffsetPButton = new System.Windows.Forms.Button();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.liveCheckBox = new System.Windows.Forms.CheckBox();
            this.savePGMButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 146);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(93, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // widthLabelValue
            // 
            this.widthLabelValue.AutoSize = true;
            this.widthLabelValue.Location = new System.Drawing.Point(59, 9);
            this.widthLabelValue.Name = "widthLabelValue";
            this.widthLabelValue.Size = new System.Drawing.Size(13, 13);
            this.widthLabelValue.TabIndex = 1;
            this.widthLabelValue.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(134, 146);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(93, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 51);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height:";
            // 
            // heightLabelValue
            // 
            this.heightLabelValue.AutoSize = true;
            this.heightLabelValue.Location = new System.Drawing.Point(59, 51);
            this.heightLabelValue.Name = "heightLabelValue";
            this.heightLabelValue.Size = new System.Drawing.Size(13, 13);
            this.heightLabelValue.TabIndex = 4;
            this.heightLabelValue.Text = "0";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 130);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Path:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 9);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // pathLabelValue
            // 
            this.pathLabelValue.AutoSize = true;
            this.pathLabelValue.Location = new System.Drawing.Point(46, 130);
            this.pathLabelValue.Name = "pathLabelValue";
            this.pathLabelValue.Size = new System.Drawing.Size(31, 13);
            this.pathLabelValue.TabIndex = 7;
            this.pathLabelValue.Text = "none";
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.portComboBox.Location = new System.Drawing.Point(15, 106);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(60, 21);
            this.portComboBox.TabIndex = 8;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // yOffsetValueLabel
            // 
            this.yOffsetValueLabel.AutoSize = true;
            this.yOffsetValueLabel.Location = new System.Drawing.Point(59, 67);
            this.yOffsetValueLabel.Name = "yOffsetValueLabel";
            this.yOffsetValueLabel.Size = new System.Drawing.Size(13, 13);
            this.yOffsetValueLabel.TabIndex = 10;
            this.yOffsetValueLabel.Text = "0";
            // 
            // yOffsetLabel
            // 
            this.yOffsetLabel.AutoSize = true;
            this.yOffsetLabel.Location = new System.Drawing.Point(12, 67);
            this.yOffsetLabel.Name = "yOffsetLabel";
            this.yOffsetLabel.Size = new System.Drawing.Size(48, 13);
            this.yOffsetLabel.TabIndex = 9;
            this.yOffsetLabel.Text = "Y Offset:";
            // 
            // xOffsetLabel
            // 
            this.xOffsetLabel.AutoSize = true;
            this.xOffsetLabel.Location = new System.Drawing.Point(12, 25);
            this.xOffsetLabel.Name = "xOffsetLabel";
            this.xOffsetLabel.Size = new System.Drawing.Size(48, 13);
            this.xOffsetLabel.TabIndex = 12;
            this.xOffsetLabel.Text = "X Offset:";
            // 
            // xOffsetValueLabel
            // 
            this.xOffsetValueLabel.AutoSize = true;
            this.xOffsetValueLabel.Location = new System.Drawing.Point(59, 25);
            this.xOffsetValueLabel.Name = "xOffsetValueLabel";
            this.xOffsetValueLabel.Size = new System.Drawing.Size(13, 13);
            this.xOffsetValueLabel.TabIndex = 11;
            this.xOffsetValueLabel.Text = "0";
            // 
            // xOffsetPButton
            // 
            this.xOffsetPButton.Location = new System.Drawing.Point(88, 21);
            this.xOffsetPButton.Name = "xOffsetPButton";
            this.xOffsetPButton.Size = new System.Drawing.Size(20, 20);
            this.xOffsetPButton.TabIndex = 13;
            this.xOffsetPButton.Text = "+";
            this.xOffsetPButton.UseVisualStyleBackColor = true;
            this.xOffsetPButton.Click += new System.EventHandler(this.xOffsetPButton_Click);
            // 
            // xOffsetNButton
            // 
            this.xOffsetNButton.Location = new System.Drawing.Point(114, 21);
            this.xOffsetNButton.Name = "xOffsetNButton";
            this.xOffsetNButton.Size = new System.Drawing.Size(20, 20);
            this.xOffsetNButton.TabIndex = 14;
            this.xOffsetNButton.Text = "-";
            this.xOffsetNButton.UseVisualStyleBackColor = true;
            this.xOffsetNButton.Click += new System.EventHandler(this.xOffsetNButton_Click);
            // 
            // yOffsetNButton
            // 
            this.yOffsetNButton.Location = new System.Drawing.Point(114, 63);
            this.yOffsetNButton.Name = "yOffsetNButton";
            this.yOffsetNButton.Size = new System.Drawing.Size(20, 20);
            this.yOffsetNButton.TabIndex = 16;
            this.yOffsetNButton.Text = "-";
            this.yOffsetNButton.UseVisualStyleBackColor = true;
            this.yOffsetNButton.Click += new System.EventHandler(this.yOffsetNButton_Click);
            // 
            // yOffsetPButton
            // 
            this.yOffsetPButton.Location = new System.Drawing.Point(88, 63);
            this.yOffsetPButton.Name = "yOffsetPButton";
            this.yOffsetPButton.Size = new System.Drawing.Size(20, 20);
            this.yOffsetPButton.TabIndex = 15;
            this.yOffsetPButton.Text = "+";
            this.yOffsetPButton.UseVisualStyleBackColor = true;
            this.yOffsetPButton.Click += new System.EventHandler(this.yOffsetPButton_Click);
            // 
            // imgPanel
            // 
            this.imgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPanel.Location = new System.Drawing.Point(165, 10);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(170, 98);
            this.imgPanel.TabIndex = 17;
            this.imgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imgPanel_Paint);
            this.imgPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgPanel_MouseDown);
            this.imgPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgPanel_MouseMove);
            this.imgPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgPanel_MouseUp);
            // 
            // liveCheckBox
            // 
            this.liveCheckBox.AutoSize = true;
            this.liveCheckBox.Location = new System.Drawing.Point(82, 109);
            this.liveCheckBox.Name = "liveCheckBox";
            this.liveCheckBox.Size = new System.Drawing.Size(46, 17);
            this.liveCheckBox.TabIndex = 18;
            this.liveCheckBox.Text = "Live";
            this.liveCheckBox.UseVisualStyleBackColor = true;
            this.liveCheckBox.CheckedChanged += new System.EventHandler(this.liveCheckBox_CheckedChanged);
            // 
            // savePGMButton
            // 
            this.savePGMButton.Location = new System.Drawing.Point(254, 146);
            this.savePGMButton.Name = "savePGMButton";
            this.savePGMButton.Size = new System.Drawing.Size(93, 23);
            this.savePGMButton.TabIndex = 19;
            this.savePGMButton.Text = "Save PGM array";
            this.savePGMButton.UseVisualStyleBackColor = true;
            this.savePGMButton.Click += new System.EventHandler(this.savePGMButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 179);
            this.Controls.Add(this.savePGMButton);
            this.Controls.Add(this.liveCheckBox);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.yOffsetNButton);
            this.Controls.Add(this.yOffsetPButton);
            this.Controls.Add(this.xOffsetNButton);
            this.Controls.Add(this.xOffsetPButton);
            this.Controls.Add(this.xOffsetLabel);
            this.Controls.Add(this.xOffsetValueLabel);
            this.Controls.Add(this.yOffsetValueLabel);
            this.Controls.Add(this.yOffsetLabel);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.pathLabelValue);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.heightLabelValue);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.widthLabelValue);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "3310 LCD image preview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label widthLabelValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label heightLabelValue;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label pathLabelValue;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label yOffsetValueLabel;
        private System.Windows.Forms.Label yOffsetLabel;
        private System.Windows.Forms.Label xOffsetLabel;
        private System.Windows.Forms.Label xOffsetValueLabel;
        private System.Windows.Forms.Button xOffsetPButton;
        private System.Windows.Forms.Button xOffsetNButton;
        private System.Windows.Forms.Button yOffsetNButton;
        private System.Windows.Forms.Button yOffsetPButton;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.CheckBox liveCheckBox;
        private System.Windows.Forms.Button savePGMButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

