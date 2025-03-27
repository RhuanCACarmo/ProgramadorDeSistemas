using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class frmPictureBox : Form
    {
        private string ImagemLocalizada;
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\rhuan.cacarmo\Downloads\masp-sp.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;

            pbPessoa.Image = Image.FromFile(@"C:\Users\rhuan.cacarmo\Downloads\fotopessoa.png");
            pbPessoa.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexarImagem_Click(object sender, EventArgs e)
        {
            try
            {


                //caixa de diálogo para abrir arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*jpg) | *.jpg | png files (*.png) | *.png | All Files (*.*) | *.*";
                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImagemLocalizada = abrirarquivo.FileName;
                    pbUploadImagem.ImageLocation = ImagemLocalizada;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
