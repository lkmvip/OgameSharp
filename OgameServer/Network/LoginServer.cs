using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OgameServer.Network
{
    /// <summary>
    /// The login server.
    /// </summary>
    public class LoginServer
    {
        Socket socket;
        const int MaximumUsers = 100;

        /// <summary>
        /// Constructor.
        /// </summary>
        public LoginServer()
        {
            socket = new Socket(SocketType.Unknown, ProtocolType.Udp);
        }

        /// <summary>
        /// Start the login server.
        /// </summary>
        /// <param name="port">Port of the login server.</param>
        public void Start(ushort port)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, port));
            socket.Listen(MaximumUsers);
        }

        /// <summary>
        /// Stop the login server.
        /// </summary>
        public void Stop()
        {
            socket.Shutdown(SocketShutdown.Both);
        }

        /// <summary>
        /// Get the socket of the login server.
        /// </summary>
        public Socket Socket
        {
            get { return socket; }
        }
    }
}
