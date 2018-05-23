﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Clase_Archivos;
using System.IO;

namespace Frm_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach(EPuesto p in Enum.GetValues(typeof(EPuesto)))
            {
                this.cboPuesto.Items.Add(p);
            }
            this.cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboPuesto.SelectedItem = EPuesto.Arquero;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (EPuesto)this.cboPuesto.SelectedItem);
            string linea = "";
            bool resp;
            resp = AdministradorDeArchivos.Escribir(@"D:\jugadores.txt", jugador.ToString(), true);
            if (resp)
                resp = AdministradorDeArchivos.Leer(@"D:\jugadores.txt", out linea);
            else
                MessageBox.Show("No se pudo escribir en el archivo");
            if (resp)
                MessageBox.Show(linea);
            else
                MessageBox.Show("No se pudo leer el archivo");
        }
    }
}