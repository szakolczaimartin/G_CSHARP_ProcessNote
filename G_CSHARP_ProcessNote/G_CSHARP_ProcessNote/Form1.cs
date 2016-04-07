#region File Header
/*[ Compilation unit ----------------------------------------------------------

   Component       : Process Note form file

   Name            : Code_Gangstaz

   Last Author     : Vas Richárd

   Language        : C#

   Creation Date   :  2016.04.07

   Description     : As an IT administrator I would like to have to check what kind of processes are running on the machine. I would like to make comment on it. As an IT administrator I would like to get the running process names and If I select one of it I would like to see some major property of it. These are: CPU usage, Memory usage, Running time, Start time, Threads of it in another dialog. I would like to comment textbox to left some note on it.


               Copyright (C) Codecool Kft 2016 All Rights Reserved

-----------------------------------------------------------------------------*/
/*] END */

#endregion File Header

#region Used Namespaces 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
#endregion Used Namespaces







namespace G_CSHARP_ProcessNote
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> commentDictionary = new Dictionary<string, string>();

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
            if (commentDictionary.Count != 0)
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
            Application.ExitThread();

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
            if (e.RowIndex != -1)
            {
                // process cpu usage
                var currentProcess = processList.CurrentRow.Cells[1].Value.ToString();
                var totalCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var processCpuUsage = new PerformanceCounter("Process", "% Processor Time", currentProcess);
                var calculatedProcessUsageFirst = (totalCpuUsage.NextValue() / 100) * processCpuUsage.NextValue();
                System.Threading.Thread.Sleep(100);
                var calculatedProcessUsage = (totalCpuUsage.NextValue() / 100) * processCpuUsage.NextValue();
                CPUTextBox.Text = calculatedProcessUsage + "%";
                // process memory usage
                int memsize=0;
                var processMemoryUsage = new PerformanceCounter("Process", "Working Set - Private", currentProcess);
                memsize = Convert.ToInt32(processMemoryUsage.NextValue() / (int)(1024));
                memoryTextBox.Text = memsize / 1000 + "MB";
                // process running/start time
                Process[] process = Process.GetProcessesByName(currentProcess);
                runningTimeTextBox.Text = (DateTime.Now - process[0].StartTime).ToString();
                startTimeTextBox.Text = process[0].StartTime.ToString();
                // process' thread counter
                numberOfThreadTextBox.Text = process[0].Threads.Count.ToString();
                // process' comment
                if (commentDictionary.ContainsKey(currentProcess))
                {
                    commentsTextBox.Text = commentDictionary[currentProcess];
                }
                else
                {
                    commentsTextBox.Text = string.Empty;
                }
            }
            
        }

        private void showThreadsButton_Click(object sender, EventArgs e)
        {
            var currentProcess = processList.CurrentRow.Cells[1].Value.ToString();
            Process[] process = Process.GetProcessesByName(currentProcess);
            ProcessThreadCollection currentThreads = process[0].Threads;

            List<string> processStrings = new List<string>();
            foreach (ProcessThread thread in currentThreads)
            {
                processStrings.Add(thread.Id.ToString());
            }

            StringBuilder sb = new StringBuilder();
            foreach (var thread in processStrings)
            {
                sb.AppendLine(thread);
            }
            MessageBox.Show("Current process threads' IDs:\n" + sb);
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            var currentProcess = processList.CurrentRow.Cells[1].Value.ToString();
            var comment = AddCommentTextBox.Text;
            if (!commentDictionary.ContainsKey(currentProcess))
            {
                commentDictionary.Add(currentProcess, comment);
            }
            else
            {
                commentDictionary[currentProcess] += comment;
            }
            AddCommentTextBox.Text = string.Empty;
            commentsTextBox.Text = commentDictionary[currentProcess];
        }
    }
}
