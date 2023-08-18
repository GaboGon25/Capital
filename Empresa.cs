using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Aporte1, Aporte2, Aporte3, Capital, Pctj1, Pctj2, Pctj3;

            Aporte1 = double.Parse(txtSocio1.Text);
            Aporte2 = double.Parse(txtSocio2.Text);
            Aporte3 = double.Parse(txtSocio3.Text);

            Capital = (Aporte1 + Aporte2 + Aporte3);

            txtCapital.Text = Capital.ToString();

            Pctj1 = (Aporte1 * 100) / Capital;

            txtPor1.Text = Pctj1.ToString(); 

            Pctj2 = (Aporte2 * 100) / Capital;

            txtPor2.Text = Pctj2.ToString();

            Pctj3 = (Aporte3 * 100) / Capital;

            txtPor3.Text = Pctj3.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtSocio1.Clear();
            txtSocio2.Clear();
            txtSocio3.Clear();
            txtCapital.Clear();
            txtPor1.Clear();
            txtPor2.Clear();
            txtPor3.Clear();

        }
    }
}
