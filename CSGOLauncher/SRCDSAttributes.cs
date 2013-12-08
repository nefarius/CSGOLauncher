using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSGOLauncher
{
    [Serializable()]
    class SRCDSAttributes : ISRCDSCommands
    {
        public string ServerBinName
        {
            get { return "srcds.exe"; }
        }

        private GameShortNames _GameType;
        public GameShortNames GameType
        {
            get { return this._GameType; }
            set { this._GameType = value; }
        }

        private bool _UseConsole;
        public bool UseConsole
        {
            get { return this._UseConsole; }
            set { this._UseConsole = value; }
        }

        private bool _UseRcon;
        public bool UseRcon
        {
            get { return this._UseRcon; }
            set { this._UseRcon = value; }
        }

        private bool _AutoUpdate;
        public bool AutoUpdate
        {
            get { return this._AutoUpdate; }
            set { this._AutoUpdate = value; }
        }

        private string _LocalIP;
        public string LocalIP
        {
            get { return this._LocalIP; }
            set { this._LocalIP = value; }
        }

        private string _PublicIP;
        public string PublicIP
        {
            get { return this._PublicIP; }
            set { this._PublicIP = value; }
        }

        private string _Map;
        public string Map
        {
            get { return this._Map; }
            set { this._Map = value; }
        }

        public virtual string GetComandLine()
        {
            throw new NotImplementedException();
        }
    }

    enum GameShortNames
    {
        csgo
    }
}
