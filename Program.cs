using System;
using System.Windows.Forms;

namespace EngineDestroyer {
    static class Program {
        /// <summary>
        /// Formulário principal.
        /// </summary>
        public static FrmMain MainForm;

        /// <summary>
        /// Lista de conexões.
        /// </summary>
        public static ConnectionManager Connections;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            MainForm = new FrmMain();         
            Application.Run(MainForm);
        }
    }
}
