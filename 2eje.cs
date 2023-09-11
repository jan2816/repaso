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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bnt2j_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtf2.Text ) % 2 == 0)
            {

                MessageBox.Show("El número ingresado es par !!");

            }
            else

            {

                MessageBox.Show("El número ingresado impar!!");

            }

            Application.Exit();

        }
        
    }
}
