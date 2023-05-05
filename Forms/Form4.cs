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
    public partial class Form4 : Form
    {
        Form3 colab;

        public Form4(Form3 a)
        {
            InitializeComponent();
            colab = a;
            try
            {
                this.BackColor = Color.FromArgb(colab.config.R1(), colab.config.G1(), colab.config.B1());
            }
            catch
            {

            }
            

        }

        public void cargarDatos()
        {
            dgv_datosCola.DataSource = colab.bancocola.ConvertirALista();
            
            try
            {
                dgv_datosCola.Columns.Remove("Prioridad");
                dgv_datosCola.Columns.Remove("NodoV");
                dgv_datosCola.Columns.Remove("Fila");
                dgv_datosCola.Columns.Remove("Caja");
                dgv_datosCola.Columns["Campo1"].HeaderText = colab.config.Campo1();
                dgv_datosCola.Columns["Campo2"].HeaderText = colab.config.Campo2();
                dgv_datosCola.Columns["Campo3"].HeaderText = colab.config.Campo3();
                dgv_datosCola.Columns["Campo4"].HeaderText = colab.config.Campo4();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colab.eliminarDeCola();
            cargarDatos();
        }
    }
}
