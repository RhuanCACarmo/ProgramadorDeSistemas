
namespace formulariosimples
{
    partial class frmFormularioSimples
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
            this.lblDataDeNasc = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumeroCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbNaoInformar = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataDeNasc
            // 
            this.lblDataDeNasc.AutoSize = true;
            this.lblDataDeNasc.Location = new System.Drawing.Point(38, 150);
            this.lblDataDeNasc.Name = "lblDataDeNasc";
            this.lblDataDeNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataDeNasc.TabIndex = 0;
            this.lblDataDeNasc.Text = "Data de Nascimento:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(38, 203);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtNumeroCadastro
            // 
            this.txtNumeroCadastro.Location = new System.Drawing.Point(41, 43);
            this.txtNumeroCadastro.Name = "txtNumeroCadastro";
            this.txtNumeroCadastro.Size = new System.Drawing.Size(135, 20);
            this.txtNumeroCadastro.TabIndex = 2;
            this.txtNumeroCadastro.Text = "Número Cadastro";
            this.txtNumeroCadastro.Click += new System.EventHandler(this.txtNumeroCadastro_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(41, 102);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(222, 20);
            this.txtNomeCompleto.TabIndex = 3;
            this.txtNomeCompleto.Text = "Insira seu nome completo";
            this.txtNomeCompleto.Click += new System.EventHandler(this.txtNomeCompleto_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Manaus",
            "Salvador",
            "Brasília"});
            this.comboBoxCidade.Location = new System.Drawing.Point(88, 200);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCidade.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOutro);
            this.groupBox1.Controls.Add(this.rbNaoInformar);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(41, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(354, 44);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(51, 17);
            this.rbOutro.TabIndex = 3;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // rbNaoInformar
            // 
            this.rbNaoInformar.AutoSize = true;
            this.rbNaoInformar.Location = new System.Drawing.Point(214, 44);
            this.rbNaoInformar.Name = "rbNaoInformar";
            this.rbNaoInformar.Size = new System.Drawing.Size(120, 17);
            this.rbNaoInformar.TabIndex = 2;
            this.rbNaoInformar.TabStop = true;
            this.rbNaoInformar.Text = "Prefino não Informar";
            this.rbNaoInformar.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(110, 44);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 44);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(201, 374);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 39);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmFormularioSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtNumeroCadastro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblDataDeNasc);
            this.Name = "frmFormularioSimples";
            this.Text = "Formulário Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDeNasc;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtNumeroCadastro;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbNaoInformar;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

