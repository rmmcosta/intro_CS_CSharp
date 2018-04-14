namespace TestXmlTransform
{
    partial class MainForm
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
            this.btnXml = new System.Windows.Forms.Button();
            this.btnXslt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutFName = new System.Windows.Forms.TextBox();
            this.OutFExt = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.outPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(12, 12);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 0;
            this.btnXml.Text = "Browser xml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // btnXslt
            // 
            this.btnXslt.Location = new System.Drawing.Point(12, 41);
            this.btnXslt.Name = "btnXslt";
            this.btnXslt.Size = new System.Drawing.Size(75, 23);
            this.btnXslt.TabIndex = 1;
            this.btnXslt.Text = "Browser xslt";
            this.btnXslt.UseVisualStyleBackColor = true;
            this.btnXslt.Click += new System.EventHandler(this.BtnXslt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File Extension:";
            // 
            // OutFName
            // 
            this.OutFName.Location = new System.Drawing.Point(223, 14);
            this.OutFName.Name = "OutFName";
            this.OutFName.Size = new System.Drawing.Size(100, 20);
            this.OutFName.TabIndex = 4;
            // 
            // OutFExt
            // 
            this.OutFExt.Location = new System.Drawing.Point(223, 43);
            this.OutFExt.Name = "OutFExt";
            this.OutFExt.Size = new System.Drawing.Size(100, 20);
            this.OutFExt.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(345, 26);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // outPath
            // 
            this.outPath.Location = new System.Drawing.Point(106, 72);
            this.outPath.Name = "outPath";
            this.outPath.Size = new System.Drawing.Size(654, 20);
            this.outPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output File Path:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outPath);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.OutFExt);
            this.Controls.Add(this.OutFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXslt);
            this.Controls.Add(this.btnXml);
            this.Name = "MainForm";
            this.Text = "XSLTransform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnXslt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutFName;
        private System.Windows.Forms.TextBox OutFExt;
        private System.Windows.Forms.Button btnRun;
        public System.Windows.Forms.TextBox outPath;
        private System.Windows.Forms.Label label3;
    }
}

