using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private ClientesDAO banco = new ClientesDAO();
        public Form1()
        {
            InitializeComponent();
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text != "" && textBox2.Text != ""))
            {
                label3.Text = "Por Favor, preencha todos os campos!!";

            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[\w-\.]+@([\w-]+\.)+com$"))
                {
                    label3.Text = "E-mail Inválido!!";
                    textBox2.Focus();
                }
                else
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        label3.Text = "";
                        Cliente c1 = new Cliente(textBox1.Text, textBox2.Text);
                        banco.addCliente(c1);

                        Listar();
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
        private void Listar()
        {
            List<Cliente> clientes = banco.listarClientes();
            listBox1.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                listBox1.Items.Add($"Nome: {cliente.getNome()} | Email: {cliente.getEmail()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            banco.excluirArquivo();
            listBox1.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Focus();
                    }
                    else
                    {
                        button1_Click(sender, e);
                    }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox2.Text != "")
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Focus();
                    }
                    else
                    {
                        button1_Click(sender, e);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z\u00C0-\u00FF ]*$"))
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                banco.removCliente(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}