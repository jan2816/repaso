namespace WindowsFormsApp3
{
    partial class Form3
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
            this.txtf2 = new System.Windows.Forms.TextBox();
            this.labelf3 = new System.Windows.Forms.Label();
            this.bnt2j = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtf2
            // 
            this.txtf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtf2.Location = new System.Drawing.Point(44, 104);
            this.txtf2.Name = "txtf2";
            this.txtf2.Size = new System.Drawing.Size(100, 24);
            this.txtf2.TabIndex = 5;
            // 
            // labelf3
            // 
            this.labelf3.AutoSize = true;
            this.labelf3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelf3.Location = new System.Drawing.Point(60, 40);
            this.labelf3.Name = "labelf3";
            this.labelf3.Size = new System.Drawing.Size(73, 15);
            this.labelf3.TabIndex = 7;
            this.labelf3.Text = "2 ejercicio";
            // 
            // bnt2j
            // 
            this.bnt2j.Location = new System.Drawing.Point(44, 177);
            this.bnt2j.Name = "bnt2j";
            this.bnt2j.Size = new System.Drawing.Size(113, 23);
            this.bnt2j.TabIndex = 6;
            this.bnt2j.Text = "solucionar";
            this.bnt2j.UseVisualStyleBackColor = true;
            this.bnt2j.Click += new System.EventHandler(this.bnt2j_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(201, 240);
            this.Controls.Add(this.txtf2);
            this.Controls.Add(this.labelf3);
            this.Controls.Add(this.bnt2j);
            this.Name = "Form3";
            this.Text = "solucion 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtf2;
        private System.Windows.Forms.Label labelf3;
        private System.Windows.Forms.Button bnt2j;
    }
}