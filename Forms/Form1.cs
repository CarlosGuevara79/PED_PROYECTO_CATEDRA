using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms
{
    public partial class Form1 : Form
    {
        int r, g, b, r1, g1, b1;
        Configuracion_1 config;
        List<string> servicos;
        List<string> prioridades;
        public Form1(int Type)
        {
            InitializeComponent();
            r = 0;
            g = 0;
            b = 0;
            r1 = 0;
            g1 = 0;
            b1 = 0;
            config = new Configuracion_1();
            servicos = new List<string>();
            prioridades = new List<string>();
        }

        



        private void iconButton2_Click(object sender, EventArgs e)
        {
            config.Guardar_Campos(textBox6, textBox5, textBox4, textBox3);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            servicos.Add(TxtAgregarServicio.Text);
            if (comboBox5.SelectedItem.ToString() == "Baja")
            {
                prioridades.Add("1");
            }
            if (comboBox5.SelectedItem.ToString() == "Media")
            {
                prioridades.Add("2");
            }
            if (comboBox5.SelectedItem.ToString() == "Alta")
            {
                prioridades.Add("3");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            config.Guardar_Servicios(servicos, prioridades);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            config.seleccionar(OPFL_img, Pcb_logoprew);
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            config.Guardar_InformacionDeNegocio(OPFL_img, TxtNomNegocio, r, g, b, r1, g1, b1);
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                label7.ForeColor = MyDialog.Color;
            r = MyDialog.Color.R;
            g = MyDialog.Color.G;
            b = MyDialog.Color.B;

        }

        private void BtnEditar2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                label6.ForeColor = MyDialog.Color;

            r1 = MyDialog.Color.R;
            g1 = MyDialog.Color.G;
            b1 = MyDialog.Color.B;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form2 Ventana_2 = new Form2();
            Ventana_2.Show();

            this.Hide();

        }
    }
}
