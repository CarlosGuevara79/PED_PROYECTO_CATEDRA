using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954
{
    public class Configuracion_1
    {
        private string URL_imagen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\icono\iconoNegocio.jpg");
        private string URL_datos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion\Config.txt");
        private string URL_datos1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion\Config1.txt");
        private string URL_datos2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion\Config2.txt");
        private string URL_datos3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion\Config3.txt");
        public Configuracion_1()
        {
            CrearCarpetas();
           
        }

        public void imagen(PictureBox img)
        {
            img.Image = System.Drawing.Image.FromFile(URL_imagen);
            
        }

        public string Nombre_Negocio()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return linea[0];
        }

        public int R()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32( linea[1]);
        }

        public int G()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32(linea[2]);
        }

        public int B()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32(linea[3]);
        }

        public int R1()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32(linea[4]);
        }

        public int G1()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32(linea[5]);
        }

        public int B1()
        {
            string[] linea = File.ReadAllLines(URL_datos);
            return Convert.ToInt32(linea[6]);
        }

        public string Campo1()
        {
            string[] linea = File.ReadAllLines(URL_datos1);
            return linea[0];
        }
        public string Campo2()
        {
            string[] linea = File.ReadAllLines(URL_datos1);
            return linea[1];
        }
        public string Campo3()
        {
            string[] linea = File.ReadAllLines(URL_datos1);
            return linea[2];
        }
        public string Campo4()
        {
            string[] linea = File.ReadAllLines(URL_datos1);
            return linea[3];
        }

        public string[] servicio()
        {
            string[] linea = File.ReadAllLines(URL_datos2);
            return linea;
        }
        public string[] prioridad_serv()
        {
            string[] linea = File.ReadAllLines(URL_datos3);
            return linea;
        }

        public void CrearCarpetas()
        {
            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion")) == false && Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\icono")) == false)
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\Configuracion"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\icono"));
                
            }
        }

        public void seleccionar(OpenFileDialog A, PictureBox B)//metodo que permite mostrat la imagen seleccionada por el usario en un combobos a la hora del registro
        {
            A.Filter = "Image files (*.jpg)|*.jpg";
            if (A.ShowDialog() == DialogResult.OK)
            {
                B.SizeMode = PictureBoxSizeMode.StretchImage;
                B.Image = System.Drawing.Image.FromFile(A.FileName);
            }


        }

        public void Guardar_InformacionDeNegocio(OpenFileDialog A,TextBox Negocio,int r,int g,int b,int r1,int g1,int b1)
        {
            try
            {
                
                File.Delete(URL_imagen);
                File.Delete(URL_datos);
                File.Copy(A.FileName, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Sistema_BancoCola\icono\iconoNegocio.jpg"));
                StreamWriter escribir = new StreamWriter(URL_datos);//crea el archivo sen donde se quedo el contador
                escribir.WriteLine(Negocio.Text);
                escribir.WriteLine(r.ToString());
                escribir.WriteLine(g.ToString());
                escribir.WriteLine(b.ToString());
                escribir.WriteLine(r1.ToString());
                escribir.WriteLine(g1.ToString());
                escribir.WriteLine(b1.ToString());

                escribir.Close();
                MessageBox.Show("Guardado con éxito", "ÉXITO", MessageBoxButtons.OK);


            }
            catch
            {
                MessageBox.Show("Problema al guardar datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void Guardar_Campos(TextBox campo1, TextBox campo2, TextBox campo3,TextBox campo4)
        {
            try
            {
                    File.Delete(URL_datos1);
                    StreamWriter escribir = new StreamWriter(URL_datos1);//crea el archivo sen donde se quedo el contador
                    escribir.WriteLine(campo1.Text);
                    escribir.WriteLine(campo2.Text);
                    escribir.WriteLine(campo3.Text);
                    escribir.WriteLine(campo4.Text);
                    escribir.Close();
                    MessageBox.Show("Guardado con éxito", "ÉXITO", MessageBoxButtons.OK);
                
                
            }
            catch
            {
                MessageBox.Show("Problema al guardar datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Guardar_Servicios( List<string> servicios, List<string> prioridad)
        {
            try
            {
                File.Delete(URL_datos2);
                File.Delete(URL_datos3);
                string[] p2 = servicios.ToArray();
                File.WriteAllLines(URL_datos2, p2);
         
                string[] p1 = prioridad.ToArray();
                File.WriteAllLines(URL_datos3, p1);
                MessageBox.Show("Guardado con éxito", "ÉXITO", MessageBoxButtons.OK);


            }
            catch
            {
                MessageBox.Show("Problema al guardar datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
