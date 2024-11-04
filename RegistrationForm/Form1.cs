using RegistrationForm.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Confirmaciones confirms = new Confirmaciones();
        bool acceder;

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (confirms.confirmarname(tbname.Text) == true) acceder = true;
            else acceder = false;
            if (confirms.confirmarlastname(tblastname.Text) == true) acceder = true;
            else acceder = false;
            if (confirms.confirmarmail(tbmail.Text) == true) acceder = true;
            else acceder = false;
            if (confirms.confirmpassword(tbpass.Text, tbconfirm.Text) == true) acceder = true;
            else acceder = false;
            if (acceder == true)
            {
                MessageBox.Show("Registro Exitoso", "Regisro hecho");
            }
        }
    }
}
