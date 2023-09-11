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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        

        private void btnm1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            if (txtPassword.Text == "2")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            if (txtPassword.Text == "3")
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            if (txtPassword.Text == "4")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            if (Convert.ToInt16(txtPassword.Text) >= 5)
            {
                MessageBox.Show("ejercicio incorrecta. Intente de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
