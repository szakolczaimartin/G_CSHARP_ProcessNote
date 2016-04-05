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
            this.processListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showThreadsButton = new System.Windows.Forms.Button();
            this.alwaysOnTopButton = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processListBox
            // 
            this.processListBox.FormattingEnabled = true;
            this.processListBox.Location = new System.Drawing.Point(24, 35);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(457, 160);
            this.processListBox.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 20);
            this.textBox1.TabIndex = 12;
            // 
            // showThreadsButton
            // 
            this.showThreadsButton.Location = new System.Drawing.Point(143, 264);
            this.showThreadsButton.Name = "showThreadsButton";
            this.showThreadsButton.Size = new System.Drawing.Size(100, 23);
            this.showThreadsButton.TabIndex = 13;
            this.showThreadsButton.Text = "Show Threads";
            this.showThreadsButton.UseVisualStyleBackColor = true;
            // 
            // alwaysOnTopButton
            // 
            this.alwaysOnTopButton.AutoSize = true;
            this.alwaysOnTopButton.Location = new System.Drawing.Point(24, 313);
            this.alwaysOnTopButton.Name = "alwaysOnTopButton";
            this.alwaysOnTopButton.Size = new System.Drawing.Size(98, 17);
            this.alwaysOnTopButton.TabIndex = 17;
            this.alwaysOnTopButton.Text = "Always On Top";
            this.alwaysOnTopButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(263, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(381, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(24, 264);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(263, 267);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(218, 44);
            this.textBox7.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 398);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.alwaysOnTopButton);
            this.Controls.Add(this.showThreadsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.processListBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showThreadsButton;
        private System.Windows.Forms.CheckBox alwaysOnTopButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

