using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3NLIDTS_OscarGonzalez_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbNombre.TextChanged += validarNombre;
            tbEdad.TextChanged += validarEdad;             tbApellido.TextChanged += validarApellido;
            tbEstatura.TextChanged += validarEstatura;
            tbTelefono.Leave += validarTelefono;
            
        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox=(TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Profavor ingrese un texto valido( Leytras y espacio)", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private void validarApellido(object sender, EventArgs e)
        {

        }
        private void validarEdad(object sender, EventArgs e)
        {

        }
        private void validarEstatura(object sender, EventArgs e)
        {

        }
        private void validarTelefono(object sender, EventArgs e)
        {

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
            

            MessageBox.Show("Datos guardados en archivo de texto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string  datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nTeléfono: {telefono}\r\nEstatura: {estatura}\r\nGénero: {genero}";
            MessageBox.Show( datos, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string ruta = "datos.txt"; // El archivo se creará en la carpeta del programa
            File.AppendAllText(ruta, datos + Environment.NewLine + "---------------------" + Environment.NewLine);

        }
    }
}
