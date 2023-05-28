
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgts
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
            this.panelInss = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularFgts = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelInss.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInss
            // 
            this.panelInss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelInss.Controls.Add(this.lblResultado);
            this.panelInss.Location = new System.Drawing.Point(17, 205);
            this.panelInss.Name = "panelInss";
            this.panelInss.Size = new System.Drawing.Size(306, 100);
            this.panelInss.TabIndex = 7;
            this.panelInss.Visible = false;
            this.panelInss.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInss_Paint);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(73, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Visible = false;
            // 
            // btnCalcularFgts
            // 
            this.btnCalcularFgts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFgts.Location = new System.Drawing.Point(17, 130);
            this.btnCalcularFgts.Name = "btnCalcularFgts";
            this.btnCalcularFgts.Size = new System.Drawing.Size(214, 35);
            this.btnCalcularFgts.TabIndex = 6;
            this.btnCalcularFgts.Text = "CALCULAR FGTS";
            this.btnCalcularFgts.UseVisualStyleBackColor = true;
            this.btnCalcularFgts.Click += new System.EventHandler(this.btnCalcularFgts_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(17, 65);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 19);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "SALÁRIO BASE";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.panelInss);
            this.Controls.Add(this.btnCalcularFgts);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioFgts";
            this.Text = "frmBeneficioFgts";
            this.panelInss.ResumeLayout(false);
            this.panelInss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInss;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularFgts;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}