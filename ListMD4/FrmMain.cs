using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ListMD4
{
    public partial class FrmMain : Form
    {
        ConfigFile configFile;
        const string configFilePath = @"\ListMD4\list_md4.json";
        List<string> AllEndpoints = new List<string>();

        public FrmMain()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;

            InitializeComponent();

            this.Size = new Size(497, height - 50);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            LoadComponents();
        }
        private void LoadComponents()
        {
            string fullConfigFilePath = getFullConfigFilePath();


            if (!File.Exists(fullConfigFilePath))
            {
                createConfigFile(fullConfigFilePath);
            }

            configFile = loadConfigFile(fullConfigFilePath);

            cboAmbiente.Items.AddRange(configFile.Ambientes.ToArray());
            cboAmbiente.Text = configFile.cacheAmbiente;

            AutoCompleteStringCollection endpoints = new AutoCompleteStringCollection();
            endpoints.AddRange(configFile.Endpoints.ToArray());

            txtEndpoint.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtEndpoint.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEndpoint.AutoCompleteCustomSource = endpoints;
        }

        public string getFullConfigFilePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullConfigFilePath = path + configFilePath;

            return fullConfigFilePath;
        }

        private ConfigFile loadConfigFile(string fullConfigFilePath)
        {
            string json = File.ReadAllText(fullConfigFilePath);

            ConfigFile configFile = JsonConvert.DeserializeObject<ConfigFile>(json);

            return configFile;
        }

        private void createConfigFile(string path)
        {
            ConfigFile configFile = new ConfigFile();

            configFile.cacheAmbiente = "DEV";

            configFile.Ambientes = new List<string>() { "DEV", "HOM", "PRD" };

            configFile.Endpoints = new List<string>() {
                                                "ENDPOINT 1"
                                                , "ENDPOINT 2"
                                                , "ENDPOINT 3"
                                                };

            string jsonString = JsonConvert.SerializeObject(configFile);

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, jsonString);
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            tabControlListMD4.SelectedTab = tabResultado;

            treeViewEndpointsDataIds.Nodes.Clear();

            TreeNode rootNode = treeViewEndpointsDataIds.Nodes.Add("MD4");

            List<string> Endpoints = new List<string>() { };

            if (txtEndpoint.Text.Trim().Equals(""))
            {
                Endpoints.AddRange(configFile.Endpoints.ToArray());
            }
            else
            {
                Endpoints.AddRange(txtEndpoint.Text.Split(';').Where(e => e.Trim().Length > 0).Select(p => p.Trim()).ToList());
            }

            foreach (string endpoint in Endpoints)
            {
                rootNode.Nodes.Add(getNodes(endpoint));
            }

            rootNode.Expand();
        }

        public TreeNode getNodes(string nodeName)
        {
            List<TreeNode> child = new List<TreeNode>() { };

            for (int i = 0; i < 50; i++)
            {
                child.Add(new TreeNode("Curva" + i));
            }

            TreeNode node = new TreeNode(nodeName, child.ToArray());

            if (child.Count > 0 && !configFile.Endpoints.Contains(nodeName))
            {
                configFile.Endpoints.Add(nodeName);
            }

            return node;
        }

        private void treeViewEndpointsDataIds_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] nodeName = treeViewEndpointsDataIds.SelectedNode.FullPath.Split('\\');

            if (nodeName.Length < 3)
            {
                //MessageBox.Show("Node Invalido");
                return;
            }

            string endpoint = nodeName[1];
            string dataId = nodeName[2];

            FrmDataId frmDataId = new FrmDataId(endpoint, dataId);

            frmDataId.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string fullConfigFilePath = getFullConfigFilePath();

            //configFile.cacheTab = tabControlCadMD4.SelectedTab.Name;
            configFile.cacheAmbiente = cboAmbiente.SelectedItem.ToString();

            string jsonString = JsonConvert.SerializeObject(configFile);
            File.WriteAllText(fullConfigFilePath, jsonString);
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            tabControlListMD4.Size = new Size(445, (this.Size.Height - (120)));
            treeViewEndpointsDataIds.Size = new Size(396, (this.Size.Height - (180)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonTeste = @"[{""nome"":""marcos"", ""idade"":35, ""sexo"":""m""},{""nome"":""maria"", ""idade"":50, ""sexo"":""f""},{""nome"":""chiquinho"", ""idade"":17, ""sexo"":""m""}]";

            List<Dictionary<string, object>> fuck = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonTeste);

            List<string> headers = new List<string>();
            List<List<object>> rows = new List<List<object>>();

            headers.AddRange(fuck[0].Keys);

            for (int i = 1; i < fuck.Count; i++)
            {
                List<object> row = new List<object>();
                row.AddRange(fuck[i].Values);
                rows.Add(row);
            }
        }
    }
}
