using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_ProcessNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            listBox1.Items.Clear();

            foreach (Process theprocess in processlist)
            {
                listBox1.Items.Add(" " + theprocess.Id + "   " + theprocess.ProcessName);

              //  Console.WriteLine(theprocess.Id + "       " + theprocess.ProcessName);         
              }


        }
    }
}
