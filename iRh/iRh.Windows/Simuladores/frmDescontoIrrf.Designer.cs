﻿
namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            this.panelIrrf = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularIrrf = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblResultadoIrrf = new System.Windows.Forms.Label();
            this.panelIrrf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIrrf
            // 
            this.panelIrrf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelIrrf.Controls.Add(this.lblResultadoIrrf);
            this.panelIrrf.Controls.Add(this.lblResultado);
            this.panelIrrf.Location = new System.Drawing.Point(29, 205);
            this.panelIrrf.Name = "panelIrrf";
            this.panelIrrf.Size = new System.Drawing.Size(306, 100);
            this.panelIrrf.TabIndex = 7;
            this.panelIrrf.Visible = false;
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
            // btnCalcularIrrf
            // 
            this.btnCalcularIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularIrrf.Location = new System.Drawing.Point(29, 130);
            this.btnCalcularIrrf.Name = "btnCalcularIrrf";
            this.btnCalcularIrrf.Size = new System.Drawing.Size(214, 35);
            this.btnCalcularIrrf.TabIndex = 6;
            this.btnCalcularIrrf.Text = "CALCULAR IRRF";
            this.btnCalcularIrrf.UseVisualStyleBackColor = true;
            this.btnCalcularIrrf.Click += new System.EventHandler(this.btnCalcularIrrf_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(29, 65);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(24, 19);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "SALÁRIO BASE";
            // 
            // lblResultadoIrrf
            // 
            this.lblResultadoIrrf.AutoSize = true;
            this.lblResultadoIrrf.Location = new System.Drawing.Point(23, 48);
            this.lblResultadoIrrf.Name = "lblResultadoIrrf";
            this.lblResultadoIrrf.Size = new System.Drawing.Size(50, 13);
            this.lblResultadoIrrf.TabIndex = 5;
            this.lblResultadoIrrf.Text = "resultado";
            this.lblResultadoIrrf.Visible = false;
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 348);
            this.Controls.Add(this.panelIrrf);
            this.Controls.Add(this.btnCalcularIrrf);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmDescontoIrrf";
            this.Text = "frmDescontoIrrf";
            this.panelIrrf.ResumeLayout(false);
            this.panelIrrf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIrrf;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularIrrf;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblResultadoIrrf;
    }
}