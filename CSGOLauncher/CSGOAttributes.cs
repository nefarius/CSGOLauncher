using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSGOLauncher
{
    [Serializable()]
    class CSGOAttributes : SRCDSAttributes
    {
        private GameModes _GameMode;
        public GameModes GameMode
        {
            get { return this._GameMode; }
            set { this._GameMode = value; }
        }

        private string _MapGroup;
        public string MapGroup
        {
            get { return this._MapGroup; }
            set { this._MapGroup = value; }
        }

        public override string GetComandLine()
        {
            StringBuilder cmdLine = new StringBuilder();
            string strGameTypeLine = "+game_type {0} +game_mode {1} ";

            cmdLine.AppendFormat("{0} ", ServerBinName);
            cmdLine.AppendFormat("-game {0} ", this.GameType);
            if (UseConsole) cmdLine.Append("-console ");
            if (UseRcon) cmdLine.AppendFormat("-usercon ");
            if (AutoUpdate) cmdLine.AppendFormat("-autoupdate ");
            switch (GameMode)
            {
                case GameModes.ArmsRace:
                    cmdLine.AppendFormat(strGameTypeLine, 1, 0);
                    break;
                case GameModes.Casual:
                    cmdLine.AppendFormat(strGameTypeLine, 0, 0);
                    break;
                case GameModes.Competitive:
                    cmdLine.AppendFormat(strGameTypeLine, 0, 1);
                    break;
                case GameModes.Demolition:
                    cmdLine.AppendFormat(strGameTypeLine, 1, 1);
                    break;
            }
            cmdLine.AppendFormat("+mapgroup {0} ", MapGroup);
            cmdLine.AppendFormat("+map {0} ", Map);
            cmdLine.AppendFormat("+ip {0} ", LocalIP);
            cmdLine.AppendFormat("+net_public_adr {0} ", PublicIP);

            return cmdLine.ToString();
        }
    }

    enum GameModes
    {
        Casual = 1,
        Competitive,
        ArmsRace,
        Demolition
    }
}
