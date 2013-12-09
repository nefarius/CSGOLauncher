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
                CSGOAttributes curSrv = LauncherConfig.StoredConfiguration;
                curSrv.PublicIP = IPHelper.PublicIpAddress;
                curSrv.PrivateIP = IPHelper.PrivateIpAddress;
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
