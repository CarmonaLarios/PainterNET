using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static AcesCEM.Classes.TiposFormas;

namespace AcesCEM.Forms
{
    public partial class frmDesenharCroquisPrincipal : Form
    {
        private int x;
        private int y;
        private int x1;
        private int y1;
        private Rectangle rectangle;
        private Color corPrimaria = Color.Black;
        private Color corSecundaria = Color.Empty;
        private ETipoForma formaSelecionada;
        private EPosicaoTexto posicaoTexto;
        private Font selectedFont;
        private Color fontColor;



        Forms.frmEdicaoCroqui frmFilhoCroqui;
        public frmDesenharCroquisPrincipal()
        {
            InitializeComponent();
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public Color CorPrimaria { get => corPrimaria; set => corPrimaria = value; }
        public Color CorSecundaria { get => corSecundaria; set => corSecundaria = value; }
        public Classes.TiposFormas.ETipoForma FormaSelecionada { get => formaSelecionada; set => formaSelecionada = value; }
        public EPosicaoTexto PosicaoTexto { get => posicaoTexto; set => posicaoTexto = value; }
        public Font SelectedFont { get => selectedFont; set => selectedFont = value; }
        public Color FontColor { get => fontColor; set => fontColor = value; }

        public enum EPosicaoTexto
        {
            horizontal,
            vertical
        }

        private bool CriouFormFilho()
        {
            return (frmFilhoCroqui != null);
        }
        private Color DefinirCor(ToolStripTextBox btn)
        {
            Color result = Color.Black;
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = dlg.Color;
                result = dlg.Color;
            }

            return result;
        }

        private void DefineFontePadrao()
        {
            selectedFont = new Font("Arial", 16);
        }

        private void SelectFont()
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;

            if (font.ShowDialog() != DialogResult.Cancel)
            {
                selectedFont = font.Font;
                fontColor = font.Color;
            }
        }

        private void SetFontFormFilho()
        {
            if (CriouFormFilho())
            {
                frmFilhoCroqui.SelectedFont = selectedFont;
                frmFilhoCroqui.FontColor = fontColor;
            }
        }

        private void SetDadosFormFilho()
        {
            if (CriouFormFilho())
            {
                frmFilhoCroqui.ResetaCoordenadasMouse();
                frmFilhoCroqui.SetSelecionandoArea();
            }
        }

        private void SetTextoFormFilho()
        {
            if (CriouFormFilho())
            {
                frmFilhoCroqui.SetTextPosition();
            }
        }

        private void LimpaSelecaoFormFilho()
        {
            frmFilhoCroqui.LimpaSelecao();
        }

        public void DefineXY(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
            tsLabelX.Text = x.ToString();
            tsLabelY.Text = y.ToString();
        }
        public void DefineInicioFigura(int _x1, int _y1)
        {
            this.x1 = _x1;
            this.y1 = _y1;
            tsXInicio.Text = x1.ToString();
            tsYInicio.Text = y1.ToString();
        }

        private void FecharFormsFilhos()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void AbrirArquivo()
        {
            bool carregouArquivo = false;
            OpenFileDialog fl = new OpenFileDialog();
            fl.InitialDirectory = Application.StartupPath.Replace("bin", @"\comum\Croquis");
            fl.Filter = "Arquivos de imagem|*.jpeg;*.png;*.jpg;*.bmp";

            if (fl.ShowDialog() == DialogResult.OK)
            {

                if (fl.FileName != "")
                {
                    Bitmap croquiSelecionado = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        try
                        {
                            if (CriouFormFilho())
                            {
                                if (fl.FileName == frmFilhoCroqui.Croqui) return;
                            }

                            FecharFormsFilhos();

                            using (FileStream fs = new FileStream(fl.FileName, FileMode.Open))
                            {
                                byte[] buffer = new byte[fs.Length];
                                fs.Read(buffer, 0, buffer.Length);
                                ms.Write(buffer, 0, buffer.Length);

                                croquiSelecionado = new Bitmap(ms);
                                croquiSelecionado.Save("tmp.png");
                                carregouArquivo = true;
                                //Bitmap croquiSelecionado = (Bitmap)Image.FromFile(fl.FileName);
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }

                    if (carregouArquivo)
                    {
                        frmFilhoCroqui = new frmEdicaoCroqui(this, croquiSelecionado, fl.FileName);
                        frmFilhoCroqui.MdiParent = this;
                        frmFilhoCroqui.Show();
                        tsLabelX.Text = frmFilhoCroqui.X.ToString();
                        tsLabelY.Text = frmFilhoCroqui.Y.ToString();
                    }

                }
            }
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FecharFormsFilhos();
            frmDesenhoTamanho frmValidacao = new frmDesenhoTamanho();
            frmValidacao.ShowDialog();
            //frmValidacao.LarguraDesenho = 500;
            //frmValidacao.AlturaDesenho = 500;
            if (frmValidacao.TemTamanhoValido)
            {
                //frm = new frmEdicaoCroqui("", this);
                frmFilhoCroqui = new frmEdicaoCroqui(this, frmValidacao.LarguraDesenho, frmValidacao.AlturaDesenho);
                frmFilhoCroqui.MdiParent = this;
                frmFilhoCroqui.Show();
                tsLabelX.Text = frmFilhoCroqui.X.ToString();
                tsLabelY.Text = frmFilhoCroqui.Y.ToString();
            }
        }

        private void frmDesenharCroquisPrincipal_Load(object sender, EventArgs e)
        {
            DefineFontePadrao();
        }

        private void tsBtnSelecionarQuadrado_Click(object sender, EventArgs e)
        {
            if (CriouFormFilho())
            {
                formaSelecionada = Classes.TiposFormas.ETipoForma.retangulo;
                frmFilhoCroqui.ResetaCoordenadasMouse();
                frmFilhoCroqui.SetSelecionandoArea();
            }

        }

        private void tsBtnSelecionar_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.selecao;

        }

        private void tsBtnLinha_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.linha;
            SetDadosFormFilho();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void tsBtnElipse_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.circulo;
            SetDadosFormFilho();
        }

        private void tsBtnTriangulo_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.triangulo;
            SetDadosFormFilho();
        }

        private void tsTexto_Click(object sender, EventArgs e)
        {
            SelectFont();
            SetFontFormFilho();
        }

        private void tsTxtCorSecundaria_Click(object sender, EventArgs e)
        {
            CorSecundaria = DefinirCor(tsTxtCorSecundaria);
        }

        private void tsTxtCorPrimaria_Click(object sender, EventArgs e)
        {
            CorPrimaria = DefinirCor(tsTxtCorPrimaria);
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CriouFormFilho())
            {
                frmFilhoCroqui.SalvarImage(true);
            }
        }

        private void textoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.texto;
            posicaoTexto = EPosicaoTexto.horizontal;
            SetTextoFormFilho();
        }

        private void textoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaSelecionada = Classes.TiposFormas.ETipoForma.texto;
            posicaoTexto = EPosicaoTexto.vertical;
            SetTextoFormFilho();
        }

        private void tsTextoHorizVert_ButtonClick(object sender, EventArgs e)
        {
            if (CriouFormFilho())
            {
                textoHorizontalToolStripMenuItem.PerformClick();
                frmFilhoCroqui.SelectedFont = selectedFont;
            }

        }

        private void salvarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CriouFormFilho())
            {
                frmFilhoCroqui.Croqui = "";
                frmFilhoCroqui.SalvarImage(true);
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDesenharCroquisPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                File.Delete("tmp.png");
            }
            catch
            {

            }
            
        }
    }
}
