using System;
using System.Windows.Forms;

namespace CSGOLauncher
{
    public partial class MainWindow : Form
    {
        private CSGOAttributes curCfg = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LauncherConfig.StoredConfiguration = this.curCfg;
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show(curCfg.GetComandLine());
#elif RELEASE
            curCfg.StartServer();
            this.Close();
#endif
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.curCfg = LauncherConfig.StoredConfiguration;

            curCfg.PublicIP = lPublicIP.Text = IPHelper.PublicIpAddress;
            curCfg.PrivateIP = lPrivateIP.Text = IPHelper.PrivateIpAddress;

            foreach (GameModes mode in (GameModes[])Enum.GetValues(typeof(GameModes)))
            {
                cbbGameMode.Items.Add(mode);
            }
            cbbGameMode.SelectedItem = curCfg.GameMode;

            cbUseConsole.Checked = curCfg.UseConsole;
            cbUseRcon.Checked = curCfg.UseRcon;
        }

        private void cbbGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            curCfg.GameMode = (GameModes)cbbGameMode.SelectedItem;
        }

        private void llNATHowTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IPHelper.NATHelper();
        }

        private void cbUseConsole_CheckedChanged(object sender, EventArgs e)
        {
            curCfg.UseConsole = (sender as CheckBox).Checked;
        }

        private void cbUseRcon_CheckedChanged(object sender, EventArgs e)
        {
            curCfg.UseRcon = (sender as CheckBox).Checked;
        }
    }
}
