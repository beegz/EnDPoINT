using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EnDPoINT
{
    class Settings
    {
        private IPAddress _serverIP;
        

        // Get/Set
        public IPAddress serverIP
        {
            get { return _serverIP; }
            set { this._serverIP = value; }
        }
        
        /// <summary>
        /// Standard Constructor for default settings
        /// </summary>
        public Settings()
        {
            this._serverIP = this.findNetworkAddress();
        }

        private IPAddress findNetworkAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            IPAddress _ip;
            IPAddress.TryParse("127.0.0.1",out _ip);
            return _ip;
        }
    }
}
