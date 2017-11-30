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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GallonsAcre = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GallonsUnit = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DwellingUnits = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AcresDevelopment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GPCD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalDemand = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IndoorDemand = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SeasonalDemand = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PerviousAcres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelGA = new System.Windows.Forms.Label();
            this.labelGU = new System.Windows.Forms.Label();
            this.labelDU = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.labelGPCD = new System.Windows.Forms.Label();
            this.labelTD = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelOD = new System.Windows.Forms.Label();
            this.labelPA = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 25);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "&Load Data";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.panel1.Controls.Add(this.GallonsAcre);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.GallonsUnit);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.DwellingUnits);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.AcresDevelopment);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.GPCD);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TotalDemand);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.IndoorDemand);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SeasonalDemand);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PerviousAcres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 335);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GallonsAcre
            // 
            this.GallonsAcre.AutoSize = true;
            this.GallonsAcre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallonsAcre.Location = new System.Drawing.Point(205, 307);
            this.GallonsAcre.Name = "GallonsAcre";
            this.GallonsAcre.Size = new System.Drawing.Size(60, 20);
            this.GallonsAcre.TabIndex = 17;
            this.GallonsAcre.Text = "label13";
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
            // GallonsUnit
            // 
            this.GallonsUnit.AutoSize = true;
            this.GallonsUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallonsUnit.Location = new System.Drawing.Point(205, 266);
            this.GallonsUnit.Name = "GallonsUnit";
            this.GallonsUnit.Size = new System.Drawing.Size(60, 20);
            this.GallonsUnit.TabIndex = 15;
            this.GallonsUnit.Text = "label15";
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
            // DwellingUnits
            // 
            this.DwellingUnits.AutoSize = true;
            this.DwellingUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DwellingUnits.Location = new System.Drawing.Point(205, 231);
            this.DwellingUnits.Name = "DwellingUnits";
            this.DwellingUnits.Size = new System.Drawing.Size(60, 20);
            this.DwellingUnits.TabIndex = 13;
            this.DwellingUnits.Text = "label17";
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
            // AcresDevelopment
            // 
            this.AcresDevelopment.AutoSize = true;
            this.AcresDevelopment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcresDevelopment.Location = new System.Drawing.Point(205, 10);
            this.AcresDevelopment.Name = "AcresDevelopment";
            this.AcresDevelopment.Size = new System.Drawing.Size(144, 20);
            this.AcresDevelopment.TabIndex = 11;
            this.AcresDevelopment.Text = "AcresDevelopment";
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
            // GPCD
            // 
            this.GPCD.AutoSize = true;
            this.GPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPCD.Location = new System.Drawing.Point(205, 202);
            this.GPCD.Name = "GPCD";
            this.GPCD.Size = new System.Drawing.Size(51, 20);
            this.GPCD.TabIndex = 9;
            this.GPCD.Text = "label9";
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
            // TotalDemand
            // 
            this.TotalDemand.AutoSize = true;
            this.TotalDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDemand.Location = new System.Drawing.Point(205, 161);
            this.TotalDemand.Name = "TotalDemand";
            this.TotalDemand.Size = new System.Drawing.Size(51, 20);
            this.TotalDemand.TabIndex = 7;
            this.TotalDemand.Text = "label7";
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
            // IndoorDemand
            // 
            this.IndoorDemand.AutoSize = true;
            this.IndoorDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndoorDemand.Location = new System.Drawing.Point(205, 89);
            this.IndoorDemand.Name = "IndoorDemand";
            this.IndoorDemand.Size = new System.Drawing.Size(51, 20);
            this.IndoorDemand.TabIndex = 5;
            this.IndoorDemand.Text = "label5";
            this.IndoorDemand.Click += new System.EventHandler(this.label5_Click);
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
            // SeasonalDemand
            // 
            this.SeasonalDemand.AutoSize = true;
            this.SeasonalDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonalDemand.Location = new System.Drawing.Point(205, 126);
            this.SeasonalDemand.Name = "SeasonalDemand";
            this.SeasonalDemand.Size = new System.Drawing.Size(51, 20);
            this.SeasonalDemand.TabIndex = 3;
            this.SeasonalDemand.Text = "label3";
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
            // PerviousAcres
            // 
            this.PerviousAcres.AutoSize = true;
            this.PerviousAcres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerviousAcres.Location = new System.Drawing.Point(205, 49);
            this.PerviousAcres.Name = "PerviousAcres";
            this.PerviousAcres.Size = new System.Drawing.Size(51, 20);
            this.PerviousAcres.TabIndex = 1;
            this.PerviousAcres.Text = "label2";
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
            // labelGA
            // 
            this.labelGA.AutoSize = true;
            this.labelGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGA.Location = new System.Drawing.Point(398, 307);
            this.labelGA.Name = "labelGA";
            this.labelGA.Size = new System.Drawing.Size(66, 20);
            this.labelGA.TabIndex = 26;
            this.labelGA.Text = "labelGA";
            // 
            // labelGU
            // 
            this.labelGU.AutoSize = true;
            this.labelGU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGU.Location = new System.Drawing.Point(398, 266);
            this.labelGU.Name = "labelGU";
            this.labelGU.Size = new System.Drawing.Size(67, 20);
            this.labelGU.TabIndex = 25;
            this.labelGU.Text = "labelGU";
            // 
            // labelDU
            // 
            this.labelDU.AutoSize = true;
            this.labelDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDU.Location = new System.Drawing.Point(398, 231);
            this.labelDU.Name = "labelDU";
            this.labelDU.Size = new System.Drawing.Size(66, 20);
            this.labelDU.TabIndex = 24;
            this.labelDU.Text = "labelDU";
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAD.Location = new System.Drawing.Point(398, 10);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(65, 20);
            this.labelAD.TabIndex = 23;
            this.labelAD.Text = "labelAD";
            // 
            // labelGPCD
            // 
            this.labelGPCD.AutoSize = true;
            this.labelGPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPCD.Location = new System.Drawing.Point(398, 202);
            this.labelGPCD.Name = "labelGPCD";
            this.labelGPCD.Size = new System.Drawing.Size(88, 20);
            this.labelGPCD.TabIndex = 22;
            this.labelGPCD.Text = "labelGPCD";
            // 
            // labelTD
            // 
            this.labelTD.AutoSize = true;
            this.labelTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTD.Location = new System.Drawing.Point(398, 161);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(63, 20);
            this.labelTD.TabIndex = 21;
            this.labelTD.Text = "labelTD";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(398, 89);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(59, 20);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "labelID";
            // 
            // labelOD
            // 
            this.labelOD.AutoSize = true;
            this.labelOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOD.Location = new System.Drawing.Point(398, 126);
            this.labelOD.Name = "labelOD";
            this.labelOD.Size = new System.Drawing.Size(66, 20);
            this.labelOD.TabIndex = 19;
            this.labelOD.Text = "labelOD";
            // 
            // labelPA
            // 
            this.labelPA.AutoSize = true;
            this.labelPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPA.Location = new System.Drawing.Point(398, 49);
            this.labelPA.Name = "labelPA";
            this.labelPA.Size = new System.Drawing.Size(63, 20);
            this.labelPA.TabIndex = 18;
            this.labelPA.Text = "labelPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label IndoorDemand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SeasonalDemand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PerviousAcres;
        private System.Windows.Forms.Label GallonsAcre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label GallonsUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label DwellingUnits;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label AcresDevelopment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label GPCD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalDemand;
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
    }
}

