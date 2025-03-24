
namespace calculodeidade
{
    partial class frmCalculoDeIdade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblAnoAtual);
            this.panel1.Controls.Add(this.lblAnoNasc);
            this.panel1.Controls.Add(this.txtAnoAtual);
            this.panel1.Controls.Add(this.txtAnoNasc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 363);
            this.panel1.TabIndex = 4;
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(78, 99);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(105, 20);
            this.txtAnoNasc.TabIndex = 0;
            this.txtAnoNasc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(80, 176);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 20);
            this.txtAnoAtual.TabIndex = 1;
            this.txtAnoAtual.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasc.Location = new System.Drawing.Point(42, 56);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(177, 24);
            this.lblAnoNasc.TabIndex = 2;
            this.lblAnoNasc.Text = "Ano de Nascimento";
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoAtual.Location = new System.Drawing.Point(84, 138);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(92, 24);
            this.lblAnoAtual.TabIndex = 3;
            this.lblAnoAtual.Text = "Ano Atual";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(117, 218);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(26, 29);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(87, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculoDeIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 363);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculoDeIdade";
            this.Text = "Calculo de Idade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasc;
    }
}

