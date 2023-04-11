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
            Campo1.HeaderText = colab.config.Campo1();
            Campo2.HeaderText = colab.config.Campo2();
            Campo3.HeaderText = colab.config.Campo3();
            Campo4.HeaderText = colab.config.Campo4();
            this.BackColor = Color.FromArgb(colab.config.R1(), colab.config.G1(), colab.config.B1());

        }

        public void cargarDatos()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colab.eliminarDeCola();
            cargarDatos();
        }
    }
}
