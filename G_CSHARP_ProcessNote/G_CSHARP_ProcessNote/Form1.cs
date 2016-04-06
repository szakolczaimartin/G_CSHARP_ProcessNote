﻿using System;
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
        PerformanceCounter cpuPerformance = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        
        public Form1()
        {
            InitializeComponent();
            CPUTextBox.Text = CpuTime();
        }

        public string CpuTime()
        {
            return cpuPerformance.NextValue() + "%";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void alwaysOnTopButton_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopButton.Checked;
        }

        private void ExitButton(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?\nAll of your comments will be lost!", "Exit",
               MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processList.Rows.Clear();
            Process[] processArray = Process.GetProcesses();

            foreach (Process theprocess in processArray)
            {
                processList.Rows.Add(theprocess.Id, theprocess.ProcessName);
            }


        }

        private void processList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form1_Load(sender, e);

        }
    }
}
