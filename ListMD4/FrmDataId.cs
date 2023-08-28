using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ListMD4
{
    public partial class FrmDataId : Form
    {
        private string Endpoint;
        private string DataId;
        private string Json;

        public FrmDataId(string endpoint, string dataId)
        {
            InitializeComponent();

            this.Text = $"ListMD4 DataId Detalhes - {endpoint}|{dataId}";

            this.Endpoint = endpoint;
            this.DataId = dataId;
        }

        private void DataId_Load(object sender, EventArgs e)
        {
            label2.Text = Endpoint;
            label8.Text = DataId;
            label7.Text = "ROMAGBR - Romulo Brasil";
            label6.Text = "25/08/2023 12:42:23";

            List<string> colHeader = new List<string>() { "Coluna 1", "Coluna 2", "Coluna 3" };
            List<List<string>> rowList = new List<List<string>>();

            for (int i = 0; i < 50; i++)
            {
                rowList.Add(getRowValue());
            }

            DataTable dt = new DataTable();

            foreach (var item in colHeader)
            {
                dt.Columns.Add(item);
            }

            foreach (var oItem in rowList)
            {
                dt.Rows.Add(oItem.ToArray());
            }
            dataGridView1.DataSource = dt;

        }

        private List<string> getRowValue()
        {
            return new List<string>() { "cel1", "cel2", "cel3" };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmJson frmJson = new FrmJson(Json, Endpoint, DataId);
            frmJson.Show();
        }

        private void FrmDataId_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void FrmDataId_Resize(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Size.Height - 200;
        }
    }
}