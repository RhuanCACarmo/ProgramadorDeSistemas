using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulariosimples
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoM;
            bool generoF;
            bool generoNI;
            bool generoO;

            

            //Validação de campos obrigatórios

            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.");
                return;
            }

            //validação de data de nascimento usando DateTimePicker
            dataNascimento = dateTimePicker1.Value.Date;

            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //verifica se a data é posterio ou igual à data atual
            if (dataNascimento >= DateTime.Now.Date) //Compara com a data atual sem a hora
            {
                MessageBox.Show("Verifique novamente sua data de nascimento.");
                return;
            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade.");
                return;
            }
            if (!rbMasculino.Checked && !rbFeminino.Checked && !rbNaoInformar.Checked && !rbOutro.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero");
                return;
            }

            //Agora, caso todos os campos estejam preenchidos, a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNI = rbNaoInformar.Checked;
            generoO = rbOutro.Checked;

            

            //Determinar  gênero selecionado

            string generoSelecionado = "Não Informado"; //Caso nenhum gênero seja selecionado
            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else if (generoNI)
                generoSelecionado = "Preferiu não informar";
            else if (generoO)
                generoSelecionado = "Outro";

            //Exibir as informações em MessageBox
            MessageBox.Show("Número Cadastro: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero: " + generoSelecionado);
        }

        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            if (txtNumeroCadastro.Text == "Número Cadastro")
            {
                txtNumeroCadastro.Text = "";
            }
 
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "Insira seu nome completo")
            {
                txtNomeCompleto.Text = "";
            }
        }
    }
}
