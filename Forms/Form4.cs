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
        }

        public void cargarDatos()
        {
            if (colab.bancocola.primero.next != null ||colab.bancocola.primero != null)
            {
                Nodo_cola recor = colab.bancocola.primero.next;
                int y2 = 62;
                while (recor != null)
                {
                   



                    recor = recor.next;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colab.eliminarDeCola();
        }
    }
}
