namespace ExampleProject1
{
    partial class MainPageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSumCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSquareCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContactList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalc,
            this.mnuSalary,
            this.mnuContact});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Menu Bar";
            // 
            // mnuCalc
            // 
            this.mnuCalc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSumCalc,
            this.toolStripSeparator1,
            this.mnuSquareCalc});
            this.mnuCalc.Name = "mnuCalc";
            this.mnuCalc.Size = new System.Drawing.Size(90, 24);
            this.mnuCalc.Text = "&Calculator";
            // 
            // mnuSumCalc
            // 
            this.mnuSumCalc.Name = "mnuSumCalc";
            this.mnuSumCalc.Size = new System.Drawing.Size(170, 26);
            this.mnuSumCalc.Text = "&Sum Calc";
            this.mnuSumCalc.Click += new System.EventHandler(this.mnuSumCalc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuSquareCalc
            // 
            this.mnuSquareCalc.Name = "mnuSquareCalc";
            this.mnuSquareCalc.Size = new System.Drawing.Size(170, 26);
            this.mnuSquareCalc.Text = "S&quare Calc";
            this.mnuSquareCalc.Click += new System.EventHandler(this.mnuSquareCalc_Click);
            // 
            // mnuSalary
            // 
            this.mnuSalary.Name = "mnuSalary";
            this.mnuSalary.Size = new System.Drawing.Size(63, 24);
            this.mnuSalary.Text = "&Salary";
            this.mnuSalary.Click += new System.EventHandler(this.mnuSalary_Click);
            // 
            // mnuContact
            // 
            this.mnuContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContactList,
            this.mnuNewContact});
            this.mnuContact.Name = "mnuContact";
            this.mnuContact.Size = new System.Drawing.Size(74, 24);
            this.mnuContact.Text = "C&ontact";
            // 
            // mnuContactList
            // 
            this.mnuContactList.Name = "mnuContactList";
            this.mnuContactList.Size = new System.Drawing.Size(224, 26);
            this.mnuContactList.Text = "&Contact List";
            // 
            // mnuNewContact
            // 
            this.mnuNewContact.Name = "mnuNewContact";
            this.mnuNewContact.Size = new System.Drawing.Size(224, 26);
            this.mnuNewContact.Text = "&New Contact";
            this.mnuNewContact.Click += new System.EventHandler(this.mnuNewContact_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPageForm";
            this.Text = "Example1 App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuSumCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSquareCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuSalary;
        private System.Windows.Forms.ToolStripMenuItem mnuContact;
        private System.Windows.Forms.ToolStripMenuItem mnuContactList;
        private System.Windows.Forms.ToolStripMenuItem mnuNewContact;
    }
}

