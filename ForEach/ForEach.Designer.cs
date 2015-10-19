namespace ForEach
{
    partial class frmForEach
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
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNumber1
            // 
            this.btnNumber1.Location = new System.Drawing.Point(116, 12);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(75, 23);
            this.btnNumber1.TabIndex = 0;
            this.btnNumber1.Text = "button1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber1_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Location = new System.Drawing.Point(12, 117);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(75, 23);
            this.btnNumber2.TabIndex = 1;
            this.btnNumber2.Text = "button2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber2_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Location = new System.Drawing.Point(219, 117);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(75, 23);
            this.btnNumber3.TabIndex = 2;
            this.btnNumber3.Text = "button3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber3_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Location = new System.Drawing.Point(116, 226);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(75, 23);
            this.btnNumber4.TabIndex = 3;
            this.btnNumber4.Text = "button4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber4_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(93, 75);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 95);
            this.lstOutput.TabIndex = 4;
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmForEach";
            this.Text = "For Each";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

