using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBoxAnalyzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //View_MailBoxAnalyzer view = new View_MailBoxAnalyzer();
            Form1 view = new Form1();
            Model_MailBoxAnalyzer model = new Model_MailBoxAnalyzer();
            Controller myController = new Controller(model);
            view.setController(myController);

            myController.setView(view);

            Application.Run(view);
        }
    }
}
