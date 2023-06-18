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
    public partial class TriangulosForm : Form
    {
        public TriangulosForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InicioForm form1 = new InicioForm();
            form1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscalenoForm form4 = new EscalenoForm();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EquilateroForm form2 = new EquilateroForm();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsoscelesForm form3 = new IsoscelesForm();
            form3.Show();
            this.Hide();
        }
    }
}
