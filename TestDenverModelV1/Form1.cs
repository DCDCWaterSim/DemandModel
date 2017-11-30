using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DenverDemandModel;
using WaterDemandAgentClass;
using BuildingTypes;
using WaterDemandAgentClass;

namespace TestDenverModelV1
{
    public partial class Form1 : Form
    {
        BuildingTypeList BuildList = null;
        CommunityWaterDemand Community = new CommunityWaterDemand("DENVER");

        
        DemandModel DM = new DemandModel();
        BuildingTypeWaterDemandModel BTDM = null;

        double[] Population;

        public Form1()
        {
            InitializeComponent();
            Population = DM.Population;

            Population[DemandModel.luLargeSF] = 700;
            Population[DemandModel.luTypicalSF] = 0;
            Population[DemandModel.luSmallSF] = 0;
            Population[DemandModel.luSmallMF] = 0;
            Population[DemandModel.luWalkupMF] = 0;
            Population[DemandModel.luMidMF] = 0;
            Population[DemandModel.luHighMF] = 0;

            displayValues();
        }

        void displayValues()
        {
            AcresDevelopment.Text = DM.TotalAcres().ToString();
            PerviousAcres.Text = DM.TotalEstimatedPerviousAcres().ToString();
            IndoorDemand.Text = DM.TotalAnnualIndoorDemand().ToString();
            SeasonalDemand.Text = DM.TotalAnnualSeasonalDemand().ToString();
            TotalDemand.Text = DM.TotalAnnualDemand().ToString();
            GPCD.Text = DM.AverageGPCD().ToString();
            DwellingUnits.Text = DM.TotalUnits().ToString();
            GallonsUnit.Text = DM.AverageAnnualGallonsPerUnit().ToString();
            GallonsAcre.Text = DM.AverageAnnualAcreFeetPerAcre().ToString();
        
            double count = 0;
            double people = 0;
            double DA = 0.0;
            double PA = 0.0;
            double Units = 0.0;
            double GU = 0.0;
            double GA = 0.0;
            foreach (WaterDemandAgent WDA in Community)
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

            double AllDemand = Community.TotalAllDemand();
            labelAD.Text = DA.ToString();
            labelPA.Text = PA.ToString(); ;
            labelID.Text = (Community.TotalIndoorDemand()/325851).ToString();
            labelOD.Text = (Community.TotalOutdoorDemand()/325851).ToString();
            labelTD.Text = (AllDemand / 325851).ToString(); ;
            labelGPCD.Text = (AllDemand / people / 365).ToString();
            labelDU.Text = Units.ToString();
            labelGU.Text = (AllDemand / Units).ToString();
            labelGA.Text = (AllDemand / 325851 / DA).ToString();

        }


        void SetupCommunityModel()
        {
            if (BuildList != null)
            {
                BuildingType BT = BuildList.FindByCode("LSF");
                if (BT!=null)
                {
                    double units = 700 / 2.5;
                    HouseHoldWaterDemand HHWD = new HouseHoldWaterDemand(BT, 2.5, units, 50);
                    Community.Add(HHWD);

                    //BT = BuildList.FindByCode("TSF");
                    //if (BT != null)
                    //{
                    //    BT = BuildList.FindByCode("TSF");
                    //    HHWD = new HouseHoldWaterDemand(BT, 2.5, units, 50);
                    //    Community.Add(HHWD);
                    //}
                }

            }
            Community.Run();
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
                BTDM = new BuildingTypeWaterDemandModel(Filename);

                BuildList = new BuildingTypeList(Filename);
                SetupCommunityModel();
                displayValues();

            }
        }
    }
}
