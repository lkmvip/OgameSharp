using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OgameServer.Network
{
    /// <summary>
    /// The game server.
    /// </summary>
    public class GameServer
    {
        short productionRate;
        short speedRate;
        TcpListener tcpServer;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="productionRate">Production rate.</param>
        /// <param name="speedRate">Speed rate.</param>
        public GameServer(short productionRate, short speedRate)
        {
            this.productionRate = productionRate;
            this.speedRate = speedRate;
        }

        /// <summary>
        /// Start the game server.
        /// </summary>
        /// <param name="ip">Ip of the game server.</param>
        /// <param name="port">Port the game server.</param>
        public void Start(string ip, ushort port)
        {
            
        }

        /// <summary>
        /// Get the production rate of the server.
        /// </summary>
        public short ProductionRate
        {
            get { return productionRate; }
        }

        /// <summary>
        /// Get the speed rate of the server.
        /// </summary>
        public short SpeedRate
        {
            get { return speedRate; }
        }
    }
}