
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.rbMaisDeCincoAnos = new System.Windows.Forms.RadioButton();
            this.lblTempoNoPis = new System.Windows.Forms.Label();
            this.rbMenosDeCincoAnos = new System.Windows.Forms.RadioButton();
            this.panelExibirResultadoEButao = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.lblAnosDeEmpresa = new System.Windows.Forms.Label();
            this.txtTempoDeEmpresa = new System.Windows.Forms.TextBox();
            this.btnCalcularEVerificar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelExibirResultadoEButao.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMaisDeCincoAnos
            // 
            this.rbMaisDeCincoAnos.AutoSize = true;
            this.rbMaisDeCincoAnos.Location = new System.Drawing.Point(62, 84);
            this.rbMaisDeCincoAnos.Name = "rbMaisDeCincoAnos";
            this.rbMaisDeCincoAnos.Size = new System.Drawing.Size(73, 17);
            this.rbMaisDeCincoAnos.TabIndex = 0;
            this.rbMaisDeCincoAnos.TabStop = true;
            this.rbMaisDeCincoAnos.Text = "> 5 ANOS";
            this.rbMaisDeCincoAnos.UseVisualStyleBackColor = true;
            this.rbMaisDeCincoAnos.CheckedChanged += new System.EventHandler(this.rbMaisDeCincoAnos_CheckedChanged);
            // 
            // lblTempoNoPis
            // 
            this.lblTempoNoPis.AutoSize = true;
            this.lblTempoNoPis.Location = new System.Drawing.Point(62, 39);
            this.lblTempoNoPis.Name = "lblTempoNoPis";
            this.lblTempoNoPis.Size = new System.Drawing.Size(177, 26);
            this.lblTempoNoPis.TabIndex = 1;
            this.lblTempoNoPis.Text = "QUANTO TEMPO DE CADASTRO \r\nNO PROGRAMA PIS ?";
            // 
            // rbMenosDeCincoAnos
            // 
            this.rbMenosDeCincoAnos.AutoSize = true;
            this.rbMenosDeCincoAnos.Location = new System.Drawing.Point(162, 84);
            this.rbMenosDeCincoAnos.Name = "rbMenosDeCincoAnos";
            this.rbMenosDeCincoAnos.Size = new System.Drawing.Size(73, 17);
            this.rbMenosDeCincoAnos.TabIndex = 2;
            this.rbMenosDeCincoAnos.TabStop = true;
            this.rbMenosDeCincoAnos.Text = "> 5 ANOS";
            this.rbMenosDeCincoAnos.UseVisualStyleBackColor = true;
            this.rbMenosDeCincoAnos.CheckedChanged += new System.EventHandler(this.rbMenosDeCincoAnos_CheckedChanged);
            // 
            // panelExibirResultadoEButao
            // 
            this.panelExibirResultadoEButao.Controls.Add(this.btnCalcularEVerificar);
            this.panelExibirResultadoEButao.Controls.Add(this.lblResultadoPis);
            this.panelExibirResultadoEButao.Location = new System.Drawing.Point(354, 129);
            this.panelExibirResultadoEButao.Name = "panelExibirResultadoEButao";
            this.panelExibirResultadoEButao.Size = new System.Drawing.Size(312, 99);
            this.panelExibirResultadoEButao.TabIndex = 3;
            this.panelExibirResultadoEButao.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Location = new System.Drawing.Point(17, 66);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(50, 13);
            this.lblResultadoPis.TabIndex = 0;
            this.lblResultadoPis.Text = "resutlado";
            this.lblResultadoPis.Visible = false;
            // 
            // lblAnosDeEmpresa
            // 
            this.lblAnosDeEmpresa.AutoSize = true;
            this.lblAnosDeEmpresa.Location = new System.Drawing.Point(351, 39);
            this.lblAnosDeEmpresa.Name = "lblAnosDeEmpresa";
            this.lblAnosDeEmpresa.Size = new System.Drawing.Size(236, 13);
            this.lblAnosDeEmpresa.TabIndex = 4;
            this.lblAnosDeEmpresa.Text = "QUANTOS ANOS DE EMPRESA VOCÊ TEM  ?";
            // 
            // txtTempoDeEmpresa
            // 
            this.txtTempoDeEmpresa.Location = new System.Drawing.Point(354, 69);
            this.txtTempoDeEmpresa.Name = "txtTempoDeEmpresa";
            this.txtTempoDeEmpresa.Size = new System.Drawing.Size(233, 20);
            this.txtTempoDeEmpresa.TabIndex = 5;
            // 
            // btnCalcularEVerificar
            // 
            this.btnCalcularEVerificar.Location = new System.Drawing.Point(12, 12);
            this.btnCalcularEVerificar.Name = "btnCalcularEVerificar";
            this.btnCalcularEVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularEVerificar.TabIndex = 1;
            this.btnCalcularEVerificar.Text = "CALCULAR";
            this.btnCalcularEVerificar.UseVisualStyleBackColor = true;
            this.btnCalcularEVerificar.Click += new System.EventHandler(this.btnCalcularEVerificar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(62, 174);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(233, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(62, 141);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(117, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "DIGITE SEU SALÁRIO";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtTempoDeEmpresa);
            this.Controls.Add(this.lblAnosDeEmpresa);
            this.Controls.Add(this.panelExibirResultadoEButao);
            this.Controls.Add(this.rbMenosDeCincoAnos);
            this.Controls.Add(this.lblTempoNoPis);
            this.Controls.Add(this.rbMaisDeCincoAnos);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panelExibirResultadoEButao.ResumeLayout(false);
            this.panelExibirResultadoEButao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaisDeCincoAnos;
        private System.Windows.Forms.Label lblTempoNoPis;
        private System.Windows.Forms.RadioButton rbMenosDeCincoAnos;
        private System.Windows.Forms.Panel panelExibirResultadoEButao;
        private System.Windows.Forms.Label lblResultadoPis;
        private System.Windows.Forms.Label lblAnosDeEmpresa;
        private System.Windows.Forms.Button btnCalcularEVerificar;
        private System.Windows.Forms.TextBox txtTempoDeEmpresa;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}