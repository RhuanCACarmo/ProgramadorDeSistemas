using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogoDeNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpiteJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoDeNumeros()
        {
            InitializeComponent();
        }

        private void frmJogoDeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            if(numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou!";
                return;
            }

            if (!int.TryParse(txtNumeroInserido.Text, out palpiteJogador) || palpiteJogador < 1 || palpiteJogador > 100) 
            {
                txtResultado.Text = "Por favor, insira um numero entre 1 e 100.";
                return;
            }
            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();


                if (palpiteJogador == randomNumber)
                {
                    jogoGanho = true;
                    dica = "Parabéns, Você Acertou!";
                }
                else if (palpiteJogador < randomNumber)
                {
                    dica = "Você errou, tente um número mais alto.";
                }
                else
                {
                    dica = "Você errou, tente um número mais baixo.";
                }

                txtResultado.Text = dica;
            }
        }
    }