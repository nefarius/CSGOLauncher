using System;
using System.Windows.Forms;
using System.Net.Sockets;

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
#else
            curCfg.StartServer();
            btnClose_Click(sender, e);
#endif
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.curCfg = LauncherConfig.StoredConfiguration;

            curCfg.PublicIP = lPublicIP.Text = IPHelper.PublicIpAddress;
            curCfg.PrivateIP = lPrivateIP.Text = IPHelper.PrivateIpAddress;
            cbTryUPnP.Checked = curCfg.UseUPnP;
            // On first run port number will be zero; set to default
            if (curCfg.Port > 0) tbPort.Text = curCfg.Port.ToString();
            else curCfg.Port = SRCDSAttributes.DefaultPort;

            foreach (GameModes mode in (GameModes[])Enum.GetValues(typeof(GameModes)))
            {
                cbbGameMode.Items.Add(mode);
            }
            cbbGameMode.SelectedItem = curCfg.GameMode;

            cbUseConsole.Checked = curCfg.UseConsole;
            cbUseRcon.Checked = curCfg.UseRcon;
            cbLanMode.Checked = curCfg.LanMode;

            tbMapGroup.Text = curCfg.MapGroup;
            tbMap.Text = curCfg.Map;
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

        private void tbMapGroup_TextChanged(object sender, EventArgs e)
        {
            curCfg.MapGroup = (sender as TextBox).Text;
        }

        private void tbMap_TextChanged(object sender, EventArgs e)
        {
            curCfg.Map = (sender as TextBox).Text;
        }

        private void cbLanMode_CheckedChanged(object sender, EventArgs e)
        {
            curCfg.LanMode = (sender as CheckBox).Checked;
        }

        private void cbTryUPnP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((curCfg.UseUPnP = (sender as CheckBox).Checked))
                {
                    if (UPnP.NAT.Discover())
                    {
                        lUPnPWANIP.Text = UPnP.NAT.ExternalIP.ToString();
                        if (!curCfg.LanMode)
                            UPnP.NAT.ForwardPort(curCfg.Port, ProtocolType.Udp, "CSGO-Server (Game)");
                        if (curCfg.UseRcon)
                            UPnP.NAT.ForwardPort(curCfg.Port, ProtocolType.Tcp, "CSGO-Server (RCON)");
                        lUPnPStat.Text = "OK";
                    }
                    else
                    {
                        lUPnPWANIP.Text = "Unable";
                        lUPnPStat.Text = "No device found";
                    }
                }
                else
                {
                    if (UPnP.NAT.Discover())
                    {
                        if (!curCfg.LanMode)
                            UPnP.NAT.DeleteForwardingRule(curCfg.Port, ProtocolType.Udp);
                        if (curCfg.UseRcon)
                            UPnP.NAT.DeleteForwardingRule(curCfg.Port, ProtocolType.Tcp);
                        lUPnPWANIP.Text = lUPnPStat.Text = "Unused";
                    }
                }
            }
            catch
            {
                lUPnPStat.Text = lUPnPWANIP.Text = "Error";
            }
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbPort_Validated(object sender, EventArgs e)
        {
            curCfg.Port = int.Parse((sender as TextBox).Text);
        }

        private void tbPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var tb = (sender as TextBox);
            int value = int.Parse(tb.Text);

            if (value < 1 || value > 65535)
            {
                e.Cancel = true;
                tb.Text = "27015";
            }
        }

        private void cbUpdatePublicIP_CheckedChanged(object sender, EventArgs e)
        {
            if ((curCfg.UpdatePublicIP = (sender as CheckBox).Checked))
            {
                curCfg.PublicIP = lPublicIP.Text = IPHelper.PublicIpAddress;
            }
        }
    }
}
