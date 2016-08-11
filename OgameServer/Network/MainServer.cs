using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameServer.Network
{
    /// <summary>
    /// The main server.
    /// </summary>
    public class MainServer
    {
        string ip;
        ushort port;
        GameServer gameServer;
        LoginServer loginServer;
        
        public MainServer(string ip, ushort port,short productionRate, short speedRate)
        {
            this.ip = ip;
            this.port = port;
        }
    }
}
