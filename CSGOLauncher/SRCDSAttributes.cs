using System;
using System.Diagnostics;
using System.IO;

namespace CSGOLauncher
{
    public class SRCDSAttributes : ISRCDSCommands
    {
        public string ServerBinName
        {
            get { return "srcds.exe"; }
        }

        public GameShortNames GameType { get; set; }
        public bool UseConsole { get; set; }
        public bool UseRcon { get; set; }
        // Doesn't work on WIN32
        public bool AutoUpdate { get; set; }
        public string PrivateIP { get; set; }
        public string PublicIP { get; set; }
        public string Map { get; set; }

        public virtual string GetComandLine()
        {
            throw new NotImplementedException();
        }

        public virtual void StartServer()
        {
            Process.Start(Path.Combine(LauncherConfig.CurrentDirectory, GetComandLine()));
        }
    }

    public enum GameShortNames
    {
        csgo
    }
}
