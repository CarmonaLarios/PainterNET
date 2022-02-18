using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static AcesCEM.Classes.TiposFormas;

namespace AcesCEM.Forms
{
    public partial class frmEdicaoCroqui : Form
    {
        private string croqui;
        private int xOrigem;
        private int yOrigem;
        private int xDestino;
        private int yDestino;
        private int largura;
        private int altura;
        private Font selectedFont = new Font("Arial", 16);
        private Color fontColor = Color.Black;
        StringFormat posicaoTexto = new StringFormat();
        private Brush brushFormasExterno = new SolidBrush(Color.Black);
        private Brush brushFormasInterno = new SolidBrush(Color.Empty);
        private Brush brushTexto = new SolidBrush(Color.Black);
        private Pen pincel = new Pen(Color.Black);
        private Rectangle rectangle;
        private Point pontoInicio;
        private Point pontoDestino;
        private Point pontoSelecionadoUsuario;
        private Bitmap imageModificada;
        private Bitmap imageOriginal;
        private Bitmap parteCopiada;
        private Bitmap parteSelecionada;
        private Bitmap imagemCopia;

        bool mouseClicado = false;
        bool dentroDaImagem = false;
        bool escrevendoTexto = false;
        bool selecionandoArea = false;
        bool cancelaForma = false;
        bool emSelecao = false;
        bool imagemAlterada = false;
        bool salvoEmDisco = false;


        public void SetSelecionandoArea(bool valor = false)
        {
            selecionandoArea = valor;
        }

        public void LimpaSelecao()
        {
            //imagemCopia = null;
            parteSelecionada = null;
        }

        public void SalvarImagem()
        {

        }

        Forms.frmDesenharCroquisPrincipal frmPai;
        private List<Tuple<Point, Point>> _lines = new List<Tuple<Point, Point>>();

        public int Y { get => yOrigem; set => yOrigem = value; }
        public int X { get => xOrigem; set => xOrigem = value; }
        public string Croqui { get => croqui; set => croqui = value; }
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }
        public int XDestino { get => xDestino; set => xDestino = value; }
        public int YDestino { get => yDestino; set => yDestino = value; }
        public Point P1 { get => pontoInicio; set => pontoInicio = value; }
        public Point P2 { get => pontoDestino; set => pontoDestino = value; }
        public Font SelectedFont { get => selectedFont; set => selectedFont = value; }
        public Color FontColor { get => fontColor; set => fontColor = value; }

        public void ResetaCoordenadasMouse()
        {
            ZeraCoordenadas();
        }

        private bool CanceladoPeloUsuario()
        {
            var result = cancelaForma;
            cancelaForma = false;
            return result;
        }

        private void ChangeCursorIcon()
        {
            if (frmPai.FormaSelecionada != ETipoForma.naoSelecionado)
            {
                if (dentroDaImagem)
                    this.Cursor = Cursors.Cross;
                else this.Cursor = Cursors.Default;
            }
        }

        public void SetTextPosition()
        {
            if (frmPai.PosicaoTexto == frmDesenharCroquisPrincipal.EPosicaoTexto.horizontal)
            {
                posicaoTexto.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            }
            else posicaoTexto.FormatFlags = StringFormatFlags.DirectionVertical;
        }

        public frmEdicaoCroqui(Forms.frmDesenharCroquisPrincipal _frm, Bitmap imagemSelecionada, string _croqui)
        {
            this.frmPai = _frm;
            this.Croqui = _croqui;
            frmPai.FormaSelecionada = Classes.TiposFormas.ETipoForma.naoSelecionado;
            imageModificada = imagemSelecionada;
            imageOriginal = imagemSelecionada;
            InitializeComponent();
            pictureBox1.Width = imagemSelecionada.Width;
            pictureBox1.Height = imagemSelecionada.Height;
            this.Text += $" {_croqui}";
            selectedFont = _frm.SelectedFont;
            salvoEmDisco = true;
        }

        public frmEdicaoCroqui(Forms.frmDesenharCroquisPrincipal _frm, int largura, int altura)
        {
            this.frmPai = _frm;
            //this.Croqui = _croqui;
            this.largura = largura;
            this.altura = altura;
            frmPai.FormaSelecionada = Classes.TiposFormas.ETipoForma.naoSelecionado;
            imageModificada = new Bitmap(largura, altura);
            imageOriginal = new Bitmap(largura, altura);
            InitializeComponent();
            selectedFont = _frm.SelectedFont;
        }

        private void MouseOnMove(MouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Left) return;

            //pega pontos X e Y em ferramentas onde não é necessário o clique inicial
            //texto, seleção
            if ((!mouseClicado) && (!emSelecao))
            {
                pontoInicio = new Point(e.X, e.Y);
            }

            if (mouseClicado)
            {
                frmPai.DefineXY(e.X, e.Y);
                XDestino = e.X;
                YDestino = e.Y;
                pontoDestino = new Point(e.X, e.Y);
                _lines.Add(new Tuple<Point, Point>(pontoInicio, pontoDestino));
            }
            //else ZeraCoordenadas();
        }

        private void VerificaTeclaPressionada(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {

                //if (parteCopiada is null) return;

                CopiaConteudoSelecionado();

            }

            if (e.Control && e.KeyCode == Keys.V)
            {

                if (parteCopiada is null) return;

                ColaConteudoCopiado();

            }

            if (e.KeyCode == Keys.Delete)
            {

                if (parteSelecionada is null) return;

                DeletaParteSelecionada();

            }

            if (e.KeyCode == Keys.Escape)
            {
                cancelaForma = true;
            }
        }

        private void CopiaConteudoSelecionado()
        {
            //pictureBox1.Image = imageModificada;
            pictureBox1.Image = imagemCopia;
            // Copy the selected part of the image.
            int wid = Math.Abs(rectangle.Width);
            int hgt = Math.Abs(rectangle.Height);

            if (!emSelecao) return;

            if ((wid < 1) || (hgt < 1)) return;

            //Bitmap area = new Bitmap(wid, hgt);
            parteCopiada = new Bitmap(wid, hgt);

            using (Graphics gr = Graphics.FromImage(parteCopiada))
            {
                Rectangle source_rectangle =
                    new Rectangle(Math.Min(pontoInicio.X, pontoDestino.X),
                                  Math.Min(pontoInicio.Y, pontoDestino.Y),
                                  wid, hgt);
                Rectangle dest_rectangle =
                    new Rectangle(0, 0, wid, hgt);
                gr.DrawImage(imageOriginal, dest_rectangle,
                    source_rectangle, GraphicsUnit.Pixel);

                pontoSelecionadoUsuario = new Point(pontoInicio.X, pontoDestino.X);
            }

            pictureBox1.Refresh();
            emSelecao = false;
        }
        private void ColaConteudoCopiado()
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                if (parteCopiada != null)
                    g.DrawImage(parteCopiada, pontoInicio);

                Thread.Sleep(100);
                parteCopiada = null;
            }

            imageOriginal = new Bitmap(pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private void DeletaParteSelecionada()
        {
            //ajuda fonte:
            //http://csharphelper.com/blog/2014/12/draw-on-a-bitmap-in-c/

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                rectangle.X = pontoInicio.X;
                rectangle.Y = pontoInicio.Y;
                rectangle.Height = YDestino - xOrigem;
                rectangle.Width = XDestino - yOrigem;
                g.FillRectangle(Brushes.White, rectangle);

                using (Pen thick_pen = new Pen(Color.White, 5))
                {
                    g.DrawRectangle(thick_pen, rectangle);
                }
                Thread.Sleep(100);
            }

            imageOriginal = new Bitmap(pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private void ZeraCoordenadas()
        {
            pontoInicio = new Point(0, 0);
            pontoDestino = new Point(0, 0);
        }

        private void CliqueMouse(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                emSelecao = false;
                mouseClicado = true;
                pontoInicio = new Point(e.X, e.Y);

                if (parteSelecionada != null)
                {
                    parteSelecionada = null;
                }

                if (imagemCopia != null)
                {
                    pictureBox1.Image = imagemCopia;
                    imagemCopia = null;
                }

                pictureBox1.Refresh();
            }
            else if (e.Button == MouseButtons.Right)
            {
                emSelecao = false;
                cancelaForma = true;
            }
        }

        private void RetornoMouse(MouseEventArgs e)
        {
            mouseClicado = false;
            pictureBox1.Invalidate();

            if (CanceladoPeloUsuario()) return;

            if (e.Button != MouseButtons.Left) return;

            switch (frmPai.FormaSelecionada)
            {
                case ETipoForma.selecao:
                    parteSelecionada = imagemCopia;
                    break;
                case ETipoForma.retangulo:
                    DesenharRetangulo();
                    break;
                case ETipoForma.linha:
                    DesenharLinha();
                    break;

                case ETipoForma.circulo:
                    DesenharCirculo();
                    break;

                case ETipoForma.triangulo:
                    DesenharTriagulo();
                    break;

                case ETipoForma.texto:
                    escrevendoTexto = true;
                    frmTextoCroqui frm = new frmTextoCroqui();
                    frm.ShowDialog();
                    DesenharTexto(frm.TextoDigitado);
                    frm.Dispose();
                    escrevendoTexto = false;
                    break;
            }

            imagemAlterada = true;
            if (frmPai.FormaSelecionada != ETipoForma.selecao)
                imageOriginal = new Bitmap(pictureBox1.Image);
        }

        private void SetPictureBoxImageSize()
        {
            pictureBox1.Width = imageOriginal.Width;
            pictureBox1.Height = imageOriginal.Height;
        }

        private void PaintPicture(object sender, PaintEventArgs e)
        {
            if (dentroDaImagem)
            {
                DefineAreasSelecao();
                pincel.Color = frmPai.CorPrimaria;


                if (frmPai.FormaSelecionada == ETipoForma.selecao)
                {
                    SelecionarArea();

                    if (cancelaForma)
                    {
                        parteCopiada = null;
                    }

                    if (parteCopiada != null)
                    {
                        pictureBox1.CreateGraphics().DrawImage(parteCopiada, pontoInicio);
                    }

                    //if (parteSelecionada != null)
                    //{
                    //    pictureBox1.CreateGraphics().DrawRectangle(pincel, rectangle);
                    //}

                    pictureBox1.Invalidate();
                }

                if (frmPai.FormaSelecionada == ETipoForma.texto)
                {
                    brushTexto = new SolidBrush(FontColor);
                    pictureBox1.CreateGraphics().DrawString("Texto", selectedFont, brushTexto, pontoInicio, posicaoTexto);
                    pictureBox1.Invalidate();
                }

                if (mouseClicado)
                {
                    if (frmPai.FormaSelecionada == ETipoForma.linha)
                    {
                        //pictureBox1.CreateGraphics().DrawLine(Pens.Black, pontoInicio, pontoDestino);
                        pictureBox1.CreateGraphics().DrawLine(pincel, pontoInicio, pontoDestino);
                        pictureBox1.Invalidate();
                    }

                    if (frmPai.FormaSelecionada == ETipoForma.retangulo)
                    {
                        if (frmPai.CorSecundaria != Color.Empty)
                        {
                            brushFormasInterno = new SolidBrush(frmPai.CorSecundaria);
                            pictureBox1.CreateGraphics().FillRectangle(brushFormasInterno, rectangle);
                        }
                        else
                        {
                            pictureBox1.CreateGraphics().DrawRectangle(pincel, rectangle);
                        }

                        pictureBox1.Invalidate();
                    }

                    if (frmPai.FormaSelecionada == ETipoForma.circulo)
                    {
                        pictureBox1.CreateGraphics().DrawEllipse(pincel, rectangle);
                        pictureBox1.Invalidate();
                    }

                    if (frmPai.FormaSelecionada == ETipoForma.triangulo)
                    {
                        Graphics g = e.Graphics;
                        Pen pen = new Pen(frmPai.CorPrimaria, 3);
                        Point fim = PointToClient(MousePosition);
                        double meioTriangulo = (pontoInicio.X + fim.X) / 2;
                        Point inicio = new Point(pontoInicio.X, fim.Y);
                        Point meio = new Point((int)meioTriangulo, pontoInicio.Y);

                        //DesenharTriagulo();
                        g.DrawLine(pen, inicio, meio);
                        g.DrawLine(pen, inicio, fim);
                        g.DrawLine(pen, fim, meio);
                        pictureBox1.Invalidate();
                    }
                }

                _lines.Clear();
            }
        }

        private void frmEdicaoCroqui_Load(object sender, EventArgs e)
        {
            if (!(Croqui is null))
            {
                CarregaCroqui();
            }

            else
            {
                pictureBox1.Image = imageModificada;
            }
        }

        public void CarregaCroqui()
        {
            //imageModificada = new Bitmap(croqui);
            pictureBox1.ImageLocation = "tmp.png";
            pictureBox1.Image = imageModificada;
            pictureBox1.Size = imageModificada.Size;
            pictureBox1.Load();
        }
        public void DesenharLinha()
        {

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen pen = new Pen(frmPai.CorPrimaria, 3);

                g.DrawLine(pen, pontoInicio, pontoDestino);
                pictureBox1.Invalidate();
            }

        }

        public void DesenharTriagulo()
        {

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {

                Pen pen = new Pen(frmPai.CorPrimaria, 3);

                Point fim = PointToClient(MousePosition);
                double meioTriangulo = (pontoInicio.X + fim.X) / 2;
                Point inicio = new Point(pontoInicio.X, fim.Y);
                Point meio = new Point((int)meioTriangulo, pontoInicio.Y);

                g.DrawLine(pen, inicio, meio);
                g.DrawLine(pen, inicio, fim);
                g.DrawLine(pen, fim, meio);
                pictureBox1.Invalidate();
            }

        }

        public void SelecionarArea()
        {
            if (!mouseClicado) return;

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                emSelecao = true;

                Pen pen = new Pen(Color.Black, 1);
                DefineAreasSelecao();
                //faz cópia antes de realizar o desenho de selecao
                imagemCopia = new Bitmap(imageOriginal);
                Bitmap bm = new Bitmap(imageOriginal);

                using (var gr = Graphics.FromImage(bm))
                {
                    gr.DrawRectangle(pen, rectangle);
                    Rectangle source = new Rectangle(Math.Min(pontoInicio.X, pontoDestino.X),
                                                     Math.Min(pontoInicio.Y, pontoDestino.Y),
                                                     Math.Abs(pontoInicio.X - pontoDestino.X),
                                                     Math.Abs(pontoInicio.Y - rectangle.Y));
                }

                pictureBox1.Image = bm;
                pictureBox1.Invalidate();
            }
        }

        public void DesenharRetangulo()
        {

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen pen = new Pen(frmPai.CorPrimaria, 3);
                DefineAreasSelecao();
                g.DrawRectangle(pen, rectangle);
                pictureBox1.Invalidate();
            }
        }

        public void DesenharTexto(string valor)
        {

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                DefineAreasSelecao();
                g.DrawString(valor, selectedFont, brushTexto, pontoInicio, posicaoTexto);
                pictureBox1.Invalidate();
            }
        }

        public void DesenharCirculo()
        {

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen pen = new Pen(frmPai.CorPrimaria, 3);
                DefineAreasSelecao();
                g.DrawEllipse(pen, rectangle);
                pictureBox1.Invalidate();
            }

        }

        private void DefineAreasSelecao()
        {
            xOrigem = frmPai.X1;
            yOrigem = frmPai.Y1;
            rectangle.X = xOrigem;
            rectangle.Y = yOrigem;
            rectangle.Height = YDestino - xOrigem;
            rectangle.Width = XDestino - yOrigem;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //pontoInicio = new Point(e.X, e.Y);
            frmPai.DefineInicioFigura(e.X, e.Y);
            //mouseClicado = true;
            CliqueMouse(e);
            //pictureBox1.Invalidate();
        }

        private void frmEdicaoCroqui_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (VerificaImagemModificada())
            {
                var result = MessageBox.Show("Deseja salvar a imagem?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;
                    SalvarImage(imagemAlterada);
                }

            }
        }

        public bool VerificaImagemModificada()
        {
            bool retorno = false;
            //MemoryStream msOriginal = new MemoryStream();
            //MemoryStream msAlterada = new MemoryStream();

            //imageOriginal.Save(msOriginal, System.Drawing.Imaging.ImageFormat.Png);
            //imageModificada.Save(msAlterada, System.Drawing.Imaging.ImageFormat.Png);
            //retorno = (msOriginal != msAlterada);

            return imagemAlterada;
        }

        public void SalvarImage(bool showDialog)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "PNG|.png";
            sv.Title = "Salvar Croqui...";
            sv.InitialDirectory = Application.StartupPath.Replace("bin", @"\comum\Croquis");
            bool ok = false;
            showDialog = (showDialog && string.IsNullOrEmpty(croqui));

            if (showDialog)
            {
                ok = sv.ShowDialog() == DialogResult.OK;
            }
            else
            {
                ok = true;
                sv.FileName = croqui;
            }

            if (ok)
            {
                if (sv.FileName != "")
                {
                    imageModificada = new Bitmap(pictureBox1.Image);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.ReadWrite))
                        {

                            imageModificada.Save(ms, ImageFormat.Png);
                            byte[] bytes = ms.ToArray();
                            fs.Write(ms.ToArray(), 0, bytes.Length);
                            pictureBox1.Image = imageModificada;
                        }
                    }

                    //imageModificada.Save(sv.FileName);
                    this.Text = sv.FileName;
                    croqui = sv.FileName;
                    imagemAlterada = false;
                }

            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RetornoMouse(e);
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            PaintPicture(sender, e);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            CliqueMouse(e);
            frmPai.DefineInicioFigura(e.X, e.Y);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //CliqueMouse(e);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseClicado = false;
            ChangeCursorIcon();

            if ((!escrevendoTexto) || (!selecionandoArea))
                dentroDaImagem = false;
            // _lines.Clear();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseOnMove(e);
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            dentroDaImagem = true;
            ChangeCursorIcon();
            pictureBox1.Refresh();
        }

        private void frmEdicaoCroqui_KeyUp(object sender, KeyEventArgs e)
        {
            VerificaTeclaPressionada(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmEdicaoCroqui_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void frmEdicaoCroqui_ResizeEnd(object sender, EventArgs e)
        {
            //p
            //pnlDesenhoPrincipal.Width = imageOriginal.Width;
            //pnlDesenhoPrincipal.Height = imageOriginal.Height;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            SetPictureBoxImageSize();
        }

        private void frmEdicaoCroqui_Shown(object sender, EventArgs e)
        {
            SetPictureBoxImageSize();
        }

        private void frmEdicaoCroqui_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            imageModificada = null;
            imageOriginal = null;
        }
    }
}
