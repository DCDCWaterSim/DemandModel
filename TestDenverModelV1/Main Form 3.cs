using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WaterDemandAgentClass;
using BuildingTypes;
using DenverDemandModel_v1;


namespace TestDenverModelV1
{
    public partial class Form1 : Form
    {
        BuildingTypeList BuildList = null;
        DenverWaterDemandModel DWDM;
        //DenverCommunity Community = null;
        
        

        double[] Population;

        public Form1()
        {
            InitializeComponent();

            DisplayValues();
        }

        void DisplayValues()
        {
          if(DWDM!=null)
          {
            double count = 0;
            double people = 0;
            double DA = 0.0;
            double PA = 0.0;
            double Units = 0.0;
           // double GU = 0.0;
            //double GA = 0.0;
            foreach (WaterDemandAgent WDA in DWDM.WaterDemandAgents)
            {
                if (WDA is HouseHoldWaterDemand)
                {

                    HouseHoldWaterDemand HHWD = (WDA as HouseHoldWaterDemand);
                    DA += HHWD.DevelopedAcres;
                    PA += HHWD.PerviousSqFt;
                    Units += HHWD.NumberOfHouseholds;
                    //GU += HHWD.TotalDemand;
                    //GA += HHWD.TotalDemand;
                    people += HHWD.HouseHoldSize * HHWD.NumberOfHouseholds;
                    count++;
                }
            }
            PA = PA / 43560;
            //GU = GU / Units;
            //GA = GA / DA / 325851;

            double AllDemand = DWDM.WaterDemandAgents.TotalAllDemand();
            labelAD.Text = DA.ToString();
            labelPA.Text = PA.ToString(); ;
            labelID.Text = (DWDM.WaterDemandAgents.TotalIndoorDemand() / 325851).ToString();
            labelOD.Text = (DWDM.WaterDemandAgents.TotalOutdoorDemand() / 325851).ToString();
            labelTD.Text = (AllDemand / 325851).ToString(); ;
            labelGPCD.Text = (AllDemand / people / 365).ToString();
            labelDU.Text = Units.ToString();
            labelGU.Text = (AllDemand / Units).ToString();
            labelGA.Text = (AllDemand / 325851 / DA).ToString();
          }
        }

        //
        // 10.25.17 das what is RAY doing here? Why are we adding only two of the building types?
        //
        void SetupCommunityModel()
        {
            BuildList = DWDM.BuildTypeList;

            {
                BuildingType BT = BuildList.FindByCode("LSF");
                if (BT!=null)
                {
                    DenverHouseholdData DHD = new DenverHouseholdData("LSF2.5_50","LSF","Low Single Family 2.5 Persons per Household 50 gallons Indoor GPCCD","LSF", 2.5, 350, 50, BT.GallonsPerSqFtPervious, BT.DwellinUnitsPerAcre);
                    HouseHoldWaterDemand HHWD = DHD.NewHousehold();
                    //double units = 350 / 2.5;
                    
                    //HouseHoldWaterDemand HHWD = new HouseHoldWaterDemand(BT, 2.5, units, 50);
                    DWDM.WaterDemandAgents.Add(HHWD);

                    BT = BuildList.FindByCode("HMF");
                    //units = 350 / 2.0;
                    if (BT != null)
                    {
                        DHD = new DenverHouseholdData("HMF2.0_50", "HMF", "High Density2.0 Persons per Household 50 gallons Indoor GPCCD", "HMF", 2.0, 350, 50, BT.GallonsPerSqFtPervious, BT.DwellinUnitsPerAcre);
                        HHWD = DHD.NewHousehold();
                        //HHWD = new HouseHoldWaterDemand(BT, 2.0, units, 50);
                        DWDM.WaterDemandAgents.Add(HHWD);
                    }
                }

            }
            DWDM.Run();
            listBox1.Items.Clear();
            listBox1.Items.Add(DWDM.WaterDemandAgents.ToFieldHeaderString("CSV"));
            listBox1.Items.Add(DWDM.WaterDemandAgents.ToString("CSV"));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
        
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filename = openFileDialog1.FileName;
                DWDM = new DenverWaterDemandModel(Filename);
                //BuildList = new BuildingTypeList(Filename);
                //Community = new DenverCommunity("DENVER", BuildList);

                SetupCommunityModel();
                DisplayValues();
                
            }
        }

        public void report(string Message, int MaxCnt, int Value)
        {
            toolStripStatusLabel1.Text = Message + ":" + Value.ToString() + " of " + MaxCnt.ToString();
            Application.DoEvents();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            RunLandUseScenarios();
        }

        public void RunGSFOnVarAndChangeScenarios()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();
                    string Filename = saveFileDialog1.FileName;
                    DemandScenarioList MyGSFScenarios = new DemandScenarioList();
                    double[] HighresChangeList = new double[61];
                    double change = 0;
                    for (int k=0; k<HighresChangeList.Length;k++)
                    {
                        HighresChangeList[k] = change;
                        change += .01;
                    }
                    double[] ChangeList = new double[] { 0, .1, .2, .3 };
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();

                    MyGSFScenarios = DWDM.GenerateGSFScenariosOnVarAndChange(HighresChangeList,1);

                    toolStripStatusLabel1.Text = "Running " + MyGSFScenarios.Count.ToString() + " Scenarios";
                    Application.DoEvents();


                    bool test = DWDM.RunScenario(MyGSFScenarios, FileFormat, Filename, report, 100, out errMsg);
                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Done";
                        Application.DoEvents();

                    }

                }

            }
        }
        public void RunGSFOnVarAndDUAScenarios()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();
                    string Filename = saveFileDialog1.FileName;
                    DemandScenarioList MyGSFScenarios = new DemandScenarioList();
                    double[] HighresChangeList = new double[61];
                    double change = 0;
                    for (int k = 0; k < HighresChangeList.Length; k++)
                    {
                        HighresChangeList[k] = change;
                        change += .01;
                    }
                    double[] ChangeList = new double[] { 0, .1, .2, .3 };
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();

                    MyGSFScenarios = DWDM.GenerateGSFScenariosOnVarAndChange(HighresChangeList, 1);

                    toolStripStatusLabel1.Text = "Running " + MyGSFScenarios.Count.ToString() + " Scenarios";
                    Application.DoEvents();


                    bool test = DWDM.RunScenario(MyGSFScenarios, FileFormat, Filename, report, 100, out errMsg);
                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Done";
                        Application.DoEvents();

                    }

                }

            }
        }
        public void RunGSFScenarios()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();
                    string Filename = saveFileDialog1.FileName;
                    DemandScenarioList MyGSFScenarios = new DemandScenarioList();
                    double[] ChangeList = new double[] {0, .1, .2, .3 };
                    toolStripStatusLabel1.Text = "Creating Scenarios";
                    Application.DoEvents();

                    MyGSFScenarios = DWDM.GenerateGSFScenariosOnPctChange(ChangeList);
                    
                    toolStripStatusLabel1.Text = "Running "+MyGSFScenarios.Count.ToString()+ " Scenarios";
                    Application.DoEvents();


                    bool test = DWDM.RunScenario(MyGSFScenarios, FileFormat, Filename, report, 100, out errMsg);
                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Done";
                        Application.DoEvents();

                    }

                }
        
            }            
        }
        //
      
        //
        public void RunLandUseScenarios()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string Filename = saveFileDialog1.FileName;
                    //double[] Options = new double[2];
                    //Options[0] = 0.1;
                    //Options[1] = 0.2;
                    double[] Options = new double[5];
                    Options[0] = 0.1;
                    Options[1] = 0.2;
                    Options[2] = 0.3;
                    Options[3] = 0.4;
                    Options[4] = 0.5;


                    toolStripStatusLabel1.Text = "Creating Scenarios";

                    // Generate the scenarios
                    // 
                    DemandScenarioList DSL = DWDM.GenerateLandScenarios(Options);
                    int SNCount = DSL.Count;
                    int AgCount = 0;
                    foreach (DemandScenario DS in DSL)
                    {
                        AgCount += DS.HouseholdList.Count;
                    }
                    label3.Text = "Scenarios " + SNCount.ToString() + "  Agents " + AgCount.ToString();
                    Application.DoEvents();

                    // Run the scenarios
                    bool test = DWDM.RunScenario(DSL, FileFormat, Filename, report, 100, out errMsg);

                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        // write documentation
                        
                    }
                    //string AllScnData = DWDM.RunScenario(DSL, "CSV", report, 100);
                }
            }
        }

        public void RunLUGSFandVar()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string Filename = saveFileDialog1.FileName;
                    //double[] Options = new double[2];
                    //Options[0] = 0.1;
                    //Options[1] = 0.2;
                    double[] Options = new double[1];
                    Options[0] = 0.3;


                    toolStripStatusLabel1.Text = "Creating Scenarios";

                    // Generate the scenarios
                    // 
                    DemandScenarioList DSL = DWDM.GenerateLandAndGSFScenarios(Options, true, null,-1);
                    int SNCount = DSL.Count;
                    int AgCount = 0;
                    foreach (DemandScenario DS in DSL)
                    {
                        AgCount += DS.HouseholdList.Count;
                    }
                    label3.Text = "Scenarios " + SNCount.ToString() + "  Agents " + AgCount.ToString();
                    Application.DoEvents();

                    // Run the scenarios
                    bool test = DWDM.RunScenario(DSL, FileFormat, Filename, report, 100, out errMsg);

                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        // write documentation

                    }
                    //string AllScnData = DWDM.RunScenario(DSL, "CSV", report, 100);
                }
            }
        }

        double[] GetValuesFromMultiLIneTextBox(TextBox TB, out int errN)
        {
            double[] result = null;

            string temp = TB.Text;
            List<string> Lines = new List<string>();
            string NewLine = Environment.NewLine;
            while (temp!="")
            {
                int NewLineIndex = temp.IndexOf(NewLine);
                string tempItem = "";
                if (NewLineIndex == -1)
                {
                    tempItem = temp;
                    temp = "";
                }
                else
                {
                    tempItem = temp.Substring(0, NewLineIndex);
                    if (temp.Length > NewLineIndex + 1)
                    {
                        temp = temp.Substring(NewLineIndex + 1);
                    }
                    else
                    {
                        temp = "";
                    }
                }

                Lines.Add(tempItem);
            }

            int cnt  = 0;
            errN = -1;
            List<double> GoodNumbers = new List<double>();
            foreach (string str in Lines)
            {
                if (str != "")
                {
                    try
                    {

                        double val = Convert.ToDouble(str);
                        GoodNumbers.Add(val);
                    }
                    catch (Exception ex)
                    {
                        errN = cnt;
                        // Ouch, just skip this number
                    }

                    cnt++;
                }
            }
            result = GoodNumbers.ToArray();
            return result;
        }

        void RunDynamicScenarios()
        {
            if (DWDM != null)
            {
                // prep for output
                string FileFormat = "CSV";
                string errMsg = "";
                saveFileDialog1.Filter = "CSV|*.csv";
                // open save dialog and run
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string Filename = saveFileDialog1.FileName;

                    bool UseGSFVar = checkBoxUseGSFVar.Checked;
                    bool UseGSFChnage = checkBoxUseGSFCHange.Checked;
                    bool UseLandUse = checkBoxUseLLUChange.Checked;
                    //
                    
                    //
                    int ValueSelected = comboBoxDUA.SelectedIndex;
                    int DUASelector = ValueSelected - 1;
                    int ErrNumber = -1;
                    double[] Options = null;
                    if (UseLandUse)
                    {
                        double[] TempList = GetValuesFromMultiLIneTextBox(textBoxLandUsePCT, out ErrNumber);
                        if (TempList.Length > 0)
                        {
                            Options = TempList;
                        }
                    }
                    else
                    {
                        Options = new double[1];
                        Options[0] = .30;
                    }

                    double[] GSFCHangeLIst = null;
                    if (UseGSFChnage)
                    {
                        double[] TempList = GetValuesFromMultiLIneTextBox(textBoxGSFPCT, out ErrNumber);
                        if (TempList.Length > 0)
                        {
                            GSFCHangeLIst = TempList;
                        }
                    }
                    
                    toolStripStatusLabel1.Text = "Creating Dynamic Scenarios";

                    // Generate the scenarios
                    // 
                    //DemandScenarioList DSL = DWDM.GenerateLandAndGSFScenarios(Options, UseGSFVar, GSFCHangeLIst, DUASelector);
                    DemandScenarioList DSL = DWDM.GenerateLandAndGSFScenarios(Options, UseGSFVar, GSFCHangeLIst, DUASelector);
                    int SNCount = DSL.Count;
                    int AgCount = 0;
                    foreach (DemandScenario DS in DSL)
                    {
                        AgCount += DS.HouseholdList.Count;
                    }
                    label3.Text = "Scenarios " + SNCount.ToString() + "  Agents " + AgCount.ToString();
                    Application.DoEvents();

                    // Run the scenarios
                    bool test = DWDM.RunScenario(DSL, FileFormat, Filename, report, 100, out errMsg);

                    if (!test)
                    {
                        MessageBox.Show(errMsg);
                    }
                    else
                    {
                        // write documentation

                    }
                    //string AllScnData = DWDM.RunScenario(DSL, "CSV", report, 100);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunLandUseScenarios();
        }

        private void generateGSFScenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunGSFScenarios();
        }

        private void generateGSFVarianceAndChangeScenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunGSFOnVarAndChangeScenarios();
        }

        private void generateLUGSFVARAndGSFChngeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunLUGSFandVar();
        }


        private void SetGSFCHangeListBox()
        {
            textBoxGSFPCT.Enabled = !textBoxGSFPCT.Enabled;
        }
        private void checkBoxUseGSFCHange_Click(object sender, EventArgs e)
        {
            SetGSFCHangeListBox();
        }

        private void checkBoxUseGSFCHange_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void SetLandUseListBox()
        {
            textBoxLandUsePCT.Enabled = !textBoxLandUsePCT.Enabled;
        }
        private void checkBoxUseLLUChange_Click(object sender, EventArgs e)
        {
            SetLandUseListBox();
        }

        private void generateDynamicScenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunDynamicScenarios();
        }
    }
}
