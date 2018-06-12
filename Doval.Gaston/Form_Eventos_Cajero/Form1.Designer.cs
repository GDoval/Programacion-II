namespace Form_Eventos_Cajero
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillete5 = new System.Windows.Forms.TextBox();
            this.txtBillete10 = new System.Windows.Forms.TextBox();
            this.txtBillete20 = new System.Windows.Forms.TextBox();
            this.txtBillete50 = new System.Windows.Forms.TextBox();
            this.txtBillete100 = new System.Windows.Forms.TextBox();
            this.txtBilleteDos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRetirar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad a Retirar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Retirar";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(99, 16);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(81, 20);
            this.txtRetirar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBilleteDos);
            this.groupBox2.Controls.Add(this.txtBillete100);
            this.groupBox2.Controls.Add(this.txtBillete50);
            this.groupBox2.Controls.Add(this.txtBillete20);
            this.groupBox2.Controls.Add(this.txtBillete10);
            this.groupBox2.Controls.Add(this.txtBillete5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de Billetes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Billete de $ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Billete de $ 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Billete de $ 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Billete de $ 20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Billete de $ 50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Billete de $ 100";
            // 
            // txtBillete5
            // 
            this.txtBillete5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBillete5.Location = new System.Drawing.Point(114, 40);
            this.txtBillete5.Name = "txtBillete5";
            this.txtBillete5.ReadOnly = true;
            this.txtBillete5.Size = new System.Drawing.Size(80, 20);
            this.txtBillete5.TabIndex = 6;
            // 
            // txtBillete10
            // 
            this.txtBillete10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBillete10.Location = new System.Drawing.Point(114, 67);
            this.txtBillete10.Name = "txtBillete10";
            this.txtBillete10.ReadOnly = true;
            this.txtBillete10.Size = new System.Drawing.Size(80, 20);
            this.txtBillete10.TabIndex = 7;
            // 
            // txtBillete20
            // 
            this.txtBillete20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBillete20.Location = new System.Drawing.Point(114, 93);
            this.txtBillete20.Name = "txtBillete20";
            this.txtBillete20.ReadOnly = true;
            this.txtBillete20.Size = new System.Drawing.Size(80, 20);
            this.txtBillete20.TabIndex = 8;
            // 
            // txtBillete50
            // 
            this.txtBillete50.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBillete50.Location = new System.Drawing.Point(114, 122);
            this.txtBillete50.Name = "txtBillete50";
            this.txtBillete50.ReadOnly = true;
            this.txtBillete50.Size = new System.Drawing.Size(80, 20);
            this.txtBillete50.TabIndex = 9;
            // 
            // txtBillete100
            // 
            this.txtBillete100.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBillete100.Location = new System.Drawing.Point(114, 151);
            this.txtBillete100.Name = "txtBillete100";
            this.txtBillete100.ReadOnly = true;
            this.txtBillete100.Size = new System.Drawing.Size(80, 20);
            this.txtBillete100.TabIndex = 10;
            this.txtBillete100.TextChanged += new System.EventHandler(this.txtBillete100_TextChanged);
            // 
            // txtBilleteDos
            // 
            this.txtBilleteDos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBilleteDos.Location = new System.Drawing.Point(114, 14);
            this.txtBilleteDos.Name = "txtBilleteDos";
            this.txtBilleteDos.ReadOnly = true;
            this.txtBilleteDos.Size = new System.Drawing.Size(80, 20);
            this.txtBilleteDos.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(281, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(281, 124);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 32);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 31);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 316);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBilleteDos;
        private System.Windows.Forms.TextBox txtBillete100;
        private System.Windows.Forms.TextBox txtBillete50;
        private System.Windows.Forms.TextBox txtBillete20;
        private System.Windows.Forms.TextBox txtBillete10;
        private System.Windows.Forms.TextBox txtBillete5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

