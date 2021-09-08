using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPansValdiviesoDaniel
{
    public partial class Form1 : Form
    {
        String usuarioadmin = "admin";
        String claveadmin = "admin";
        String usuarioempleado = "user";
        String claveempleado = "user";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == usuarioadmin && txtBoxContra.Text == claveadmin)
            {
                txtBoxUsuario.Clear();
                txtBoxContra.Clear();
                Form2 nuevo = new Form2();
                nuevo.ShowDialog();
            }
            else
            {
                if (txtBoxUsuario.Text == usuarioempleado && txtBoxContra.Text == claveempleado)
                    {

                    txtBoxUsuario.Clear();
                    txtBoxContra.Clear();
                    Form3 nuevo = new Form3();
                    nuevo.ShowDialog();
                    }
                else
                    {
                    MessageBox.Show("ERROR, Usuario y contraseña incorrectos");
                    }

            }
        }

        private void txtBoxContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
