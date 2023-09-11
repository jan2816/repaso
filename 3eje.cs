using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bnt3j_Click(object sender, EventArgs e)
        {
            if (double.TryParse(texcat1.Text, out double cateto1) && double.TryParse(texcat1.Text, out double cateto2))
            {
                double hipotenusa = CalcularHipotenusa(cateto1, cateto2);
                MessageBox.Show ( $"La hipotenusa del triángulo rectángulo es: {hipotenusa:F2}");
            }
            else
            {
               MessageBox.Show("Por favor, ingrese valores válidos para los catetos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            Application.Exit();
        }

        private double CalcularHipotenusa(double cateto1, double cateto2)
        {
            return Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
        }
        

    }
    
}
