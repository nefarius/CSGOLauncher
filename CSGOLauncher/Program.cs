using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSGOLauncher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // Load stored configuration
                CSGOAttributes curSrv = LauncherConfig.StoredConfiguration;
                if (curSrv.UpdatePublicIP)
                {
                    // Refresh IP information (may have changed since last run)
                    curSrv.PublicIP = IPHelper.PublicIpAddress;
                }
                curSrv.PrivateIP = IPHelper.PrivateIpAddress;
                // Launch SRCDS
                curSrv.StartServer();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
        }
    }
}
