using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class RetanguloForm : Form
    {
        public RetanguloForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InicioForm form1 = new InicioForm();
            form1.Show();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "O valor do perimetro desse retângulo é de: ";
            label3.Text = "O valor da área desse retângulo é de: ";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (double.Parse(textBox1.Text) != 0 && double.Parse(textBox2.Text) != 0)
                {
                    label4.Text = $"Com a largura de tamanho: {double.Parse(textBox1.Text)}\nE o comprimento de tamanho: {double.Parse(textBox2.Text)}";
                    Retangulo r1 = new Retangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    label2.Text += r1.CalcularPerimetro();
                    label3.Text += r1.CalcularArea();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    label4.Text = "É impossível construir um retângulo\ncom essas medidas!";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                label4.Text = "";
                label2.Text = "O valor do perimetro desse retângulo é de: ";
                label3.Text = "O valor da área desse retângulo é de: ";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o texto do TextBox pode ser convertido para double
            if (!double.TryParse(textBox1.Text, out double result))
            {
                if (textBox1.Text.Length > 0)
                {
                    // Remove o último caractere inserido
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    // Move o cursor para o final do texto
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else
                {
                    button2_Click(sender, e);
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o texto do TextBox pode ser convertido para double
            if (!double.TryParse(textBox2.Text, out double result))
            {
                if (textBox2.Text.Length > 0)
                {
                    // Remove o último caractere inserido
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    // Move o cursor para o final do texto
                    textBox2.SelectionStart = textBox2.Text.Length;
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else
                {
                    button2_Click(sender, e);
                }
            }
        }
    }
}