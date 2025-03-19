using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodeidade
{
    public partial class frmCalculoDeIdade : Form
    {
        public frmCalculoDeIdade()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anonascimento, anoatual, idade;

            anonascimento = int.Parse(txtAnoNasc.Text);
            anoatual = int.Parse(txtAnoAtual.Text);
            idade = anoatual - anonascimento;

            lblIdade.Text = idade.ToString();
        }
    }
}
