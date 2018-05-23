using System;
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
            string path = "";
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //abre una ventana para que el usuario elija donde guardar el archivo, y recupera ese path dentro de una variable de tipo string
                path = this.saveFileDialog1.FileNames[0];
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\jugadores.txt"; //devuelve el path al desktop del usuario logeado
            resp = AdministradorDeArchivos.Escribir(path, jugador.ToString(), true);
            if (resp)
                resp = AdministradorDeArchivos.Leer(path, out linea);
            else
                MessageBox.Show("No se pudo escribir en el archivo");
            if (resp)
                MessageBox.Show(linea);
            else
                MessageBox.Show("No se pudo leer el archivo");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
    
        }
    }
}
