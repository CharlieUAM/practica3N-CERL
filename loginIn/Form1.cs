using loginIn.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        users.usuarios login = new users.usuarios();
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (tbuser.Text.ToLower() == "admin" && tbpassword.Text.ToLower() == "1234")
            {
                MessageBox.Show("Bienvenido Admin", "Admin",  MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else if (tbuser.Text.Length > 3 && tbpassword.Text.Length > 3) {
                MessageBox.Show("Login correctamente");
            }
            else
            {
                MessageBox.Show("Escriba mas de 3 caracteres para acceder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
