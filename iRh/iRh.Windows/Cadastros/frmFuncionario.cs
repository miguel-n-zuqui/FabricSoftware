﻿using iRh.Windows.Cadastros.core;
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
            CarregarEstados();
            CarregarDocumentos();
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosOsEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Nome";
           
        }
        private void CarregarDocumentos()
        {
            var documento = new DocumentoDeIdentificacao();
            var listaDeDocumentos = documento.ObterTodosOsDocumentos();
            var documentosAz = listaDeDocumentos.OrderBy(x => x.Descricao).ToList();
            cmbDocumento.Items.Clear();
            cmbDocumento.DataSource = documentosAz;
            cmbDocumento.DisplayMember = "Descricao";
            cmbDocumento.ValueMember = "Id";
        }

 
    }
}
