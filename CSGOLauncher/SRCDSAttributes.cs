using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

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
        // This property tends to change, don't save it
        [XmlIgnore]
        public string PrivateIP { get; set; }
        // This property tends to change, don't save it
        [XmlIgnore]
        public string PublicIP { get; set; }
        public string Map { get; set; }
        public bool LanMode { get; set; }
        public bool UseUPnP { get; set; }
        public int Port { get; set; }
        public static int DefaultPort
        {
            get { return 27015; }
        }

        public virtual string GetComandLine()
        {
            throw new NotImplementedException();
        }

        public virtual void StartServer()
        {
            Process.Start(Path.Combine(LauncherConfig.CurrentDirectory, this.ServerBinName), GetComandLine());
        }
    }

    public enum GameShortNames
    {
        csgo
    }
}
