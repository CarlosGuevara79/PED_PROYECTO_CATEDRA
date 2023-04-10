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
    public partial class AdminForm : Form
    {
        public int id { get; set; } //Guarda el id del usuario que inicio sesion
        public string email { get; set; } //Guarda el email del usuario que inicio sesion
        public string nombre { get; set; } //Guarad el nombre del usuario
        private int UserType { get; set; }

        public AdminForm(int Type)
        {
            InitializeComponent();
        }
    }
}
