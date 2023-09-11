namespace WindowsFormsApp3
{
    partial class Form4
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
            this.texcat1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.texcat2 = new System.Windows.Forms.TextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.bnt3j = new System.Windows.Forms.Button();
            this.labelf3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texcat1
            // 
            this.texcat1.Location = new System.Drawing.Point(32, 161);
            this.texcat1.Name = "texcat1";
            this.texcat1.Size = new System.Drawing.Size(52, 20);
            this.texcat1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(29, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " cateto 1";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(237, 108);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 13);
            this.linkLabel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(114, 108);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = " cateto 2";
            // 
            // texcat2
            // 
            this.texcat2.Location = new System.Drawing.Point(117, 161);
            this.texcat2.Name = "texcat2";
            this.texcat2.Size = new System.Drawing.Size(52, 20);
            this.texcat2.TabIndex = 8;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(196, 108);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(0, 13);
            this.linkLabel4.TabIndex = 11;
            // 
            // bnt3j
            // 
            this.bnt3j.Location = new System.Drawing.Point(44, 219);
            this.bnt3j.Name = "bnt3j";
            this.bnt3j.Size = new System.Drawing.Size(113, 23);
            this.bnt3j.TabIndex = 12;
            this.bnt3j.Text = "solucionar";
            this.bnt3j.UseVisualStyleBackColor = true;
            this.bnt3j.Click += new System.EventHandler(this.bnt3j_Click);
            // 
            // labelf3
            // 
            this.labelf3.AutoSize = true;
            this.labelf3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelf3.Location = new System.Drawing.Point(65, 44);
            this.labelf3.Name = "labelf3";
            this.labelf3.Size = new System.Drawing.Size(73, 15);
            this.labelf3.TabIndex = 13;
            this.labelf3.Text = "3 ejercicio";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(210, 277);
            this.Controls.Add(this.labelf3);
            this.Controls.Add(this.bnt3j);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.texcat2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.texcat1);
            this.Name = "Form4";
            this.Text = "solucion 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texcat1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox texcat2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button bnt3j;
        private System.Windows.Forms.Label labelf3;
    }
}