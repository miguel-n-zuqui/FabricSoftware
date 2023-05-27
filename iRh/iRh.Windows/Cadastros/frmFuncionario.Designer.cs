
namespace iRh.Windows.Cadastros
{
    partial class frmFuncionario
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.rbTemFilhosSim = new System.Windows.Forms.RadioButton();
            this.rbTemFilhosNao = new System.Windows.Forms.RadioButton();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.lblFilhoNome = new System.Windows.Forms.Label();
            this.lblFilhoNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro não dizer"});
            this.cmbGenero.Location = new System.Drawing.Point(39, 54);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // rbTemFilhosSim
            // 
            this.rbTemFilhosSim.AutoSize = true;
            this.rbTemFilhosSim.Location = new System.Drawing.Point(39, 125);
            this.rbTemFilhosSim.Name = "rbTemFilhosSim";
            this.rbTemFilhosSim.Size = new System.Drawing.Size(42, 17);
            this.rbTemFilhosSim.TabIndex = 1;
            this.rbTemFilhosSim.TabStop = true;
            this.rbTemFilhosSim.Text = "Sim";
            this.rbTemFilhosSim.UseVisualStyleBackColor = true;
            this.rbTemFilhosSim.CheckedChanged += new System.EventHandler(this.rbTemFilhosSim_CheckedChanged);
            // 
            // rbTemFilhosNao
            // 
            this.rbTemFilhosNao.AutoSize = true;
            this.rbTemFilhosNao.Location = new System.Drawing.Point(115, 125);
            this.rbTemFilhosNao.Name = "rbTemFilhosNao";
            this.rbTemFilhosNao.Size = new System.Drawing.Size(45, 17);
            this.rbTemFilhosNao.TabIndex = 2;
            this.rbTemFilhosNao.TabStop = true;
            this.rbTemFilhosNao.Text = "Não";
            this.rbTemFilhosNao.UseVisualStyleBackColor = true;
            this.rbTemFilhosNao.CheckedChanged += new System.EventHandler(this.rbTemFilhosNao_CheckedChanged);
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(36, 96);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(85, 13);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "Você tem filhos?";
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(6, 35);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoNome.TabIndex = 4;
            this.txtFilhoNome.TextChanged += new System.EventHandler(this.txtFilhoNome_TextChanged);
            // 
            // lblFilhoNome
            // 
            this.lblFilhoNome.AutoSize = true;
            this.lblFilhoNome.Location = new System.Drawing.Point(3, 9);
            this.lblFilhoNome.Name = "lblFilhoNome";
            this.lblFilhoNome.Size = new System.Drawing.Size(92, 13);
            this.lblFilhoNome.TabIndex = 6;
            this.lblFilhoNome.Text = "Nome do seu filho";
            this.lblFilhoNome.Click += new System.EventHandler(this.lblFilhoNome_Click);
            // 
            // lblFilhoNascimento
            // 
            this.lblFilhoNascimento.AutoSize = true;
            this.lblFilhoNascimento.Location = new System.Drawing.Point(133, 9);
            this.lblFilhoNascimento.Name = "lblFilhoNascimento";
            this.lblFilhoNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblFilhoNascimento.TabIndex = 7;
            this.lblFilhoNascimento.Text = "Data de nascimento";
            this.lblFilhoNascimento.Click += new System.EventHandler(this.lblFilhoNascimento_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(253, 38);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            this.lblIdade.Visible = false;
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoNome);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(35, 148);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(316, 62);
            this.panelExibeDadosFilhos.TabIndex = 9;
            this.panelExibeDadosFilhos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(136, 35);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoDataNascimento.TabIndex = 9;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.rbTemFilhosNao);
            this.Controls.Add(this.rbTemFilhosSim);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rbTemFilhosSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNao;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label lblFilhoNome;
        private System.Windows.Forms.Label lblFilhoNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}