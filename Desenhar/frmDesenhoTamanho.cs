using AcesCEM.Classes;
using System;
using System.Windows.Forms;

namespace AcesCEM.Forms
{
    public partial class frmDesenhoTamanho : Form
    {
        public bool TemTamanhoValido { get; set; }
        public int LarguraDesenho { get; set; }
        public int AlturaDesenho { get; set; }
        public frmDesenhoTamanho()
        {
            InitializeComponent();
        }

        private string SetValorStrVazia(string valor, string valorPadrao)
        {
            if (valor.Trim() == "")
            {
                valor = valorPadrao;
            }

            return valor;
        }

        private bool ImagemTemTamanhoValido()
        {
            txtLargura.Text = SetValorStrVazia(txtLargura.Text, "0");
            txtAltura.Text = SetValorStrVazia(txtAltura.Text, "0");

            var tamanhoLarg = Int32.Parse(txtLargura.Text);
            var tamanhoAlt = Int32.Parse(txtAltura.Text);
            var result = (tamanhoLarg > 0) && (tamanhoAlt > 0);

            LarguraDesenho = tamanhoLarg;
            AlturaDesenho = tamanhoAlt;

            if (!result)
            {
                MessageBox.Show("Tamanho de imagem inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Geral.ApenasNumeros(sender, e);
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Geral.ApenasNumeros(sender, e);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TemTamanhoValido = ImagemTemTamanhoValido();
            if (TemTamanhoValido) Close();
        }

        private void frmDesenhoTamanho_Load(object sender, EventArgs e)
        {

        }
    }
}
