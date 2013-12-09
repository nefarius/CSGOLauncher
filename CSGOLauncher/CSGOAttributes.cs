using System.Text;

namespace CSGOLauncher
{
    public class CSGOAttributes : SRCDSAttributes
    {
        public GameModes GameMode { get; set; }
        public string MapGroup { get; set; }

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
            if(!string.IsNullOrEmpty(MapGroup)) 
                cmdLine.AppendFormat("+mapgroup {0} ", MapGroup);
            if(!string.IsNullOrEmpty(Map))
                cmdLine.AppendFormat("+map {0} ", Map);
            if(!string.IsNullOrEmpty(PrivateIP))
                cmdLine.AppendFormat("+ip {0} ", PrivateIP);
            if(!string.IsNullOrEmpty(PublicIP))
                cmdLine.AppendFormat("+net_public_adr {0} ", PublicIP);

            return cmdLine.ToString();
        }
    }

    public enum GameModes
    {
        Casual,
        Competitive,
        ArmsRace,
        Demolition
    }
}
