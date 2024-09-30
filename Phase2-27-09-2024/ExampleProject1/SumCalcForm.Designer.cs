namespace ExampleProject1
{
    partial class SumCalcForm
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
            this.lblSumCalc = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnFindSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSumCalc
            // 
            this.lblSumCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSumCalc.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCalc.Location = new System.Drawing.Point(0, 0);
            this.lblSumCalc.Name = "lblSumCalc";
            this.lblSumCalc.Size = new System.Drawing.Size(1300, 57);
            this.lblSumCalc.TabIndex = 0;
            this.lblSumCalc.Text = "Sum Calc";
            this.lblSumCalc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(69, 123);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(112, 25);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number 1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(69, 208);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(112, 25);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "Number 2";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(69, 293);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(58, 25);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(214, 119);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(321, 32);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(214, 204);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(321, 32);
            this.txtNumber2.TabIndex = 5;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(214, 289);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(321, 32);
            this.txtSum.TabIndex = 6;
            // 
            // btnFindSum
            // 
            this.btnFindSum.Location = new System.Drawing.Point(214, 374);
            this.btnFindSum.Name = "btnFindSum";
            this.btnFindSum.Size = new System.Drawing.Size(321, 39);
            this.btnFindSum.TabIndex = 7;
            this.btnFindSum.Text = "Find Sum";
            this.btnFindSum.UseVisualStyleBackColor = true;
            this.btnFindSum.Click += new System.EventHandler(this.btnFindSum_Click);
            // 
            // SumCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.btnFindSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblSumCalc);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SumCalcForm";
            this.Text = "Sum Calc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SumCalcForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSumCalc;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnFindSum;
    }
}