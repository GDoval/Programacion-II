namespace Spend_A_Lot
{
    partial class CargarGastos
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
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.rtxtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar_Gastos = new System.Windows.Forms.Button();
            this.btnCancelar_Gastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(183, 65);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(249, 20);
            this.txtGasto.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Necesario",
            "Fijo",
            "Superfluo"});
            this.cmbTipo.Location = new System.Drawing.Point(183, 106);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(249, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // rtxtObservaciones
            // 
            this.rtxtObservaciones.Location = new System.Drawing.Point(183, 154);
            this.rtxtObservaciones.Name = "rtxtObservaciones";
            this.rtxtObservaciones.Size = new System.Drawing.Size(247, 154);
            this.rtxtObservaciones.TabIndex = 3;
            this.rtxtObservaciones.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observaciones";
            // 
            // btnAceptar_Gastos
            // 
            this.btnAceptar_Gastos.Location = new System.Drawing.Point(163, 341);
            this.btnAceptar_Gastos.Name = "btnAceptar_Gastos";
            this.btnAceptar_Gastos.Size = new System.Drawing.Size(120, 54);
            this.btnAceptar_Gastos.TabIndex = 7;
            this.btnAceptar_Gastos.Text = "Aceptar";
            this.btnAceptar_Gastos.UseVisualStyleBackColor = true;
            this.btnAceptar_Gastos.Click += new System.EventHandler(this.btnAceptar_Gastos_Click);
            // 
            // btnCancelar_Gastos
            // 
            this.btnCancelar_Gastos.Location = new System.Drawing.Point(309, 341);
            this.btnCancelar_Gastos.Name = "btnCancelar_Gastos";
            this.btnCancelar_Gastos.Size = new System.Drawing.Size(121, 53);
            this.btnCancelar_Gastos.TabIndex = 8;
            this.btnCancelar_Gastos.Text = "Cancelar";
            this.btnCancelar_Gastos.UseVisualStyleBackColor = true;
            // 
            // CargarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 409);
            this.Controls.Add(this.btnCancelar_Gastos);
            this.Controls.Add(this.btnAceptar_Gastos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtObservaciones);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtGasto);
            this.Name = "CargarGastos";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RichTextBox rtxtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar_Gastos;
        private System.Windows.Forms.Button btnCancelar_Gastos;
    }
}