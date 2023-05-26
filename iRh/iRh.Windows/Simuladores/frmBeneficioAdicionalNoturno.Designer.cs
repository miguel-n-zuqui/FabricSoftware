
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtHorasMensais = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasPorMes = new System.Windows.Forms.Label();
            this.txtHorasNorturnasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.lblResutadoAdicionalNoturno = new System.Windows.Forms.Label();
            this.btnCalcularHorasNoturnas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(29, 72);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(24, 26);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "SALÁRIO BASE";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // txtHorasMensais
            // 
            this.txtHorasMensais.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasMensais.Location = new System.Drawing.Point(29, 164);
            this.txtHorasMensais.Name = "txtHorasMensais";
            this.txtHorasMensais.Size = new System.Drawing.Size(306, 35);
            this.txtHorasMensais.TabIndex = 5;
            // 
            // lblHorasTrabalhadasPorMes
            // 
            this.lblHorasTrabalhadasPorMes.AutoSize = true;
            this.lblHorasTrabalhadasPorMes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasPorMes.Location = new System.Drawing.Point(24, 121);
            this.lblHorasTrabalhadasPorMes.Name = "lblHorasTrabalhadasPorMes";
            this.lblHorasTrabalhadasPorMes.Size = new System.Drawing.Size(265, 30);
            this.lblHorasTrabalhadasPorMes.TabIndex = 4;
            this.lblHorasTrabalhadasPorMes.Text = "CARGA HORÁRIA MENSAL";
            // 
            // txtHorasNorturnasTrabalhadas
            // 
            this.txtHorasNorturnasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNorturnasTrabalhadas.Location = new System.Drawing.Point(29, 298);
            this.txtHorasNorturnasTrabalhadas.Name = "txtHorasNorturnasTrabalhadas";
            this.txtHorasNorturnasTrabalhadas.Size = new System.Drawing.Size(306, 35);
            this.txtHorasNorturnasTrabalhadas.TabIndex = 7;
            this.txtHorasNorturnasTrabalhadas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(24, 224);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(324, 60);
            this.lblHorasNoturnas.TabIndex = 6;
            this.lblHorasNoturnas.Text = "QUANTAS HORAS NOTURNAS A \r\nMAIS TRABALHOU?";
            this.lblHorasNoturnas.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResutadoAdicionalNoturno
            // 
            this.lblResutadoAdicionalNoturno.AutoSize = true;
            this.lblResutadoAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResutadoAdicionalNoturno.Location = new System.Drawing.Point(375, 167);
            this.lblResutadoAdicionalNoturno.Name = "lblResutadoAdicionalNoturno";
            this.lblResutadoAdicionalNoturno.Size = new System.Drawing.Size(99, 30);
            this.lblResutadoAdicionalNoturno.TabIndex = 8;
            this.lblResutadoAdicionalNoturno.Text = "resultado";
            this.lblResutadoAdicionalNoturno.Click += new System.EventHandler(this.lblResutadoAdicionalNoturno_Click);
            // 
            // btnCalcularHorasNoturnas
            // 
            this.btnCalcularHorasNoturnas.Location = new System.Drawing.Point(380, 72);
            this.btnCalcularHorasNoturnas.Name = "btnCalcularHorasNoturnas";
            this.btnCalcularHorasNoturnas.Size = new System.Drawing.Size(186, 35);
            this.btnCalcularHorasNoturnas.TabIndex = 9;
            this.btnCalcularHorasNoturnas.Text = "CALCULAR ADICIONAL NOTURNO";
            this.btnCalcularHorasNoturnas.UseVisualStyleBackColor = true;
            this.btnCalcularHorasNoturnas.Click += new System.EventHandler(this.btnCalcularHorasNoturnas_Click);
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 369);
            this.Controls.Add(this.btnCalcularHorasNoturnas);
            this.Controls.Add(this.lblResutadoAdicionalNoturno);
            this.Controls.Add(this.txtHorasNorturnasTrabalhadas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtHorasMensais);
            this.Controls.Add(this.lblHorasTrabalhadasPorMes);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.Load += new System.EventHandler(this.frmBeneficioAdicionalNoturno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtHorasMensais;
        private System.Windows.Forms.Label lblHorasTrabalhadasPorMes;
        private System.Windows.Forms.TextBox txtHorasNorturnasTrabalhadas;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.Label lblResutadoAdicionalNoturno;
        private System.Windows.Forms.Button btnCalcularHorasNoturnas;
    }
}