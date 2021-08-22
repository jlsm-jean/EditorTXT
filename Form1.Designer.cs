
namespace TXT_EDITOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRafazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomApliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibirAjudar = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBarNovo = new System.Windows.Forms.ToolStripButton();
            this.toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarDesfazer = new System.Windows.Forms.ToolStripButton();
            this.toolBarRefazer = new System.Windows.Forms.ToolStripButton();
            this.toolBarRecortar = new System.Windows.Forms.ToolStripButton();
            this.toolBarCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolBarColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarFonte = new System.Windows.Forms.ToolStripButton();
            this.toolBarAmpliar = new System.Windows.Forms.ToolStripButton();
            this.toolBarReduzir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarSair = new System.Windows.Forms.ToolStripButton();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 31);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator3,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator4,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(82, 27);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::TXT_EDITOR.Properties.Resources.Novo;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(283, 28);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::TXT_EDITOR.Properties.Resources.Windows1;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(283, 28);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::TXT_EDITOR.Properties.Resources.Abrir;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(283, 28);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::TXT_EDITOR.Properties.Resources.Salvar;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(283, 28);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(283, 28);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(280, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::TXT_EDITOR.Properties.Resources.sair;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(283, 28);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRafazer,
            this.toolStripSeparator1,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator2,
            this.mEditarDataHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(66, 27);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Image = global::TXT_EDITOR.Properties.Resources.Defazer;
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(244, 28);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRafazer
            // 
            this.mEditarRafazer.Image = global::TXT_EDITOR.Properties.Resources.Rafazer;
            this.mEditarRafazer.Name = "mEditarRafazer";
            this.mEditarRafazer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mEditarRafazer.Size = new System.Drawing.Size(244, 28);
            this.mEditarRafazer.Text = "Rafazer";
            this.mEditarRafazer.Click += new System.EventHandler(this.mEditarRafazer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Image = global::TXT_EDITOR.Properties.Resources.Recortar;
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(244, 28);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Image = global::TXT_EDITOR.Properties.Resources.Copiar;
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(244, 28);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Image = global::TXT_EDITOR.Properties.Resources.Colar;
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(244, 28);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Image = global::TXT_EDITOR.Properties.Resources.Delete;
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditarExcluir.Size = new System.Drawing.Size(244, 28);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // mEditarDataHora
            // 
            this.mEditarDataHora.Image = global::TXT_EDITOR.Properties.Resources.DataHora;
            this.mEditarDataHora.Name = "mEditarDataHora";
            this.mEditarDataHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataHora.Size = new System.Drawing.Size(244, 28);
            this.mEditarDataHora.Text = "Data e Hora";
            this.mEditarDataHora.Click += new System.EventHandler(this.mEditarDataHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(92, 27);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            this.mFormatarQuebraLinha.CheckOnClick = true;
            this.mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            this.mFormatarQuebraLinha.Size = new System.Drawing.Size(294, 28);
            this.mFormatarQuebraLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraLinha.Click += new System.EventHandler(this.mFormatarQuebraLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(294, 28);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(64, 27);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomApliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(194, 28);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomApliar
            // 
            this.mExibirZoomApliar.Name = "mExibirZoomApliar";
            this.mExibirZoomApliar.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            this.mExibirZoomApliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomApliar.Size = new System.Drawing.Size(335, 28);
            this.mExibirZoomApliar.Text = "Ampliar";
            this.mExibirZoomApliar.Click += new System.EventHandler(this.mExibirZoomApliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(335, 28);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(335, 28);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirStatus
            // 
            this.mExibirStatus.Checked = true;
            this.mExibirStatus.CheckOnClick = true;
            this.mExibirStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirStatus.Name = "mExibirStatus";
            this.mExibirStatus.Size = new System.Drawing.Size(194, 28);
            this.mExibirStatus.Text = "Barra de status";
            this.mExibirStatus.Click += new System.EventHandler(this.mExibirStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibirAjudar,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(66, 27);
            this.mAjuda.Text = "Ajuda";
            this.mAjuda.Click += new System.EventHandler(this.mAjuda_Click);
            // 
            // mAjudaExibirAjudar
            // 
            this.mAjudaExibirAjudar.Name = "mAjudaExibirAjudar";
            this.mAjudaExibirAjudar.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibirAjudar.Size = new System.Drawing.Size(223, 28);
            this.mAjudaExibirAjudar.Text = "Exibir Ajuda";
            this.mAjudaExibirAjudar.Click += new System.EventHandler(this.mAjudaExibirAjudar_Click);
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(223, 28);
            this.mAjudaSobre.Text = "Sobre o Editor TXT";
            this.mAjudaSobre.Click += new System.EventHandler(this.mAjudaSobre_Click);
            // 
            // statusBarLabel3
            // 
            this.statusBarLabel3.Name = "statusBarLabel3";
            this.statusBarLabel3.Size = new System.Drawing.Size(23, 23);
            // 
            // statusBarLabel2
            // 
            this.statusBarLabel2.Name = "statusBarLabel2";
            this.statusBarLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // statusBarLabel1
            // 
            this.statusBarLabel1.Name = "statusBarLabel1";
            this.statusBarLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(44, 17);
            this.statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.OldLace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarNovo,
            this.toolBarAbrir,
            this.toolBarSalvar,
            this.toolStripSeparator5,
            this.toolBarDesfazer,
            this.toolBarRefazer,
            this.toolBarRecortar,
            this.toolBarCopiar,
            this.toolBarColar,
            this.toolStripSeparator6,
            this.toolBarFonte,
            this.toolBarAmpliar,
            this.toolBarReduzir,
            this.toolStripSeparator7,
            this.toolBarSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 42);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNovo
            // 
            this.toolBarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarNovo.Image = global::TXT_EDITOR.Properties.Resources.Novo;
            this.toolBarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarNovo.Name = "toolBarNovo";
            this.toolBarNovo.Size = new System.Drawing.Size(23, 39);
            this.toolBarNovo.Text = "Novo";
            this.toolBarNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // toolBarAbrir
            // 
            this.toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAbrir.Image = global::TXT_EDITOR.Properties.Resources.Abrir;
            this.toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAbrir.Name = "toolBarAbrir";
            this.toolBarAbrir.Size = new System.Drawing.Size(23, 39);
            this.toolBarAbrir.Text = "Abrir";
            this.toolBarAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // toolBarSalvar
            // 
            this.toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSalvar.Image = global::TXT_EDITOR.Properties.Resources.Salvar;
            this.toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSalvar.Name = "toolBarSalvar";
            this.toolBarSalvar.Size = new System.Drawing.Size(23, 39);
            this.toolBarSalvar.Text = "Salvar";
            this.toolBarSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // toolBarDesfazer
            // 
            this.toolBarDesfazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarDesfazer.Image = global::TXT_EDITOR.Properties.Resources.Defazer;
            this.toolBarDesfazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarDesfazer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.toolBarDesfazer.Name = "toolBarDesfazer";
            this.toolBarDesfazer.Size = new System.Drawing.Size(23, 39);
            this.toolBarDesfazer.Text = "Desfazer";
            this.toolBarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // toolBarRefazer
            // 
            this.toolBarRefazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarRefazer.Image = global::TXT_EDITOR.Properties.Resources.Rafazer;
            this.toolBarRefazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarRefazer.Name = "toolBarRefazer";
            this.toolBarRefazer.Size = new System.Drawing.Size(23, 39);
            this.toolBarRefazer.Text = "Rafazer";
            this.toolBarRefazer.Click += new System.EventHandler(this.mEditarRafazer_Click);
            // 
            // toolBarRecortar
            // 
            this.toolBarRecortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarRecortar.Image = global::TXT_EDITOR.Properties.Resources.Recortar;
            this.toolBarRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarRecortar.Name = "toolBarRecortar";
            this.toolBarRecortar.Size = new System.Drawing.Size(23, 39);
            this.toolBarRecortar.Text = "Recortar";
            this.toolBarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // toolBarCopiar
            // 
            this.toolBarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarCopiar.Image = global::TXT_EDITOR.Properties.Resources.Copiar;
            this.toolBarCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarCopiar.Name = "toolBarCopiar";
            this.toolBarCopiar.Size = new System.Drawing.Size(23, 39);
            this.toolBarCopiar.Text = "Copiar";
            this.toolBarCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolBarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // toolBarColar
            // 
            this.toolBarColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarColar.Image = global::TXT_EDITOR.Properties.Resources.Colar;
            this.toolBarColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarColar.Name = "toolBarColar";
            this.toolBarColar.Size = new System.Drawing.Size(23, 39);
            this.toolBarColar.Text = "Colar";
            this.toolBarColar.ToolTipText = "Colar";
            this.toolBarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 42);
            // 
            // toolBarFonte
            // 
            this.toolBarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarFonte.Font = new System.Drawing.Font("Tahoma", 11.13402F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFonte.Image")));
            this.toolBarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFonte.Name = "toolBarFonte";
            this.toolBarFonte.Size = new System.Drawing.Size(23, 39);
            this.toolBarFonte.Text = "A";
            this.toolBarFonte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBarFonte.ToolTipText = "Formatar Fonte";
            this.toolBarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // toolBarAmpliar
            // 
            this.toolBarAmpliar.Font = new System.Drawing.Font("Arial", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarAmpliar.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolBarAmpliar.Image = global::TXT_EDITOR.Properties.Resources.zoom_29453;
            this.toolBarAmpliar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAmpliar.Name = "toolBarAmpliar";
            this.toolBarAmpliar.Size = new System.Drawing.Size(38, 39);
            this.toolBarAmpliar.Text = "   +";
            this.toolBarAmpliar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolBarAmpliar.ToolTipText = "Ampliar";
            this.toolBarAmpliar.Click += new System.EventHandler(this.mExibirZoomApliar_Click);
            // 
            // toolBarReduzir
            // 
            this.toolBarReduzir.Font = new System.Drawing.Font("Javanese Text", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolBarReduzir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolBarReduzir.Image = global::TXT_EDITOR.Properties.Resources.zoom_29453;
            this.toolBarReduzir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarReduzir.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarReduzir.Name = "toolBarReduzir";
            this.toolBarReduzir.Size = new System.Drawing.Size(35, 42);
            this.toolBarReduzir.Text = "  -";
            this.toolBarReduzir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolBarReduzir.ToolTipText = "Reduzir";
            this.toolBarReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 42);
            // 
            // toolBarSair
            // 
            this.toolBarSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSair.Image = global::TXT_EDITOR.Properties.Resources.sair;
            this.toolBarSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSair.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.toolBarSair.Name = "toolBarSair";
            this.toolBarSair.Size = new System.Drawing.Size(23, 39);
            this.toolBarSair.Text = "Sair";
            this.toolBarSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Location = new System.Drawing.Point(0, 73);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 466);
            this.txtConteudo.TabIndex = 5;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor_TXT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRafazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mEditarDataHora;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomApliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibirAjudar;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBarNovo;
        private System.Windows.Forms.ToolStripButton toolBarAbrir;
        private System.Windows.Forms.ToolStripButton toolBarSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolBarDesfazer;
        private System.Windows.Forms.ToolStripButton toolBarRefazer;
        private System.Windows.Forms.ToolStripButton toolBarRecortar;
        private System.Windows.Forms.ToolStripButton toolBarCopiar;
        private System.Windows.Forms.ToolStripButton toolBarColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolBarFonte;
        private System.Windows.Forms.ToolStripButton toolBarAmpliar;
        private System.Windows.Forms.ToolStripButton toolBarReduzir;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolBarSair;
    }
}

