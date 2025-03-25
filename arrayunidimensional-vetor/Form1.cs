using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayunidimensional_vetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };

            //MessageBox.Show(pecasComputador[2],"Peça Escolhida");

            foreach (string peca in pecasComputador)
                MessageBox.Show(peca);
        }
    }
}
