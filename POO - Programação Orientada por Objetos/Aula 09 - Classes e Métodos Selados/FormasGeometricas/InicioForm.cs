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
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CirculoForm form2 = new CirculoForm();
            form2.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TriangulosForm form3 = new TriangulosForm();
            form3.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuadradoForm form4 = new QuadradoForm();
            form4.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RetanguloForm form5 = new RetanguloForm();
            form5.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PentagonoForm form6 = new PentagonoForm();
            form6.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HexagonoForm form7 = new HexagonoForm();
            form7.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OctogonoForm form8 = new OctogonoForm();
            form8.Show();
            Hide();
        }
    }
}
