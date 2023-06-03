
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.lblPerguntaDeDesemprego = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultadoSeguroDesemprego = new System.Windows.Forms.Label();
            this.panelMesestrabalhados = new System.Windows.Forms.Panel();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelResultado.SuspendLayout();
            this.panelMesestrabalhados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(-3, 5);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(201, 26);
            this.lblMesesTrabalhados.TabIndex = 0;
            this.lblMesesTrabalhados.Text = "INFORME A QUANTIDADE DE MESES \r\nTRABALHADOS NOS ÚLTIMOS ANOS";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(0, 59);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 5;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(0, 20);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 4;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // lblPerguntaDeDesemprego
            // 
            this.lblPerguntaDeDesemprego.AutoSize = true;
            this.lblPerguntaDeDesemprego.Location = new System.Drawing.Point(29, 38);
            this.lblPerguntaDeDesemprego.Name = "lblPerguntaDeDesemprego";
            this.lblPerguntaDeDesemprego.Size = new System.Drawing.Size(214, 13);
            this.lblPerguntaDeDesemprego.TabIndex = 3;
            this.lblPerguntaDeDesemprego.Text = "ESTÁ EM SITUAÇÃO DE DESEMPREGO?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSim);
            this.panel1.Controls.Add(this.rbNao);
            this.panel1.Location = new System.Drawing.Point(32, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultadoSeguroDesemprego);
            this.panelResultado.Location = new System.Drawing.Point(305, 38);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(247, 100);
            this.panelResultado.TabIndex = 10;
            // 
            // lblResultadoSeguroDesemprego
            // 
            this.lblResultadoSeguroDesemprego.AutoSize = true;
            this.lblResultadoSeguroDesemprego.Location = new System.Drawing.Point(3, 41);
            this.lblResultadoSeguroDesemprego.Name = "lblResultadoSeguroDesemprego";
            this.lblResultadoSeguroDesemprego.Size = new System.Drawing.Size(55, 13);
            this.lblResultadoSeguroDesemprego.TabIndex = 11;
            this.lblResultadoSeguroDesemprego.Text = "Resultado";
            // 
            // panelMesestrabalhados
            // 
            this.panelMesestrabalhados.Controls.Add(this.btnVerificar);
            this.panelMesestrabalhados.Controls.Add(this.txtMesesTrabalhados);
            this.panelMesestrabalhados.Controls.Add(this.lblMesesTrabalhados);
            this.panelMesestrabalhados.Location = new System.Drawing.Point(32, 184);
            this.panelMesestrabalhados.Name = "panelMesestrabalhados";
            this.panelMesestrabalhados.Size = new System.Drawing.Size(266, 148);
            this.panelMesestrabalhados.TabIndex = 11;
            this.panelMesestrabalhados.Visible = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(4, 93);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(121, 39);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(4, 53);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(185, 20);
            this.txtMesesTrabalhados.TabIndex = 1;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.panelMesestrabalhados);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPerguntaDeDesemprego);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.Load += new System.EventHandler(this.frmBeneficioSeguroDesemprego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.panelMesestrabalhados.ResumeLayout(false);
            this.panelMesestrabalhados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label lblPerguntaDeDesemprego;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultadoSeguroDesemprego;
        private System.Windows.Forms.Panel panelMesestrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Button btnVerificar;
    }
}