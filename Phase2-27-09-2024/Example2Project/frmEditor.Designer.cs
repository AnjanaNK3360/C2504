namespace Example2Project
{
    partial class frmEditor
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
            this.components = new System.ComponentModel.Container();
            this.lblEditorApp = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreenBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFond = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolLeft = new System.Windows.Forms.ToolStripButton();
            this.toolCenter = new System.Windows.Forms.ToolStripButton();
            this.toolRight = new System.Windows.Forms.ToolStripButton();
            this.mnuEditor.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditorApp
            // 
            this.lblEditorApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEditorApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEditorApp.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorApp.Location = new System.Drawing.Point(0, 55);
            this.lblEditorApp.Name = "lblEditorApp";
            this.lblEditorApp.Size = new System.Drawing.Size(1014, 91);
            this.lblEditorApp.TabIndex = 0;
            this.lblEditorApp.Text = "Editor App";
            this.lblEditorApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.mnuEditor;
            this.txtEditor.Location = new System.Drawing.Point(185, 170);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(581, 194);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "I am Anjana,\r\nTrainee of WPF with C# batch at Quest Global\r\n";
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuBlue2,
            this.mnuGreen2});
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(241, 76);
            // 
            // mnuRed2
            // 
            this.mnuRed2.Name = "mnuRed2";
            this.mnuRed2.Size = new System.Drawing.Size(240, 24);
            this.mnuRed2.Text = "Red Background Color";
            this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
            // 
            // mnuBlue2
            // 
            this.mnuBlue2.Name = "mnuBlue2";
            this.mnuBlue2.Size = new System.Drawing.Size(240, 24);
            this.mnuBlue2.Text = "Blue Background Color";
            this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
            // 
            // mnuGreen2
            // 
            this.mnuGreen2.Name = "mnuGreen2";
            this.mnuGreen2.Size = new System.Drawing.Size(240, 24);
            this.mnuGreen2.Text = "Green Background Color";
            this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnForeColor);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.btnColor);
            this.pnlBottom.Controls.Add(this.btnGreen);
            this.pnlBottom.Controls.Add(this.btnBlue);
            this.pnlBottom.Controls.Add(this.btnRed);
            this.pnlBottom.Controls.Add(this.staPage);
            this.pnlBottom.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 538);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1014, 165);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(642, 44);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(124, 30);
            this.btnForeColor.TabIndex = 7;
            this.btnForeColor.Text = "Pick Color";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Foreground";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Background";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(436, 37);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(90, 37);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(299, 37);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(97, 37);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Turquoise;
            this.btnBlue.Location = new System.Drawing.Point(174, 35);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 39);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(24, 35);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(83, 39);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColor});
            this.staPage.Location = new System.Drawing.Point(0, 139);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(1014, 26);
            this.staPage.TabIndex = 4;
            this.staPage.Text = "statusStrip1";
            // 
            // staColor
            // 
            this.staColor.Name = "staColor";
            this.staColor.Size = new System.Drawing.Size(76, 20);
            this.staColor.Text = "IndianRed";
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(1014, 28);
            this.mnuBar.TabIndex = 4;
            this.mnuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator3,
            this.mnuSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(137, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(134, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(137, 26);
            this.mnuSave.Text = "Save...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.mnuBlueBg,
            this.mnuGreenBg,
            this.mnuBg,
            this.toolStripSeparator1,
            this.mnuFg});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(261, 26);
            this.mnuRedBg.Text = "Red Background Color";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(261, 26);
            this.mnuBlueBg.Text = "Blue Background Color";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // mnuGreenBg
            // 
            this.mnuGreenBg.Name = "mnuGreenBg";
            this.mnuGreenBg.Size = new System.Drawing.Size(261, 26);
            this.mnuGreenBg.Text = "Green Background Color";
            this.mnuGreenBg.Click += new System.EventHandler(this.mnuGreenBg_Click);
            // 
            // mnuBg
            // 
            this.mnuBg.Name = "mnuBg";
            this.mnuBg.Size = new System.Drawing.Size(261, 26);
            this.mnuBg.Text = "Other Background Color...";
            this.mnuBg.Click += new System.EventHandler(this.mnuBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(261, 26);
            this.mnuFg.Text = "Foreground Color...";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFond,
            this.toolStripSeparator2,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // mnuFond
            // 
            this.mnuFond.Name = "mnuFond";
            this.mnuFond.Size = new System.Drawing.Size(174, 26);
            this.mnuFond.Text = "Fond...";
            this.mnuFond.Click += new System.EventHandler(this.mnuFond_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Image = global::Example2Project.Properties.Resources._9056946_align_left_icon;
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignLeft.Text = "Align Left";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Image = global::Example2Project.Properties.Resources._9056948_align_center_icon;
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignCenter.Text = "Align Center";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Image = global::Example2Project.Properties.Resources._9056730_align_right_icon;
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignRight.Text = "Align Right";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "mytext";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "mytext1.txt";
            this.dlgSave.Filter = "Text File(*.txt) | JSON File(*.json)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLeft,
            this.toolCenter,
            this.toolRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolLeft
            // 
            this.toolLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLeft.Image = global::Example2Project.Properties.Resources._9056946_align_left_icon;
            this.toolLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLeft.Name = "toolLeft";
            this.toolLeft.Size = new System.Drawing.Size(29, 24);
            this.toolLeft.Text = "toolStripButton1";
            this.toolLeft.Click += new System.EventHandler(this.toolLeft_Click);
            // 
            // toolCenter
            // 
            this.toolCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCenter.Image = global::Example2Project.Properties.Resources._9056948_align_center_icon;
            this.toolCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCenter.Name = "toolCenter";
            this.toolCenter.Size = new System.Drawing.Size(29, 24);
            this.toolCenter.Text = "toolStripButton2";
            this.toolCenter.Click += new System.EventHandler(this.toolCenter_Click);
            // 
            // toolRight
            // 
            this.toolRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRight.Image = global::Example2Project.Properties.Resources._9056730_align_right_icon;
            this.toolRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRight.Name = "toolRight";
            this.toolRight.Size = new System.Drawing.Size(29, 24);
            this.toolRight.Text = "toolStripButton3";
            this.toolRight.Click += new System.EventHandler(this.toolRight_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 703);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblEditorApp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEditor";
            this.Text = "Editor App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuEditor.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditorApp;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ContextMenuStrip mnuEditor;
        private System.Windows.Forms.ToolStripMenuItem mnuRed2;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFond;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolLeft;
        private System.Windows.Forms.ToolStripButton toolCenter;
        private System.Windows.Forms.ToolStripButton toolRight;
    }
}

