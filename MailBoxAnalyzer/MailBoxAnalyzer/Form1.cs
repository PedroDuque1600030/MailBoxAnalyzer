using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBoxAnalyzer
{
    public partial class Form1 : Form
    {
        Controller controller;

        //public event ViewHandler<IView> changed;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void setController(Controller _ctrl)
        {
            controller = _ctrl;
        }

        private void button_Conn_Click(object sender, EventArgs e)
        {
            controller.InterecacaoUser(this, TipoAccao.Connectar);
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            controller.InterecacaoUser(this, TipoAccao.Sair);
        }

        public string GetServerNameToConnect()
        {
            return textBox_ServerName.Text;
        }

        public int GetServerPortToConnect()
        {
            return Convert.ToInt32(textBox_ServerPort.Text);
        }

        public bool GetServerSSLToConnect()
        {
            return radioButton_SSLYes.Checked;
        }

        public void SetStatus(string status)
        {
            textBox_Status.Text =  status;
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            controller.InterecacaoUser(this, TipoAccao.Desligar);
        }

        public void Sair()
        {
            Application.Exit();
        }



    }


}
