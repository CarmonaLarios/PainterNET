using System;
using System.Windows.Forms;

namespace AcesCEM.Forms
{
    public partial class frmTextoCroqui : Form
    {
        public string TextoDigitado { get; set; } 
        public frmTextoCroqui()
        {
            InitializeComponent();
        }

        private void frmTextoCroqui_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TextoDigitado = txtTexto.Text;
            Close();
        }
    }
}
