namespace Equipo_Jugador
{
    partial class FrmEquipo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.listUno = new System.Windows.Forms.ListBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant Jugadores";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(136, 135);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(152, 20);
            this.txtCant.TabIndex = 5;
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(136, 362);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(67, 33);
            this.btnMas.TabIndex = 6;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Visible = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // listUno
            // 
            this.listUno.FormattingEnabled = true;
            this.listUno.Location = new System.Drawing.Point(46, 251);
            this.listUno.Name = "listUno";
            this.listUno.Size = new System.Drawing.Size(512, 95);
            this.listUno.TabIndex = 7;
            this.listUno.Visible = false;
            this.listUno.SelectedIndexChanged += new System.EventHandler(this.listUno_SelectedIndexChanged);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(312, 362);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 33);
            this.btnMenos.TabIndex = 8;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Visible = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(209, 402);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(80, 32);
            this.txtM.TabIndex = 9;
            this.txtM.Text = "M";
            this.txtM.UseVisualStyleBackColor = true;
            this.txtM.Click += new System.EventHandler(this.txtM_Click);
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 446);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.listUno);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmEquipo";
            this.Text = "FrmEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.ListBox listUno;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button txtM;
    }
}