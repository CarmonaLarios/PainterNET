namespace AcesCEM.Forms
{
    partial class frmDesenharCroquisPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesenharCroquisPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFerramentas = new System.Windows.Forms.ToolStrip();
            this.tsBtnSelecionar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLinha = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSelecionarRetangulo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnElipse = new System.Windows.Forms.ToolStripButton();
            this.tsBtnTriangulo = new System.Windows.Forms.ToolStripButton();
            this.tsTextoHorizVert = new System.Windows.Forms.ToolStripSplitButton();
            this.textoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFonte = new System.Windows.Forms.ToolStripButton();
            this.tsLblCor1 = new System.Windows.Forms.ToolStripButton();
            this.tsTxtCorPrimaria = new System.Windows.Forms.ToolStripTextBox();
            this.tsLblCor2 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtCorSecundaria = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsXInicio = new System.Windows.Forms.ToolStripLabel();
            this.tsYInicio = new System.Windows.Forms.ToolStripLabel();
            this.tsLabelX = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLabelY = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.tsFerramentas.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem1
            // 
            this.arquivoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.arquivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.abrirToolStripMenuItem1,
            this.toolStripSeparator,
            this.salvarToolStripMenuItem,
            this.salvarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            this.arquivoToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem1.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem1.Image")));
            this.novoToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.novoToolStripMenuItem1.Text = "&Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem1.Image")));
            this.abrirToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.abrirToolStripMenuItem1.Text = "&Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarcomoToolStripMenuItem
            // 
            this.salvarcomoToolStripMenuItem.Name = "salvarcomoToolStripMenuItem";
            this.salvarcomoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salvarcomoToolStripMenuItem.Text = "Salvar &como";
            this.salvarcomoToolStripMenuItem.Click += new System.EventHandler(this.salvarcomoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tsFerramentas
            // 
            this.tsFerramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.tsFerramentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFerramentas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSelecionar,
            this.tsBtnLinha,
            this.tsBtnSelecionarRetangulo,
            this.tsBtnElipse,
            this.tsBtnTriangulo,
            this.tsTextoHorizVert,
            this.tsFonte,
            this.tsLblCor1,
            this.tsTxtCorPrimaria,
            this.tsLblCor2,
            this.tsTxtCorSecundaria});
            this.tsFerramentas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsFerramentas.Location = new System.Drawing.Point(0, 24);
            this.tsFerramentas.Name = "tsFerramentas";
            this.tsFerramentas.Size = new System.Drawing.Size(65, 426);
            this.tsFerramentas.TabIndex = 2;
            this.tsFerramentas.Text = "Ferramentas";
            // 
            // tsBtnSelecionar
            // 
            this.tsBtnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.tsBtnSelecionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSelecionar.Image")));
            this.tsBtnSelecionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSelecionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelecionar.Name = "tsBtnSelecionar";
            this.tsBtnSelecionar.Size = new System.Drawing.Size(62, 36);
            this.tsBtnSelecionar.Text = "Selecionar";
            this.tsBtnSelecionar.Click += new System.EventHandler(this.tsBtnSelecionar_Click);
            // 
            // tsBtnLinha
            // 
            this.tsBtnLinha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLinha.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLinha.Image")));
            this.tsBtnLinha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnLinha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLinha.Name = "tsBtnLinha";
            this.tsBtnLinha.Size = new System.Drawing.Size(62, 36);
            this.tsBtnLinha.Text = "Linha";
            this.tsBtnLinha.Click += new System.EventHandler(this.tsBtnLinha_Click);
            // 
            // tsBtnSelecionarRetangulo
            // 
            this.tsBtnSelecionarRetangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSelecionarRetangulo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSelecionarRetangulo.Image")));
            this.tsBtnSelecionarRetangulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSelecionarRetangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelecionarRetangulo.Name = "tsBtnSelecionarRetangulo";
            this.tsBtnSelecionarRetangulo.Size = new System.Drawing.Size(62, 36);
            this.tsBtnSelecionarRetangulo.Text = "Retângulo";
            this.tsBtnSelecionarRetangulo.Click += new System.EventHandler(this.tsBtnSelecionarQuadrado_Click);
            // 
            // tsBtnElipse
            // 
            this.tsBtnElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnElipse.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnElipse.Image")));
            this.tsBtnElipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnElipse.Name = "tsBtnElipse";
            this.tsBtnElipse.Size = new System.Drawing.Size(62, 36);
            this.tsBtnElipse.Text = "Circulo";
            this.tsBtnElipse.Click += new System.EventHandler(this.tsBtnElipse_Click);
            // 
            // tsBtnTriangulo
            // 
            this.tsBtnTriangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTriangulo.Image")));
            this.tsBtnTriangulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnTriangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTriangulo.Name = "tsBtnTriangulo";
            this.tsBtnTriangulo.Size = new System.Drawing.Size(62, 36);
            this.tsBtnTriangulo.Text = "Desenhar triângulo";
            this.tsBtnTriangulo.Click += new System.EventHandler(this.tsBtnTriangulo_Click);
            // 
            // tsTextoHorizVert
            // 
            this.tsTextoHorizVert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsTextoHorizVert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTextoHorizVert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoHorizontalToolStripMenuItem,
            this.textoVerticalToolStripMenuItem});
            this.tsTextoHorizVert.Image = ((System.Drawing.Image)(resources.GetObject("tsTextoHorizVert.Image")));
            this.tsTextoHorizVert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTextoHorizVert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTextoHorizVert.Margin = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.tsTextoHorizVert.Name = "tsTextoHorizVert";
            this.tsTextoHorizVert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsTextoHorizVert.Size = new System.Drawing.Size(48, 36);
            this.tsTextoHorizVert.Text = "Ferramenta de texto";
            this.tsTextoHorizVert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTextoHorizVert.ToolTipText = "Ferramenta texto";
            this.tsTextoHorizVert.ButtonClick += new System.EventHandler(this.tsTextoHorizVert_ButtonClick);
            // 
            // textoHorizontalToolStripMenuItem
            // 
            this.textoHorizontalToolStripMenuItem.Name = "textoHorizontalToolStripMenuItem";
            this.textoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.textoHorizontalToolStripMenuItem.Text = "Texto horizontal";
            this.textoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.textoHorizontalToolStripMenuItem_Click);
            // 
            // textoVerticalToolStripMenuItem
            // 
            this.textoVerticalToolStripMenuItem.Name = "textoVerticalToolStripMenuItem";
            this.textoVerticalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.textoVerticalToolStripMenuItem.Text = "Texto vertical";
            this.textoVerticalToolStripMenuItem.Click += new System.EventHandler(this.textoVerticalToolStripMenuItem_Click);
            // 
            // tsFonte
            // 
            this.tsFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFonte.Image = ((System.Drawing.Image)(resources.GetObject("tsFonte.Image")));
            this.tsFonte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFonte.Name = "tsFonte";
            this.tsFonte.Size = new System.Drawing.Size(62, 36);
            this.tsFonte.Text = "Escolher fonte";
            this.tsFonte.Click += new System.EventHandler(this.tsTexto_Click);
            // 
            // tsLblCor1
            // 
            this.tsLblCor1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLblCor1.ForeColor = System.Drawing.Color.White;
            this.tsLblCor1.Image = ((System.Drawing.Image)(resources.GetObject("tsLblCor1.Image")));
            this.tsLblCor1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLblCor1.Name = "tsLblCor1";
            this.tsLblCor1.Size = new System.Drawing.Size(62, 19);
            this.tsLblCor1.Text = "Cor";
            // 
            // tsTxtCorPrimaria
            // 
            this.tsTxtCorPrimaria.BackColor = System.Drawing.Color.Black;
            this.tsTxtCorPrimaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsTxtCorPrimaria.CausesValidation = false;
            this.tsTxtCorPrimaria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtCorPrimaria.ForeColor = System.Drawing.SystemColors.Menu;
            this.tsTxtCorPrimaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsTxtCorPrimaria.Name = "tsTxtCorPrimaria";
            this.tsTxtCorPrimaria.ReadOnly = true;
            this.tsTxtCorPrimaria.Size = new System.Drawing.Size(52, 16);
            this.tsTxtCorPrimaria.ToolTipText = "Clique para selecionar uma cor de contorno";
            this.tsTxtCorPrimaria.Click += new System.EventHandler(this.tsTxtCorPrimaria_Click);
            // 
            // tsLblCor2
            // 
            this.tsLblCor2.ForeColor = System.Drawing.Color.White;
            this.tsLblCor2.Name = "tsLblCor2";
            this.tsLblCor2.Size = new System.Drawing.Size(62, 15);
            this.tsLblCor2.Text = "Cor 2";
            this.tsLblCor2.Visible = false;
            // 
            // tsTxtCorSecundaria
            // 
            this.tsTxtCorSecundaria.BackColor = System.Drawing.Color.Black;
            this.tsTxtCorSecundaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsTxtCorSecundaria.CausesValidation = false;
            this.tsTxtCorSecundaria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtCorSecundaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsTxtCorSecundaria.MaxLength = 0;
            this.tsTxtCorSecundaria.Name = "tsTxtCorSecundaria";
            this.tsTxtCorSecundaria.ReadOnly = true;
            this.tsTxtCorSecundaria.Size = new System.Drawing.Size(52, 16);
            this.tsTxtCorSecundaria.ToolTipText = "Clique para selecionar uma cor de preenchimento";
            this.tsTxtCorSecundaria.Visible = false;
            this.tsTxtCorSecundaria.Click += new System.EventHandler(this.tsTxtCorSecundaria_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Black;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsXInicio,
            this.tsYInicio,
            this.tsLabelX,
            this.toolStripSeparator6,
            this.tsLabelY,
            this.toolStripSeparator7,
            this.toolStripSeparator8});
            this.toolStrip2.Location = new System.Drawing.Point(65, 425);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(735, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsXInicio
            // 
            this.tsXInicio.ForeColor = System.Drawing.Color.White;
            this.tsXInicio.Name = "tsXInicio";
            this.tsXInicio.Size = new System.Drawing.Size(29, 22);
            this.tsXInicio.Text = "X1:0";
            // 
            // tsYInicio
            // 
            this.tsYInicio.ForeColor = System.Drawing.Color.White;
            this.tsYInicio.Name = "tsYInicio";
            this.tsYInicio.Size = new System.Drawing.Size(29, 22);
            this.tsYInicio.Text = "Y1:0";
            // 
            // tsLabelX
            // 
            this.tsLabelX.ForeColor = System.Drawing.Color.White;
            this.tsLabelX.Name = "tsLabelX";
            this.tsLabelX.Size = new System.Drawing.Size(23, 22);
            this.tsLabelX.Text = "X:0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLabelY
            // 
            this.tsLabelY.ForeColor = System.Drawing.Color.White;
            this.tsLabelY.Name = "tsLabelY";
            this.tsLabelY.Size = new System.Drawing.Size(23, 22);
            this.tsLabelY.Text = "Y:0";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // frmDesenharCroquisPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tsFerramentas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDesenharCroquisPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainterNET  Alpha 0.0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDesenharCroquisPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmDesenharCroquisPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsFerramentas.ResumeLayout(false);
            this.tsFerramentas.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsFerramentas;
        private System.Windows.Forms.ToolStripButton tsBtnSelecionar;
        private System.Windows.Forms.ToolStripButton tsBtnLinha;
        private System.Windows.Forms.ToolStripButton tsBtnSelecionarRetangulo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsLabelX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tsLabelY;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel tsXInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel tsYInicio;
        private System.Windows.Forms.ToolStripButton tsBtnElipse;
        private System.Windows.Forms.ToolStripButton tsBtnTriangulo;
        private System.Windows.Forms.ToolStripButton tsFonte;
        private System.Windows.Forms.ToolStripButton tsLblCor1;
        private System.Windows.Forms.ToolStripLabel tsLblCor2;
        private System.Windows.Forms.ToolStripTextBox tsTxtCorPrimaria;
        private System.Windows.Forms.ToolStripTextBox tsTxtCorSecundaria;
        private System.Windows.Forms.ToolStripSplitButton tsTextoHorizVert;
        private System.Windows.Forms.ToolStripMenuItem textoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoVerticalToolStripMenuItem;
    }
}