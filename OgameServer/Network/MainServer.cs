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
        ushort portLogin;
        ushort portGame;
        GameServer gameServer;
        LoginServer loginServer;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ip">Ip of the game.</param>
        /// <param name="portLogin">Port of the login server.</param>
        /// <param name="portGame">Port of the game server.</param>
        /// <param name="productionRate">Production rate.</param>
        /// <param name="speedRate">Speed rate.</param>
        public MainServer(ushort portLogin, ushort portGame, short productionRate, short speedRate)
        {
            this.portLogin = portLogin;
            this.portGame = portGame;
            this.loginServer = new LoginServer();
            this.gameServer = new GameServer(productionRate, speedRate);
        }

        /// <summary>
        /// Start the main server.
        /// </summary>
        public void Start()
        {
            loginServer.Start(portLogin);
            gameServer.Start(portGame);
        }

        /// <summary>
        /// Stop the main server.
        /// </summary>
        public void Stop()
        {
            loginServer.Stop();
            gameServer.Stop();
        }
    }
}
