namespace G_CSHARP_ProcessNote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.AddCommentTextBox = new System.Windows.Forms.TextBox();
            this.showThreadsButton = new System.Windows.Forms.Button();
            this.alwaysOnTopButton = new System.Windows.Forms.CheckBox();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.runningTimeTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfThreadTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.processList = new System.Windows.Forms.DataGridView();
            this.PID_box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processName_box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.numberOfThreadsLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentFieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PID";
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(216, 362);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(89, 23);
            this.addCommentButton.TabIndex = 10;
            this.addCommentButton.Text = "Add Comment";
            this.addCommentButton.UseVisualStyleBackColor = true;
            // 
            // AddCommentTextBox
            // 
            this.AddCommentTextBox.Location = new System.Drawing.Point(24, 336);
            this.AddCommentTextBox.Name = "AddCommentTextBox";
            this.AddCommentTextBox.Size = new System.Drawing.Size(457, 20);
            this.AddCommentTextBox.TabIndex = 12;
            // 
            // showThreadsButton
            // 
            this.showThreadsButton.Location = new System.Drawing.Point(143, 261);
            this.showThreadsButton.Name = "showThreadsButton";
            this.showThreadsButton.Size = new System.Drawing.Size(100, 23);
            this.showThreadsButton.TabIndex = 13;
            this.showThreadsButton.Text = "Show Threads";
            this.showThreadsButton.UseVisualStyleBackColor = true;
            // 
            // alwaysOnTopButton
            // 
            this.alwaysOnTopButton.AutoSize = true;
            this.alwaysOnTopButton.Location = new System.Drawing.Point(381, 317);
            this.alwaysOnTopButton.Name = "alwaysOnTopButton";
            this.alwaysOnTopButton.Size = new System.Drawing.Size(98, 17);
            this.alwaysOnTopButton.TabIndex = 17;
            this.alwaysOnTopButton.Text = "Always On Top";
            this.alwaysOnTopButton.UseVisualStyleBackColor = true;
            this.alwaysOnTopButton.CheckedChanged += new System.EventHandler(this.alwaysOnTopButton_CheckedChanged);
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(24, 215);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUTextBox.TabIndex = 18;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(143, 215);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoryTextBox.TabIndex = 19;
            // 
            // runningTimeTextBox
            // 
            this.runningTimeTextBox.Location = new System.Drawing.Point(263, 215);
            this.runningTimeTextBox.Name = "runningTimeTextBox";
            this.runningTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.runningTimeTextBox.TabIndex = 20;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(381, 215);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTimeTextBox.TabIndex = 21;
            // 
            // numberOfThreadTextBox
            // 
            this.numberOfThreadTextBox.Location = new System.Drawing.Point(24, 264);
            this.numberOfThreadTextBox.Name = "numberOfThreadTextBox";
            this.numberOfThreadTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfThreadTextBox.TabIndex = 22;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(263, 267);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(218, 44);
            this.commentsTextBox.TabIndex = 23;
            // 
            // processList
            // 
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID_box,
            this.processName_box});
            this.processList.Location = new System.Drawing.Point(24, 19);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(266, 163);
            this.processList.TabIndex = 24;
            this.processList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.processList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processList_MouseDoubleClick);
            // 
            // PID_box
            // 
            this.PID_box.HeaderText = "PID";
            this.PID_box.Name = "PID_box";
            // 
            // processName_box
            // 
            this.processName_box.HeaderText = "Process Name";
            this.processName_box.Name = "processName_box";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(64, 199);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(29, 13);
            this.cpuLabel.TabIndex = 25;
            this.cpuLabel.Text = "CPU";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(170, 199);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(44, 13);
            this.memoryLabel.TabIndex = 26;
            this.memoryLabel.Text = "Memory";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(277, 199);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.runningTimeLabel.TabIndex = 27;
            this.runningTimeLabel.Text = "Running Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(403, 199);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 28;
            this.startTimeLabel.Text = "Start Time";
            // 
            // numberOfThreadsLabel
            // 
            this.numberOfThreadsLabel.AutoSize = true;
            this.numberOfThreadsLabel.Location = new System.Drawing.Point(24, 248);
            this.numberOfThreadsLabel.Name = "numberOfThreadsLabel";
            this.numberOfThreadsLabel.Size = new System.Drawing.Size(98, 13);
            this.numberOfThreadsLabel.TabIndex = 29;
            this.numberOfThreadsLabel.Text = "Number of Threads";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(344, 251);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(56, 13);
            this.commentsLabel.TabIndex = 30;
            this.commentsLabel.Text = "Comments";
            // 
            // commentFieldLabel
            // 
            this.commentFieldLabel.AutoSize = true;
            this.commentFieldLabel.Location = new System.Drawing.Point(21, 318);
            this.commentFieldLabel.Name = "commentFieldLabel";
            this.commentFieldLabel.Size = new System.Drawing.Size(128, 13);
            this.commentFieldLabel.TabIndex = 31;
            this.commentFieldLabel.Text = "Write here your comment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 398);
            this.Controls.Add(this.commentFieldLabel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.numberOfThreadsLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.runningTimeLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.numberOfThreadTextBox);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.runningTimeTextBox);
            this.Controls.Add(this.memoryTextBox);
            this.Controls.Add(this.CPUTextBox);
            this.Controls.Add(this.alwaysOnTopButton);
            this.Controls.Add(this.showThreadsButton);
            this.Controls.Add(this.AddCommentTextBox);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Process Note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitButton);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.TextBox AddCommentTextBox;
        private System.Windows.Forms.Button showThreadsButton;
        private System.Windows.Forms.CheckBox alwaysOnTopButton;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox numberOfThreadTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox runningTimeTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.DataGridView processList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName_box;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label numberOfThreadsLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label commentFieldLabel;
    }
}
