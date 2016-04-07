#region File Header
/*[ Compilation unit ----------------------------------------------------------

   Component       : Process Note form file

   Name            : Code_Gangstaz

   Last Author     : Vas Richárd

   Language        : C#

   Creation Date   :  2016.04.07

   Description     : As an IT administrator I would like to have to check what kind of processes are running on the machine. 
                     I would like to make comment on it. As an IT administrator I would like to get the running process names and 
                     If I select one of it I would like to see some major property of it. These are: CPU usage, Memory usage, Running 
                     time, Start time, Threads of it in another dialog. I would like to comment textbox to left some note on it.


               Copyright (C) Codecool Kft 2016 All Rights Reserved

-----------------------------------------------------------------------------*/
/*] END */

#endregion File Header

#region Used Namespaces 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion Used Namespaces

namespace G_CSHARP_ProcessNote
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> _commentDictionary = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void alwaysOnTopButton_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopButton.Checked;
        }

        private void ExitButton(object sender, FormClosingEventArgs e)
        {
            ExitDialog(e);
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
                var currentProcess = processList.CurrentRow?.Cells[1].Value.ToString();
                var totalCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var processCpuUsage = new PerformanceCounter("Process", "% Processor Time", currentProcess);
                System.Threading.Thread.Sleep(100);
                var calculatedProcessUsage = (totalCpuUsage.NextValue() / 100) * processCpuUsage.NextValue();
                CPUTextBox.Text = calculatedProcessUsage + @"%";
                // process memory usage
                var processMemoryUsage = new PerformanceCounter("Process", "Working Set - Private", currentProcess);
                var memsize = Convert.ToInt32(processMemoryUsage.NextValue() / 1024);
                memoryTextBox.Text = memsize / 1000 + @"MB";
                // process running/start time
                Process[] process = Process.GetProcessesByName(currentProcess);
                runningTimeTextBox.Text = (DateTime.Now - process[0].StartTime).ToString();
                startTimeTextBox.Text = process[0].StartTime.ToString(CultureInfo.CurrentCulture);
                // process' thread counter
                numberOfThreadTextBox.Text = process[0].Threads.Count.ToString();
                // process' comment
                if (currentProcess != null && _commentDictionary.ContainsKey(currentProcess))
                {
                    commentsTextBox.Text = _commentDictionary[currentProcess];
                }
                else
                {
                    commentsTextBox.Text = string.Empty;
                }
            }
        }

        private void showThreadsButton_Click(object sender, EventArgs e)
        {
            ShowThreads();
        }

        private void ShowThreads()
        {
            if (processList.CurrentRow == null) return;
            var currentProcess = processList.CurrentRow.Cells[1].Value.ToString();
            var process = Process.GetProcessesByName(currentProcess);
            var currentThreads = process[0].Threads;

            var processStrings = (from ProcessThread thread in currentThreads select thread.Id.ToString()).ToList();

            var sb = new StringBuilder();
            foreach (var thread in processStrings)
            {
                sb.AppendLine(thread);
            }
            MessageBox.Show(@"Current process threads' IDs: " + sb);
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            Comment();
        }

        private void Comment()
        {
            if (processList.CurrentRow == null) return;
            var currentProcess = processList.CurrentRow.Cells[1].Value.ToString();
            var comment = AddCommentTextBox.Text;
            if (!_commentDictionary.ContainsKey(currentProcess))
            {
                _commentDictionary.Add(currentProcess, comment);
            }
            else
            {
                _commentDictionary[currentProcess] += comment;
            }
            AddCommentTextBox.Text = string.Empty;
            commentsTextBox.Text = _commentDictionary[currentProcess];
        }

        private void ExitDialog(FormClosingEventArgs e)
        {
            if (_commentDictionary.Count != 0)
            {
                var dialog = MessageBox.Show(@"Are you sure? All of your comments will be lost!", @"Exit",
                    MessageBoxButtons.YesNo);
                switch (dialog)
                {
                    case DialogResult.Yes:
                        Application.ExitThread();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
