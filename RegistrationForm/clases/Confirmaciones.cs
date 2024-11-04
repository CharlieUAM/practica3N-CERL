using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm.clases
{
    internal class Confirmaciones
    {
        public bool confirmarname(string name)
        {
            if (name.Length > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool confirmarlastname(string Lname)
        {
            if (Lname.Length > 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Rellena correctamente el campo debe tener minimo 3 caracteres", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool confirmarmail(string mail)
        {
            if (mail.Length > 13 && mail.Contains("@")) {
                return true;
            }
            if (!mail.Contains("@")) {
                MessageBox.Show("El campo no lleva el caracter @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Campo no completo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool confirmpass(string pass) {
            if (pass.Length > 3)
            {
                return true;
            }
            else if (pass.Length < 3 && pass.Length > 0)
            {
                MessageBox.Show("La contraseña Debe tener al menos 3 caracteres", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Campo vacio", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool confirmpassword(string pass, string conf) {
            if (pass.Length > 3 && conf.Length > 3) {
                if (pass == conf)
                {
                    return true;
                }
                else {
                    MessageBox.Show("No es la misma contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; }

            }
            else if (pass.Length < 1)
            {
                MessageBox.Show("Campo vacio", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (conf.Length < 1)
            {
                MessageBox.Show("Campo vacio", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;

        }


    }
}
