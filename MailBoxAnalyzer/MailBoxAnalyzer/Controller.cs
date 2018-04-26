using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailBoxAnalyzer
{

    public class Controller
    {
        Model_MailBoxAnalyzer model;
        Form1 view;

        public Controller(Model_MailBoxAnalyzer _model)
        {
            this.model = _model;
        }

        public void setView(Form1 _view)
        {
            view = _view;
        }

        public void InterecacaoUser(object sender, TipoAccao ta)
        {
            if (ta == TipoAccao.Connectar)
            {
                //   System.Windows.Forms.MessageBox.Show("quero connectar");
                Server_Settings server_settings = new Server_Settings(view.GetServerNameToConnect(), view.GetServerPortToConnect(), view.GetServerSSLToConnect());
                bool status = model.ConnectToServer(server_settings);
                view.SetStatus("Ligado");
            }

            if (ta == TipoAccao.Sair)
            {
                //System.Windows.Forms.MessageBox.Show("quero sair");
                view.Sair();
            }

            if (ta == TipoAccao.Desligar)
            {
                bool status = model.DisconnectFromServer();
                view.SetStatus("Desligado");
            }
        }

    }

    public enum TipoAccao
    {
        Connectar,
        Desligar,
        Sair
    }


    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
}
