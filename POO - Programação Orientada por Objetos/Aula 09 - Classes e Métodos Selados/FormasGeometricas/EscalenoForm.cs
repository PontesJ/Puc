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
    public partial class EscalenoForm : Form
    {
        public EscalenoForm()
        {
            InitializeComponent();
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
                else if (textBox3.Text == "")
                {
                    textBox3.Focus();
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
                else if (textBox3.Text == "")
                {
                    textBox3.Focus();
                }
                else
                {
                    button2_Click(sender, e);
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o texto do TextBox pode ser convertido para double
            if (!double.TryParse(textBox3.Text, out double result))
            {
                if (textBox3.Text.Length > 0)
                {
                    // Remove o último caractere inserido
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                    // Move o cursor para o final do texto
                    textBox3.SelectionStart = textBox3.Text.Length;
                }
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else
                {
                    button2_Click(sender, e);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "O valor do perimetro desse triângulo é de: ";
            label4.Text = "O valor da área desse triângulo é de: ";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if ((double.Parse(textBox1.Text) + double.Parse(textBox3.Text) > double.Parse(textBox2.Text) && double.Parse(textBox2.Text) + double.Parse(textBox3.Text) > double.Parse(textBox1.Text) && double.Parse(textBox2.Text) + double.Parse(textBox1.Text) > double.Parse(textBox3.Text)) && double.Parse(textBox2.Text) != 0 && double.Parse(textBox1.Text) != 0 && double.Parse(textBox3.Text) != 0)
                {
                    label6.Text = $"Com o primeiro lado de tamanho: {double.Parse(textBox1.Text)}\nO segundo lado de tamanho: {double.Parse(textBox2.Text)}\nE o terceiro lado de tamanho: {double.Parse(textBox3.Text)}";
                    Escaleno es1 = new Escaleno(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                    label5.Text += es1.CalcularPerimetro();
                    label4.Text += es1.CalcularArea();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    label6.Text = "É impossível construir um triângulo escaleno\ncom essas medidas!";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                label6.Text = "";
                label5.Text = "O valor do perimetro desse triângulo é de: ";
                label4.Text = "O valor da área desse triângulo é de: ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriangulosForm form1 = new TriangulosForm();
            form1.Show();
            Close();
        }
    }
}
