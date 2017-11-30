namespace TestDenverModelV1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateLandUseScenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateGSFScenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDynamicScenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGA = new System.Windows.Forms.Label();
            this.labelGU = new System.Windows.Forms.Label();
            this.labelDU = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.labelGPCD = new System.Windows.Forms.Label();
            this.labelTD = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelOD = new System.Windows.Forms.Label();
            this.labelPA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxUseGSFVar = new System.Windows.Forms.CheckBox();
            this.textBoxLandUsePCT = new System.Windows.Forms.TextBox();
            this.textBoxGSFPCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUseLLUChange = new System.Windows.Forms.CheckBox();
            this.checkBoxUseGSFCHange = new System.Windows.Forms.CheckBox();
            this.comboBoxDUA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.testToolStripMenuItem.Text = "&Load Data";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateLandUseScenariosToolStripMenuItem,
            this.generateGSFScenariosToolStripMenuItem,
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem,
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem,
            this.generateDynamicScenariosToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // generateLandUseScenariosToolStripMenuItem
            // 
            this.generateLandUseScenariosToolStripMenuItem.Name = "generateLandUseScenariosToolStripMenuItem";
            this.generateLandUseScenariosToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.generateLandUseScenariosToolStripMenuItem.Text = "Generate Land Use Scenarios";
            this.generateLandUseScenariosToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateGSFScenariosToolStripMenuItem
            // 
            this.generateGSFScenariosToolStripMenuItem.Name = "generateGSFScenariosToolStripMenuItem";
            this.generateGSFScenariosToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.generateGSFScenariosToolStripMenuItem.Text = "Generate GSF Scenarios PCT Change";
            this.generateGSFScenariosToolStripMenuItem.Click += new System.EventHandler(this.generateGSFScenariosToolStripMenuItem_Click);
            // 
            // generateGSFVarianceAndChangeScenarioToolStripMenuItem
            // 
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem.Name = "generateGSFVarianceAndChangeScenarioToolStripMenuItem";
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem.Text = "Generate GSF Variance and Change Scenario";
            this.generateGSFVarianceAndChangeScenarioToolStripMenuItem.Click += new System.EventHandler(this.generateGSFVarianceAndChangeScenarioToolStripMenuItem_Click);
            // 
            // generateLUGSFVARAndGSFChngeToolStripMenuItem
            // 
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem.Name = "generateLUGSFVARAndGSFChngeToolStripMenuItem";
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem.Text = "Generate LU GSFVAR and GSF Chnge";
            this.generateLUGSFVARAndGSFChngeToolStripMenuItem.Click += new System.EventHandler(this.generateLUGSFVARAndGSFChngeToolStripMenuItem_Click);
            // 
            // generateDynamicScenariosToolStripMenuItem
            // 
            this.generateDynamicScenariosToolStripMenuItem.Name = "generateDynamicScenariosToolStripMenuItem";
            this.generateDynamicScenariosToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.generateDynamicScenariosToolStripMenuItem.Text = "Generate Dynamic Scenarios";
            this.generateDynamicScenariosToolStripMenuItem.Click += new System.EventHandler(this.generateDynamicScenariosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelGA);
            this.panel1.Controls.Add(this.labelGU);
            this.panel1.Controls.Add(this.labelDU);
            this.panel1.Controls.Add(this.labelAD);
            this.panel1.Controls.Add(this.labelGPCD);
            this.panel1.Controls.Add(this.labelTD);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelOD);
            this.panel1.Controls.Add(this.labelPA);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 339);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelGA
            // 
            this.labelGA.AutoSize = true;
            this.labelGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGA.Location = new System.Drawing.Point(237, 307);
            this.labelGA.Name = "labelGA";
            this.labelGA.Size = new System.Drawing.Size(66, 20);
            this.labelGA.TabIndex = 26;
            this.labelGA.Text = "labelGA";
            // 
            // labelGU
            // 
            this.labelGU.AutoSize = true;
            this.labelGU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGU.Location = new System.Drawing.Point(237, 266);
            this.labelGU.Name = "labelGU";
            this.labelGU.Size = new System.Drawing.Size(67, 20);
            this.labelGU.TabIndex = 25;
            this.labelGU.Text = "labelGU";
            // 
            // labelDU
            // 
            this.labelDU.AutoSize = true;
            this.labelDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDU.Location = new System.Drawing.Point(237, 231);
            this.labelDU.Name = "labelDU";
            this.labelDU.Size = new System.Drawing.Size(66, 20);
            this.labelDU.TabIndex = 24;
            this.labelDU.Text = "labelDU";
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAD.Location = new System.Drawing.Point(237, 10);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(65, 20);
            this.labelAD.TabIndex = 23;
            this.labelAD.Text = "labelAD";
            // 
            // labelGPCD
            // 
            this.labelGPCD.AutoSize = true;
            this.labelGPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPCD.Location = new System.Drawing.Point(237, 202);
            this.labelGPCD.Name = "labelGPCD";
            this.labelGPCD.Size = new System.Drawing.Size(88, 20);
            this.labelGPCD.TabIndex = 22;
            this.labelGPCD.Text = "labelGPCD";
            // 
            // labelTD
            // 
            this.labelTD.AutoSize = true;
            this.labelTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTD.Location = new System.Drawing.Point(237, 161);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(63, 20);
            this.labelTD.TabIndex = 21;
            this.labelTD.Text = "labelTD";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(237, 89);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(59, 20);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "labelID";
            // 
            // labelOD
            // 
            this.labelOD.AutoSize = true;
            this.labelOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOD.Location = new System.Drawing.Point(237, 126);
            this.labelOD.Name = "labelOD";
            this.labelOD.Size = new System.Drawing.Size(66, 20);
            this.labelOD.TabIndex = 19;
            this.labelOD.Text = "labelOD";
            // 
            // labelPA
            // 
            this.labelPA.AutoSize = true;
            this.labelPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPA.Location = new System.Drawing.Point(237, 49);
            this.labelPA.Name = "labelPA";
            this.labelPA.Size = new System.Drawing.Size(63, 20);
            this.labelPA.TabIndex = 18;
            this.labelPA.Text = "labelPA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Gallons Perr Acre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(39, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Gallons Per Unit";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Dwelling UNits";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Acres of Development";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "GPCD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Demand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Indoor Demand";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seasonal Demand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pervious Acres";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(363, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(337, 329);
            this.listBox1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1068, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // checkBoxUseGSFVar
            // 
            this.checkBoxUseGSFVar.AutoSize = true;
            this.checkBoxUseGSFVar.Location = new System.Drawing.Point(724, 70);
            this.checkBoxUseGSFVar.Name = "checkBoxUseGSFVar";
            this.checkBoxUseGSFVar.Size = new System.Drawing.Size(187, 17);
            this.checkBoxUseGSFVar.TabIndex = 7;
            this.checkBoxUseGSFVar.Text = "Use GSF Variance (Default Mean)";
            this.checkBoxUseGSFVar.UseVisualStyleBackColor = true;
            this.checkBoxUseGSFVar.CheckedChanged += new System.EventHandler(this.generateGSFVarianceAndChangeScenarioToolStripMenuItem_Click);
            // 
            // textBoxLandUsePCT
            // 
            this.textBoxLandUsePCT.Enabled = false;
            this.textBoxLandUsePCT.Location = new System.Drawing.Point(800, 142);
            this.textBoxLandUsePCT.Multiline = true;
            this.textBoxLandUsePCT.Name = "textBoxLandUsePCT";
            this.textBoxLandUsePCT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLandUsePCT.Size = new System.Drawing.Size(222, 84);
            this.textBoxLandUsePCT.TabIndex = 8;
            // 
            // textBoxGSFPCT
            // 
            this.textBoxGSFPCT.Enabled = false;
            this.textBoxGSFPCT.Location = new System.Drawing.Point(800, 292);
            this.textBoxGSFPCT.Multiline = true;
            this.textBoxGSFPCT.Name = "textBoxGSFPCT";
            this.textBoxGSFPCT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGSFPCT.Size = new System.Drawing.Size(222, 84);
            this.textBoxGSFPCT.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Land Use Movement (proportion)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "GSF Change (proportion. i.e., 0.1 is 90% of initial)";
            // 
            // checkBoxUseLLUChange
            // 
            this.checkBoxUseLLUChange.AutoSize = true;
            this.checkBoxUseLLUChange.Location = new System.Drawing.Point(724, 104);
            this.checkBoxUseLLUChange.Name = "checkBoxUseLLUChange";
            this.checkBoxUseLLUChange.Size = new System.Drawing.Size(193, 17);
            this.checkBoxUseLLUChange.TabIndex = 12;
            this.checkBoxUseLLUChange.Text = "Use Land Use Change (default .30)";
            this.checkBoxUseLLUChange.UseVisualStyleBackColor = true;
            this.checkBoxUseLLUChange.Click += new System.EventHandler(this.checkBoxUseLLUChange_Click);
            // 
            // checkBoxUseGSFCHange
            // 
            this.checkBoxUseGSFCHange.AllowDrop = true;
            this.checkBoxUseGSFCHange.AutoSize = true;
            this.checkBoxUseGSFCHange.Location = new System.Drawing.Point(724, 252);
            this.checkBoxUseGSFCHange.Name = "checkBoxUseGSFCHange";
            this.checkBoxUseGSFCHange.Size = new System.Drawing.Size(273, 17);
            this.checkBoxUseGSFCHange.TabIndex = 13;
            this.checkBoxUseGSFCHange.Text = "Use GSF (proportion of base) Change (default None)";
            this.checkBoxUseGSFCHange.UseVisualStyleBackColor = true;
            this.checkBoxUseGSFCHange.Click += new System.EventHandler(this.checkBoxUseGSFCHange_Click);
            this.checkBoxUseGSFCHange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxUseGSFCHange_MouseClick);
            // 
            // comboBoxDUA
            // 
            this.comboBoxDUA.FormattingEnabled = true;
            this.comboBoxDUA.Items.AddRange(new object[] {
            "Use Default",
            "5%",
            "Median",
            "95%"});
            this.comboBoxDUA.Location = new System.Drawing.Point(873, 388);
            this.comboBoxDUA.Name = "comboBoxDUA";
            this.comboBoxDUA.Size = new System.Drawing.Size(151, 21);
            this.comboBoxDUA.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DUA Value Default of Stats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDUA);
            this.Controls.Add(this.checkBoxUseGSFCHange);
            this.Controls.Add(this.checkBoxUseLLUChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGSFPCT);
            this.Controls.Add(this.textBoxLandUsePCT);
            this.Controls.Add(this.checkBoxUseGSFVar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelGA;
        private System.Windows.Forms.Label labelGU;
        private System.Windows.Forms.Label labelDU;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.Label labelGPCD;
        private System.Windows.Forms.Label labelTD;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelOD;
        private System.Windows.Forms.Label labelPA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateLandUseScenariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateGSFScenariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateGSFVarianceAndChangeScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateLUGSFVARAndGSFChngeToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxUseGSFVar;
        private System.Windows.Forms.TextBox textBoxLandUsePCT;
        private System.Windows.Forms.TextBox textBoxGSFPCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxUseLLUChange;
        private System.Windows.Forms.CheckBox checkBoxUseGSFCHange;
        private System.Windows.Forms.ToolStripMenuItem generateDynamicScenariosToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxDUA;
        private System.Windows.Forms.Label label5;
    }
}

