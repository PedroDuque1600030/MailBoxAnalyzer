using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenPop.Pop3;

namespace MailBoxAnalyzer
{
    public class Model_MailBoxAnalyzer
    {
        private Pop3Client client;

        public Model_MailBoxAnalyzer()
        {
            client = new Pop3Client();
        }

        public bool ConnectToServer(Server_Settings server_settings)
        {
            try
            {
                client.Connect(server_settings.ServerName, server_settings.ServerPort, server_settings.SSL);
            }
            catch (Exception)
            {
                
                // tratar erros
            }
            return client.Connected;
        }

        public bool DisconnectFromServer()
        {
            try
            {
                client.Disconnect();
            }
            catch (Exception)
            {
                
                // tratar erros de disconnect
            }
            return client.Connected;
        }

    }

    public class Server_Settings
    {
        public Server_Settings(string name, int port, bool _ssl)
        {
            servername = name;
            serverport = port;
            ssl = _ssl;
        }

        private string servername;
        public string ServerName
        {
            get
            {
                return this.servername;
            }
            set
            {
                this.servername = value;
            }
        }

        private int serverport;
        public int ServerPort
        {
            get
            {
                return this.serverport;
            }
            set
            {
                this.serverport = value;
            }
        }

        private bool ssl;
        public bool SSL
        {
            get
            {
                return this.ssl;
            }
            set
            {
                this.ssl = value;
            }
        }
    }
}
