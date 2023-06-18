﻿using System;
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
    public partial class QuadradoForm : Form
    {
        public QuadradoForm()
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
            label2.Text = "O valor do perimetro desse quadrado é de: ";
            label3.Text = "O valor da área desse quadrado é de: ";
            if (textBox1.Text != "")
            {
                label4.Text = $"Com o lado de tamanho: {double.Parse(textBox1.Text)}";
                Quadrado q1 = new Quadrado(double.Parse(textBox1.Text));
                label2.Text += q1.CalcularPerimetro();
                label3.Text += q1.CalcularArea();
                textBox1.Text = "";
            }
            else
            {
                label4.Text = "";
                label2.Text = "O valor do perimetro desse quadrado é de: ";
                label3.Text = "O valor da área desse quadrado é de: ";
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