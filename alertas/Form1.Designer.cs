
namespace alertas
{
    partial class frmAlertas
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAlertaSimples = new System.Windows.Forms.Button();
            this.btnAlertaRobusto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(330, 59);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste os alertas abaixo";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAlertaSimples
            // 
            this.btnAlertaSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.btnAlertaSimples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaSimples.ForeColor = System.Drawing.Color.White;
            this.btnAlertaSimples.Location = new System.Drawing.Point(412, 112);
            this.btnAlertaSimples.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlertaSimples.Name = "btnAlertaSimples";
            this.btnAlertaSimples.Size = new System.Drawing.Size(137, 28);
            this.btnAlertaSimples.TabIndex = 1;
            this.btnAlertaSimples.Text = "Alerta Simples";
            this.btnAlertaSimples.UseVisualStyleBackColor = false;
            this.btnAlertaSimples.Click += new System.EventHandler(this.btnAlertaSimples_Click);
            // 
            // btnAlertaRobusto
            // 
            this.btnAlertaRobusto.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAlertaRobusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.btnAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlertaRobusto.ForeColor = System.Drawing.Color.White;
            this.btnAlertaRobusto.Location = new System.Drawing.Point(412, 163);
            this.btnAlertaRobusto.Name = "btnAlertaRobusto";
            this.btnAlertaRobusto.Size = new System.Drawing.Size(137, 29);
            this.btnAlertaRobusto.TabIndex = 2;
            this.btnAlertaRobusto.Text = "Alerta Robusto";
            this.btnAlertaRobusto.UseVisualStyleBackColor = false;
            this.btnAlertaRobusto.Click += new System.EventHandler(this.btnAlertaRobusto_Click);
            // 
            // frmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 567);
            this.Controls.Add(this.btnAlertaRobusto);
            this.Controls.Add(this.btnAlertaSimples);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAlertas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAlertaSimples;
        private System.Windows.Forms.Button btnAlertaRobusto;
    }
}

