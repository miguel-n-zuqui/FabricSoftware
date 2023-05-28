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
            panelExibeDadosFilhos.Visible = false;

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

        private void rbTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;
           
        }

        private void rbTemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;
                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                    lblIdade.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("A data de nascimento parece estar errada,detalhamento:" + ex.Message);
                }
                
            }
        }
        private string Comprimentador(int opcaoSelecionada)
        {
            switch (opcaoSelecionada)
            {
                case 1: return "Prezado, Senhor: ";
                case 2: return "Prezado, Senhora: ";
                default:
                    return "Prezades, Senhores";
            }
            return "s";
        }
    }
}
