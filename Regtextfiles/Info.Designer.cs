namespace Regtextfiles
{
    partial class Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbregno = new System.Windows.Forms.TextBox();
            this.Tbdesc = new System.Windows.Forms.TextBox();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regnumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // Tbregno
            // 
            this.Tbregno.Location = new System.Drawing.Point(280, 114);
            this.Tbregno.Name = "Tbregno";
            this.Tbregno.Size = new System.Drawing.Size(150, 31);
            this.Tbregno.TabIndex = 2;
            this.Tbregno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tbdesc
            // 
            this.Tbdesc.Location = new System.Drawing.Point(280, 191);
            this.Tbdesc.Name = "Tbdesc";
            this.Tbdesc.Size = new System.Drawing.Size(150, 31);
            this.Tbdesc.TabIndex = 3;
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(307, 295);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(112, 34);
            this.BtnWrite.TabIndex = 4;
            this.BtnWrite.Text = "writetofile";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.Tbdesc);
            this.Controls.Add(this.Tbregno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Tbregno;
        private TextBox Tbdesc;
        private Button BtnWrite;
    }
}