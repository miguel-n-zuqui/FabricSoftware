
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.lblAnosDeEmpresa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResultadoPis);
            this.panel1.Location = new System.Drawing.Point(62, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 99);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Location = new System.Drawing.Point(23, 21);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(50, 13);
            this.lblResultadoPis.TabIndex = 0;
            this.lblResultadoPis.Text = "resutlado";
            // 
            // lblAnosDeEmpresa
            // 
            this.lblAnosDeEmpresa.AutoSize = true;
            this.lblAnosDeEmpresa.Location = new System.Drawing.Point(368, 39);
            this.lblAnosDeEmpresa.Name = "lblAnosDeEmpresa";
            this.lblAnosDeEmpresa.Size = new System.Drawing.Size(236, 13);
            this.lblAnosDeEmpresa.TabIndex = 4;
            this.lblAnosDeEmpresa.Text = "QUANTOS ANOS DE EMPRESA VOCÊ TEM  ?";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.lblAnosDeEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbMenosDeCincoAnos);
            this.Controls.Add(this.lblTempoNoPis);
            this.Controls.Add(this.rbMaisDeCincoAnos);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaisDeCincoAnos;
        private System.Windows.Forms.Label lblTempoNoPis;
        private System.Windows.Forms.RadioButton rbMenosDeCincoAnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultadoPis;
        private System.Windows.Forms.Label lblAnosDeEmpresa;
    }
}