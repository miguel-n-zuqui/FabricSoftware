﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void panelInss_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {
                    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmBeneficioValeTransporte_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text) && string.IsNullOrEmpty(txtValesPorDia.Text) && string.IsNullOrEmpty(txtValorDaPassagem.Text))
            {
                MessageBox.Show("INFORME SEU SALÁRIO BASE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var valesPorDia = double.Parse(txtValesPorDia.Text);
                var valorDaPasagem = double.Parse(txtValorDaPassagem.Text);
                var rultadoValeTransporte;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido,ex: 3500", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();

            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
