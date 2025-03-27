
namespace picturebox
{
    partial class frmPictureBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.pbPessoa = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbUploadImagem = new System.Windows.Forms.PictureBox();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPessoa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(27, 12);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(373, 161);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 1;
            this.pbComputador.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.Location = new System.Drawing.Point(448, 367);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(106, 52);
            this.btnVerImagem.TabIndex = 4;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = true;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(406, 12);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(366, 161);
            this.pbCidade.TabIndex = 5;
            this.pbCidade.TabStop = false;
            // 
            // pbPessoa
            // 
            this.pbPessoa.Location = new System.Drawing.Point(406, 179);
            this.pbPessoa.Name = "pbPessoa";
            this.pbPessoa.Size = new System.Drawing.Size(366, 161);
            this.pbPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPessoa.TabIndex = 6;
            this.pbPessoa.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnAnexarImagem);
            this.panel1.Controls.Add(this.pbUploadImagem);
            this.panel1.Location = new System.Drawing.Point(27, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 240);
            this.panel1.TabIndex = 7;
            // 
            // pbUploadImagem
            // 
            this.pbUploadImagem.Location = new System.Drawing.Point(51, 31);
            this.pbUploadImagem.Name = "pbUploadImagem";
            this.pbUploadImagem.Size = new System.Drawing.Size(135, 161);
            this.pbUploadImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUploadImagem.TabIndex = 8;
            this.pbUploadImagem.TabStop = false;
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.Location = new System.Drawing.Point(67, 198);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(100, 34);
            this.btnAnexarImagem.TabIndex = 9;
            this.btnAnexarImagem.Text = "Anexar Imagem";
            this.btnAnexarImagem.UseVisualStyleBackColor = true;
            this.btnAnexarImagem.Click += new System.EventHandler(this.btnAnexarImagem_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPessoa);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbComputador);
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPessoa)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.PictureBox pbPessoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnexarImagem;
        private System.Windows.Forms.PictureBox pbUploadImagem;
    }
}

