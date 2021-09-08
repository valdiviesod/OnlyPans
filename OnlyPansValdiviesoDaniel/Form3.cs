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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precioalinado = 1000 * Convert.ToInt32(textBox3.Text);
            int precionoalinado = 500 * Convert.ToInt32(textBox4.Text);
            int precioespecial = 2000 * Convert.ToInt32(textBox5.Text);
            int preciototal = precionoalinado + precioalinado + precioespecial;
            richTextBox1.Text = ("Nombre: " + txtBoxNombre.Text + "\n" + "Cedula: " + textBox1.Text + "\n" + "Hora de la venta: " + textBox2.Text + "\n" + "Precio total: " + preciototal.ToString());
            txtBoxNombre.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void richTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
