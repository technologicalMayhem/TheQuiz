using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TheQuiz
{
    public partial class QuizWindow : Form
    {
        public QuizWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSkipQuestion_Click(object sender, EventArgs e)
        {
            var manager = new questionmanager();
            string[] question = manager.GetQuestion(2);
            foreach (string s in question)
            {
                Debug.WriteLine(s);
            }
        }
    }
}
