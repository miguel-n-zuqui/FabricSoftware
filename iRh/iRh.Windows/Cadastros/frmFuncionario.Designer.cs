
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
            this.txtFIlhoDataNascimento = new System.Windows.Forms.TextBox();
            this.lblFilhoNome = new System.Windows.Forms.Label();
            this.lblFilhoNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // txtFIlhoDataNascimento
            // 
            this.txtFIlhoDataNascimento.Location = new System.Drawing.Point(136, 35);
            this.txtFIlhoDataNascimento.Name = "txtFIlhoDataNascimento";
            this.txtFIlhoDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFIlhoDataNascimento.TabIndex = 5;
            this.txtFIlhoDataNascimento.TextChanged += new System.EventHandler(this.txtFIlhoDataNascimento_TextChanged);
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
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFIlhoDataNascimento);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.txtFilhoNome);
            this.panel1.Controls.Add(this.lblFilhoNascimento);
            this.panel1.Controls.Add(this.lblFilhoNome);
            this.panel1.Location = new System.Drawing.Point(35, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 62);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.rbTemFilhosNao);
            this.Controls.Add(this.rbTemFilhosSim);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rbTemFilhosSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNao;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.TextBox txtFIlhoDataNascimento;
        private System.Windows.Forms.Label lblFilhoNome;
        private System.Windows.Forms.Label lblFilhoNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panel1;
    }
}