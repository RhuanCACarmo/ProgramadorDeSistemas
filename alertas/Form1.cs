using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class frmAlertas : Form
    {
        public frmAlertas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse é um alerta simples", "Com título");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?", "Alerta!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Você respondeu que sim!","Sim :)");
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Você respondeu que não","Não :(");
            }
        }
    }
}
