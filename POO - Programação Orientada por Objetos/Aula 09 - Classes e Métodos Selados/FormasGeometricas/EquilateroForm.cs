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
    public partial class EquilateroForm : Form
    {
        public EquilateroForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TriangulosForm form1 = new TriangulosForm();
            form1.Show();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "O valor do perimetro desse triângulo é de: ";
            label3.Text = "O valor da área desse triângulo é de: ";
            if (textBox1.Text != "")
            {
                label4.Text = $"Com o lado de tamanho: {double.Parse(textBox1.Text)}";
                Equilatero eq1 = new Equilatero(double.Parse(textBox1.Text));
                label2.Text += eq1.CalcularPerimetro();
                label3.Text += eq1.CalcularArea();
                textBox1.Text = "";
            }
            else
            {
                label4.Text = "";
                label2.Text = "O valor do perimetro desse triângulo é de: ";
                label3.Text = "O valor da área desse triângulo é de: ";
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
                button2_Click(sender, e);
            }
        }
    }
}
