using System;
using System.Windows.Forms;

namespace MiniForms.Modules.NetworkIn
{
    public partial class DiaNetworkIn : Form
    {
        private readonly NetworkIn _networkIn;
        public DiaNetworkIn(NetworkIn networkIn)
        {
            InitializeComponent();
            _networkIn = networkIn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _networkIn.Port = txtPort.Text;
            Close();
        }

        private void DiaNetworkIn_Load(object sender, EventArgs e)
        {
            if (_networkIn.Port != null)
                txtPort.Text = _networkIn.Port;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
