using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void bnt4j_Click(object sender, EventArgs e)
        { string filePath = "numeros.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 1; i <= 100; i++)
                {
                    writer.WriteLine(i);
                }
            }

           
            
            
            MessageBox.Show("se ha guardado corectaemnee ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();



        }
        
    }

}
