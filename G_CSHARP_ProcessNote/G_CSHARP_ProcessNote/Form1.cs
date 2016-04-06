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

        private void processList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // process cpu usage
            var processNameValue = processList.Rows[e.RowIndex].Cells[1].Value;
            var totalCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            var processCpuUsage = new PerformanceCounter("Process", "% Processor Time", processNameValue.ToString());
            var calculatedProcessUsageFirst = (totalCpuUsage.NextValue() / 100) * processCpuUsage.NextValue();
            System.Threading.Thread.Sleep(100);
            var calculatedProcessUsage = (totalCpuUsage.NextValue() / 100) * processCpuUsage.NextValue();
            CPUTextBox.Text = calculatedProcessUsage + "%";
            // process memory usage
            int memsize = 0;
            var processMemoryUsage = new PerformanceCounter("Process", "Working Set - Private", processNameValue.ToString());
            memsize = Convert.ToInt32((processMemoryUsage.NextValue()) / (int)(1024));
            memoryTextBox.Text = memsize / 1000 + "MB";
            // process running/start time
            Process[] process = Process.GetProcessesByName(processNameValue.ToString());
            runningTimeTextBox.Text = (DateTime.Now - process[0].StartTime).ToString();
            startTimeTextBox.Text = process[0].StartTime.ToString();
            // process's thread counter
            numberOfThreadTextBox.Text = process[0].Threads.Count.ToString();
        }

        private void showThreadsButton_Click(object sender, EventArgs e)
        {
            var processNameValue = processList.CurrentRow.Cells[1].Value.ToString();
            Process[] process = Process.GetProcessesByName(processNameValue);
            var processThreads = process[0].Threads;
            List<string> processStrings = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (var thread in processThreads)
            {
                processStrings.Add(thread.ToString());
            }
            foreach (var thread in processStrings)
            {
                sb.AppendLine(thread);
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
