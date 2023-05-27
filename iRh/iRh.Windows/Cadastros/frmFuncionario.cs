using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            rbTemFilhosNao.Checked = true;
            txtFilhoNome.Visible = false;
            txtFIlhoDataNascimento.Visible = false;
        }

        private void lblFilhoNome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFilhoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFIlhoDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFilhoNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }
    }
}
