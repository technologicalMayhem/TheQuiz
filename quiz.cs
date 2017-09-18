using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TheQuiz
{
    static class quiz
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuizWindow());
        }
    }
}
