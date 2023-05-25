
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValesPorDia = new System.Windows.Forms.TextBox();
            this.lblValesPorDia = new System.Windows.Forms.Label();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.bntVerificador = new System.Windows.Forms.Button();
            this.lblVerificador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(37, 26);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(124, 20);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Digite seu salário";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSalario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(41, 69);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 20);
            this.txtSalario.TabIndex = 9;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValesPorDia
            // 
            this.txtValesPorDia.Location = new System.Drawing.Point(41, 149);
            this.txtValesPorDia.Name = "txtValesPorDia";
            this.txtValesPorDia.Size = new System.Drawing.Size(120, 20);
            this.txtValesPorDia.TabIndex = 11;
            // 
            // lblValesPorDia
            // 
            this.lblValesPorDia.AutoSize = true;
            this.lblValesPorDia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValesPorDia.Location = new System.Drawing.Point(37, 106);
            this.lblValesPorDia.Name = "lblValesPorDia";
            this.lblValesPorDia.Size = new System.Drawing.Size(268, 20);
            this.lblValesPorDia.TabIndex = 10;
            this.lblValesPorDia.Text = "Quantidade de vales utilizados por dia:";
            this.lblValesPorDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.Location = new System.Drawing.Point(41, 237);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(120, 20);
            this.txtValorDaPassagem.TabIndex = 13;
            this.txtValorDaPassagem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPassagem.Location = new System.Drawing.Point(37, 194);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(233, 20);
            this.lblValorPassagem.TabIndex = 12;
            this.lblValorPassagem.Text = "Valor da passagem na sua cidade:";
            this.lblValorPassagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblValorPassagem.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntVerificador
            // 
            this.bntVerificador.Location = new System.Drawing.Point(357, 69);
            this.bntVerificador.Name = "bntVerificador";
            this.bntVerificador.Size = new System.Drawing.Size(108, 38);
            this.bntVerificador.TabIndex = 15;
            this.bntVerificador.Text = "Verificar ";
            this.bntVerificador.UseVisualStyleBackColor = true;
            this.bntVerificador.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVerificador
            // 
            this.lblVerificador.AutoSize = true;
            this.lblVerificador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificador.Location = new System.Drawing.Point(353, 26);
            this.lblVerificador.Name = "lblVerificador";
            this.lblVerificador.Size = new System.Drawing.Size(325, 20);
            this.lblVerificador.TabIndex = 16;
            this.lblVerificador.Text = "Verificar se vale apena utilizar o vale transporte:";
            this.lblVerificador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVerificador.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(357, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 17;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(23, 45);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVerificador);
            this.Controls.Add(this.bntVerificador);
            this.Controls.Add(this.txtValorDaPassagem);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.txtValesPorDia);
            this.Controls.Add(this.lblValesPorDia);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "frmBeneficioValeTransporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBeneficioValeTransporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtValesPorDia;
        private System.Windows.Forms.Label lblValesPorDia;
        private System.Windows.Forms.TextBox txtValorDaPassagem;
        private System.Windows.Forms.Label lblValorPassagem;
        private System.Windows.Forms.Button bntVerificador;
        private System.Windows.Forms.Label lblVerificador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
    }
}