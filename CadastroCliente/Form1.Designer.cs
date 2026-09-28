namespace CadastroCliente
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.tituloTela = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.subTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloTela
            // 
            this.tituloTela.AutoSize = true;
            this.tituloTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloTela.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTela.Location = new System.Drawing.Point(55, 9);
            this.tituloTela.Name = "tituloTela";
            this.tituloTela.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.tituloTela.Size = new System.Drawing.Size(412, 38);
            this.tituloTela.TabIndex = 0;
            this.tituloTela.Text = "Seja Bem-Vindo!";
            this.tituloTela.Click += new System.EventHandler(this.tituloTela_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cadastrar.FlatAppearance.BorderSize = 2;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cadastrar.Location = new System.Drawing.Point(173, 113);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(180, 37);
            this.cadastrar.TabIndex = 1;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.consultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.consultar.FlatAppearance.BorderSize = 2;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.consultar.Location = new System.Drawing.Point(173, 156);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(180, 37);
            this.consultar.TabIndex = 2;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.atualizar.FlatAppearance.BorderSize = 2;
            this.atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.atualizar.Location = new System.Drawing.Point(173, 199);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(180, 37);
            this.atualizar.TabIndex = 3;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.Red;
            this.excluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.excluir.FlatAppearance.BorderSize = 2;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.excluir.Location = new System.Drawing.Point(173, 242);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(180, 37);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // subTitulo
            // 
            this.subTitulo.AutoSize = true;
            this.subTitulo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitulo.Location = new System.Drawing.Point(127, 59);
            this.subTitulo.Name = "subTitulo";
            this.subTitulo.Size = new System.Drawing.Size(290, 26);
            this.subTitulo.TabIndex = 5;
            this.subTitulo.Text = "Escolha uma das opções abaixo:";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 321);
            this.Controls.Add(this.subTitulo);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.tituloTela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 360);
            this.MinimumSize = new System.Drawing.Size(549, 360);
            this.Name = "TelaCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloTela;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Label subTitulo;
    }
}

