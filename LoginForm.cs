using System;
using System.Windows.Forms;
using ProyectoCatedra_PED_MR190768_GM172474_CM221954.Properties;
using ProyectoCatedra_PED_MR190768_GM172474_CM221954.Servicios;
using ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SessionService sessionService = new SessionService();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa");
            Application.Exit();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            Status.Image = Properties.Resources.Loading;
            Status.Visible = true;

            usuario p = await sessionService.LoginAsync(txtUser.Text, txtPassword.Text);
            if (p == null)
            {
                MessageBox.Show("Usuario y/o contraseña incorecto");
                btnIngresar.Visible = true;
                Status.Visible = false;
                return;
            }
            else if (p.nombres == "Exception")
            {
                MessageBox.Show("Ocurrio un error");
                btnIngresar.Visible = true;
                Status.Visible = false;
            }
            else
            {

                if (p.tipoUsuario == 1)
                {
                    Form1 mf = new Form1((int)p.tipoUsuario);
                    //mf.id = p.id;
                    //mf.nombre = p.nombres; PARA MANEJO PERSONALIZADO EN PANTALLAS.
                    //mf.email = p.email;
                    mf.Show();
                    //MessageBox.Show("Has ingresado como administrador.");
                    this.Hide();
                }
            }
        }

    }
    }

