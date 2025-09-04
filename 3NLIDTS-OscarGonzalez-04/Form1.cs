using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_OscarGonzalez_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbTelefono.Clear();
            tbEstatura.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string edad = tbEdad.Text;
            string telefono = tbTelefono.Text;
            string estatura = tbEstatura.Text;
            string genero = "";
            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            string  datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nTeléfono: {telefono}\r\nEstatura: {estatura}\r\nGénero: {genero}";
            MessageBox.Show( datos, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
