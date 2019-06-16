namespace Common
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btGenXML = new System.Windows.Forms.Button();
            this.txtNameOfClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbXml = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(678, 290);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btGenXML
            // 
            this.btGenXML.Location = new System.Drawing.Point(726, 31);
            this.btGenXML.Name = "btGenXML";
            this.btGenXML.Size = new System.Drawing.Size(75, 23);
            this.btGenXML.TabIndex = 1;
            this.btGenXML.Text = "GenXML";
            this.btGenXML.UseVisualStyleBackColor = true;
            this.btGenXML.Click += new System.EventHandler(this.GenXMl_Click);
            // 
            // txtNameOfClass
            // 
            this.txtNameOfClass.Location = new System.Drawing.Point(107, 25);
            this.txtNameOfClass.Name = "txtNameOfClass";
            this.txtNameOfClass.Size = new System.Drawing.Size(283, 20);
            this.txtNameOfClass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name Of Class";
            // 
            // rtbXml
            // 
            this.rtbXml.Location = new System.Drawing.Point(726, 60);
            this.rtbXml.Name = "rtbXml";
            this.rtbXml.Size = new System.Drawing.Size(513, 290);
            this.rtbXml.TabIndex = 4;
            this.rtbXml.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 401);
            this.Controls.Add(this.rtbXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameOfClass);
            this.Controls.Add(this.btGenXML);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btGenXML;
        private System.Windows.Forms.TextBox txtNameOfClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbXml;
    }
}

