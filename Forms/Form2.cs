using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms
{
    public partial class Form2 : Form
    {
        Form3 Vcola;
        Form4 Ccola;
        Configuracion_1 config;
        public Form2()
        {
            InitializeComponent();
            Vcola = new Form3();
            Vcola.Show();
            Ccola = new Form4(Vcola);
            Ccola.Show();
            cmb_prioridad.SelectedIndex = 0;
            config = new Configuracion_1();
            config.imagen(PictureBox2);
            groupBox1.Text = config.Nombre_Negocio();
            label2.Text = config.Campo1();
            label3.Text = config.Campo2();
            label4.Text = config.Campo3();
            label5.Text = config.Campo4();
            cmb_prioridad.DataSource = config.servicio();
            this.BackColor = Color.FromArgb(config.R1(), config.G1(), config.B1());
            label1.BackColor = Color.FromArgb(config.R(), config.G(), config.B());



        }


        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Nodo_cola datos = new Nodo_cola();
            string[] priori = config.prioridad_serv();
            datos.Campo1 = txt_campo1.Text;
            datos.Campo2 = txt_campo2.Text;
            datos.Campo3 = txt_campo3.Text;
            datos.Campo4 = txt_campo4.Text;
            datos.Servicio = cmb_prioridad.SelectedItem.ToString();
            datos.Prioridad = Convert.ToInt32(priori[cmb_prioridad.SelectedIndex]);
            Vcola.DibujarCola(datos);
            Ccola.cargarDatos();



        }
    }
}
