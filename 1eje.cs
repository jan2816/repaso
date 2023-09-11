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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bnt1j_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txt1.Text)>=0)
            {

                MessageBox.Show("El número ingresado  positivo!!");

            }

            if (Convert.ToInt16(txt1.Text) <= 0)
            {

                MessageBox.Show("El número ingresado es negativo!!");

            }
            if (Convert.ToInt16(txt1.Text) == 0)
            {
                MessageBox.Show("El número es Cero!");

            }

            Application.Exit();
        }

        
    }
}
