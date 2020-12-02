namespace $safeprojectname$
{
    partial class frmCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD));
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tslBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblRecrutamento = new System.Windows.Forms.Label();
            this.mtbRecrutamento = new System.Windows.Forms.MaskedTextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.BackColor = System.Drawing.Color.Transparent;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbAlterar,
            this.tsbExcluir,
            this.tslBuscar,
            this.tstBuscar,
            this.tsbSearch});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(684, 25);
            this.tspMenu.TabIndex = 0;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(55, 22);
            this.tsbNovo.Text = "Recrutar";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(46, 22);
            this.tsbAlterar.Text = "Alterar";
            this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(46, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tslBuscar
            // 
            this.tslBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tslBuscar.Name = "tslBuscar";
            this.tslBuscar.Size = new System.Drawing.Size(0, 22);
            this.tslBuscar.Text = "Buscar:";
            // 
            // tstBuscar
            // 
            this.tstBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.tstBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstBuscar.Name = "tstBuscar";
            this.tstBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbSearch.Text = "Procurar";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(45, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 15);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "Agente ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(132, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 18;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(368, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNome.Location = new System.Drawing.Point(423, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 20);
            this.txtNome.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(68, 167);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 15);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTitulo.Location = new System.Drawing.Point(132, 165);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 25;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.BackColor = System.Drawing.Color.Transparent;
            this.lblClasse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(368, 171);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(49, 15);
            this.lblClasse.TabIndex = 26;
            this.lblClasse.Text = "Classe:";
            // 
            // cmbClasse
            // 
            this.cmbClasse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "Controlador",
            "Duelista",
            "Iniciador",
            "Sentinela"});
            this.cmbClasse.Location = new System.Drawing.Point(423, 171);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(95, 21);
            this.cmbClasse.TabIndex = 27;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.Location = new System.Drawing.Point(19, 222);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(90, 15);
            this.lblNacionalidade.TabIndex = 28;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNacionalidade.Location = new System.Drawing.Point(132, 220);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidade.TabIndex = 29;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(493, 239);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(70, 88);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 30;
            this.picImagem.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(274, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 23);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Recrutar Agente";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowser.Location = new System.Drawing.Point(417, 292);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(70, 19);
            this.btnBrowser.TabIndex = 34;
            this.btnBrowser.Text = "Escolher...";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(319, 292);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(92, 15);
            this.lblFoto.TabIndex = 35;
            this.lblFoto.Text = "Foto do Agente:";
            // 
            // lblRecrutamento
            // 
            this.lblRecrutamento.AutoSize = true;
            this.lblRecrutamento.BackColor = System.Drawing.Color.Transparent;
            this.lblRecrutamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecrutamento.Location = new System.Drawing.Point(18, 281);
            this.lblRecrutamento.Name = "lblRecrutamento";
            this.lblRecrutamento.Size = new System.Drawing.Size(91, 15);
            this.lblRecrutamento.TabIndex = 36;
            this.lblRecrutamento.Text = "Recrutamento:";
            // 
            // mtbRecrutamento
            // 
            this.mtbRecrutamento.Location = new System.Drawing.Point(132, 282);
            this.mtbRecrutamento.Mask = "00/00/0000";
            this.mtbRecrutamento.Name = "mtbRecrutamento";
            this.mtbRecrutamento.Size = new System.Drawing.Size(64, 20);
            this.mtbRecrutamento.TabIndex = 37;
            this.mtbRecrutamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(319, 356);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 16);
            this.lblErro.TabIndex = 38;
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 445);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.mtbRecrutamento);
            this.Controls.Add(this.lblRecrutamento);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.lblNacionalidade);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripLabel tslBuscar;
        private System.Windows.Forms.ToolStripTextBox tstBuscar;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblRecrutamento;
        private System.Windows.Forms.MaskedTextBox mtbRecrutamento;
        private System.Windows.Forms.Label lblErro;
    }
}

