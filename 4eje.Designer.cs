namespace WindowsFormsApp3
{
    partial class Form5
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
            this.labelf5 = new System.Windows.Forms.Label();
            this.bnt4j = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelf5
            // 
            this.labelf5.AutoSize = true;
            this.labelf5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelf5.Location = new System.Drawing.Point(74, 115);
            this.labelf5.Name = "labelf5";
            this.labelf5.Size = new System.Drawing.Size(73, 15);
            this.labelf5.TabIndex = 14;
            this.labelf5.Text = "4 ejercicio";
            // 
            // bnt4j
            // 
            this.bnt4j.Location = new System.Drawing.Point(53, 213);
            this.bnt4j.Name = "bnt4j";
            this.bnt4j.Size = new System.Drawing.Size(113, 23);
            this.bnt4j.TabIndex = 13;
            this.bnt4j.Text = "solucionar";
            this.bnt4j.UseVisualStyleBackColor = true;
            this.bnt4j.Click += new System.EventHandler(this.bnt4j_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 287);
            this.Controls.Add(this.labelf5);
            this.Controls.Add(this.bnt4j);
            this.Name = "Form5";
            this.Text = "solucion 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelf5;
        private System.Windows.Forms.Button bnt4j;
    }
}