using System.Windows.Forms;

namespace ListMD4
{
    public partial class FrmJson : Form
    {
        public FrmJson(string json, string endpoint, string dataId)
        {
            InitializeComponent();

            this.Text = $"ListMD4 Json - {endpoint}|{dataId}";

            textBox1.Text = json;
        }
    }
}
