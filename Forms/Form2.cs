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
        public Form2()
        {
            InitializeComponent();
            Vcola = new Form3();
            Vcola.Show();
            Ccola = new Form4(Vcola);
            Ccola.Show();
            cmb_prioridad.SelectedIndex = 0;
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Nodo_cola datos = new Nodo_cola();

            datos.Campo1 = txt_campo1.Text;
            datos.Campo2 = txt_campo2.Text;
            datos.Campo3 = txt_campo3.Text;
            datos.Campo4 = txt_campo4.Text;
            datos.Prioridad =Convert.ToInt32( cmb_prioridad.SelectedItem);
            Vcola.DibujarCola(datos);



        }
    }
}
