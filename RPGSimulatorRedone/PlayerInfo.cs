using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorRedone
{
    class PlayerInfo
    {
        private string playerName;

        public PlayerInfo()
        {

        }
        public PlayerInfo(string pName)
        {
            playerName = pName;
        }
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
    }
}
