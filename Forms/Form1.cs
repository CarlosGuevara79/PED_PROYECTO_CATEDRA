using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;

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
            try
            {
                servicos = config.servicio();
                prioridades = config.prioridad_serv();
                CmbQuitarServicio.DataSource = servicos;
                cmbPreview.DataSource = servicos;
                config.imagen(Pcb_logoprew);
                label7.ForeColor = Color.FromArgb(config.R(), config.G(), config.B());
                label6.ForeColor = Color.FromArgb(config.R1(), config.G1(), config.B1());
                TxtNomNegocio.Text = config.Nombre_Negocio();
                txbCampo1.Text = config.Campo1();
                txbCampo2.Text = config.Campo2();
                txbCampo3.Text = config.Campo3();
                txbCampo4.Text = config.Campo4();
                


            }
            catch
            {

            }
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            config.Guardar_Campos(txbCampo1, txbCampo2, txbCampo3, txbCampo4);
            txbCampo1.Clear();
            txbCampo2.Clear();
            txbCampo3.Clear();
            txbCampo4.Clear();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
           if(TxtAgregarServicio.Text!="" && cmbprioridad.SelectedIndex != -1)
            {
                servicos.Add(TxtAgregarServicio.Text);
                if (cmbprioridad.SelectedItem.ToString() == "Baja")
                {
                    prioridades.Add("1");
                }
                if (cmbprioridad.SelectedItem.ToString() == "Media")
                {
                    prioridades.Add("2");
                }
                if (cmbprioridad.SelectedItem.ToString() == "Alta")
                {
                    prioridades.Add("3");
                }
                cmbPreview.DataSource = null;
                CmbQuitarServicio.DataSource = null;
                cmbPreview.DataSource = servicos;
                CmbQuitarServicio.DataSource = servicos;
                cmbPreview.SelectedIndex = 0;
                CmbQuitarServicio.SelectedIndex = 0;
                TxtAgregarServicio.Clear();
            }
            else
            {
                MessageBox.Show("Verifique que la prioridad se hya selccionado y que no dejo campo vacio");
            }
               
           
            
           
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            config.Guardar_Servicios(servicos, prioridades);
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
          
               servicos.RemoveAt(CmbQuitarServicio.SelectedIndex);
               prioridades.RemoveAt(CmbQuitarServicio.SelectedIndex);

                cmbPreview.DataSource = null;
                CmbQuitarServicio.DataSource = null;
                cmbPreview.DataSource = servicos;
                CmbQuitarServicio.DataSource = servicos;
                cmbPreview.SelectedIndex = 0;
                CmbQuitarServicio.SelectedIndex = 0;
                
                
            }
            catch
            {
                MessageBox.Show("Un error a ocurrido al cambiar los datos");
            }
            
        }

        private void BtnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            config.Guardar_InformacionDeNegocio(OPFL_img, TxtNomNegocio, r, g, b, r1, g1, b1);
            TxtNomNegocio.Clear();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            config.seleccionar(OPFL_img, Pcb_logoprew);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color =Color.Black;

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
            MyDialog.Color = Color.Black;

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
