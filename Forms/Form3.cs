using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Forms
{
    public partial class Form3 : Form
    {
        int con1, x, y, ag, a1, a2;
        public Cola bancocola = new Cola();
        public Configuracion_1 config = new Configuracion_1();
        public Form3()
        {
            InitializeComponent();
            con1 = 0;
            x = 0;
            y = 0;
            ag = 0;
            a1 = 0;
            a2 = 0;
            try
            {
                config.imagen(pictureBox1);
                panel_l.BackColor = Color.FromArgb(config.R(), config.G(), config.B());
                this.BackColor = Color.FromArgb(config.R1(), config.G1(), config.B1());
            }
            catch
            {

            }
           

        }

        public void DibujarCola(Nodo_cola nodo)
        {


            //toma el panel del nodo, lo dibuja en el panel_cola
            //aqui se crea el panel
            var paneldibujo = nodo.NodoV;
            paneldibujo.Size = new System.Drawing.Size(panel_cola.Width, 60);
            paneldibujo.BackColor = Color.Transparent;

            nodo.Fila = "A" + con1;
            var lblf = new Label();
            var lblc = new Label();
            lblf.Text = nodo.Fila; lblc.Text = "Caja " + nodo.Caja;
            lblf.ForeColor = Color.White; lblc.ForeColor = Color.White;
            lblf.Font = new Font("Arial", 16); lblc.Font = new Font("Arial", 16);
            paneldibujo.Location = new System.Drawing.Point(-60, ag + 60);
            paneldibujo.Visible = true;
            panel_cola.Controls.Add(paneldibujo);

            if (nodo.Prioridad == 3)
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(paneldibujo, "Left", x);
                t.add(paneldibujo, "Top", a1);
                t.run();
                Transition.run(paneldibujo, "BackColor", Color.Red, new TransitionType_Linear(200));

                lblf.Location = new System.Drawing.Point(0, paneldibujo.Height / 2 - 12);
                lblc.Location = new System.Drawing.Point(paneldibujo.Width - 70, paneldibujo.Height / 2 - 12);
                paneldibujo.Controls.Add(lblf); paneldibujo.Controls.Add(lblc);
                bancocola.EncoPrioridad(nodo);


                if (bancocola.primero.next != null || bancocola.primero != null)
                {
                    Nodo_cola recor = bancocola.primero.next;
                    int y2 = 62;
                    while (recor != null)
                    {
                        //se usa la bibleoteca transitions para mover los paneles de los nodos y reordenarlos
                        var paneldibujo2 = recor.NodoV;
                        Transition t1 = new Transition(new TransitionType_EaseInEaseOut(500));
                        t1.add(paneldibujo2, "Left", x);
                        t1.add(paneldibujo2, "Top", y2);
                        y2 = y2 + 62;

                        t1.run();
                        recor = recor.next;
                    }
                }

                ag = ag + 62;
                a1 = a1 + 62;


            }
            else if (nodo.Prioridad == 2)
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(paneldibujo, "Left", x);
                t.add(paneldibujo, "Top", a2 + a1);
                t.run();
                Transition.run(paneldibujo, "BackColor", Color.Yellow, new TransitionType_Linear(200));

                lblf.Location = new System.Drawing.Point(0, paneldibujo.Height / 2 - 12);
                lblc.Location = new System.Drawing.Point(paneldibujo.Width - 70, paneldibujo.Height / 2 - 12);
                paneldibujo.Controls.Add(lblf); paneldibujo.Controls.Add(lblc);
                bancocola.EncoPrioridad(nodo);

                if (bancocola.primero.next != null || bancocola.primero != null)
                {
                    Nodo_cola recor = bancocola.primero.next;
                    int y2 = 62;
                    while (recor != null)
                    {
                        //se usa la bibleoteca transitions para mover los paneles de los nodos y reordenarlos
                        var paneldibujo2 = recor.NodoV;
                        Transition t1 = new Transition(new TransitionType_EaseInEaseOut(500));
                        t1.add(paneldibujo2, "Left", x);
                        t1.add(paneldibujo2, "Top", y2);
                        y2 = y2 + 62;

                        t1.run();
                        recor = recor.next;
                    }
                }

                ag = ag + 62;
                a2 = a2 + 62;
            }
            else
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(paneldibujo, "Left", x);
                t.add(paneldibujo, "Top", ag);
                t.run();
                Transition.run(paneldibujo, "BackColor", Color.Green, new TransitionType_Linear(200));

                lblf.Location = new System.Drawing.Point(0, paneldibujo.Height / 2 - 12);
                lblc.Location = new System.Drawing.Point(paneldibujo.Width - 70, paneldibujo.Height / 2 - 12);
                paneldibujo.Controls.Add(lblf); paneldibujo.Controls.Add(lblc);
                bancocola.EncoPrioridad(nodo);
                ag = ag + 62;

            }

            con1 = con1 + 1;
        }

        public void eliminarDeCola()
        {
            if (bancocola.Totnodos() != 0)
            {
                //se usa un nodo como axuliar para opbtenr la infomacion del nodo desencolado
                Nodo_cola atender = bancocola.Desencolar();
                lbl_atendido.Text = atender.Fila + " en la caja " + atender.Caja;
                var paneldibujo = atender.NodoV;
                paneldibujo.Dispose();

                //se crea un enumerator para rrecorer la cola
                Nodo_cola recor = bancocola.primero;
                int y2 = 0;
                while (recor != null)
                {
                    //se usa la bibleoteca transitions para mover los paneles de los nodos y reordenarlos
                    var paneldibujo2 = recor.NodoV;
                    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                    t.add(paneldibujo2, "Left", x);
                    t.add(paneldibujo2, "Top", y2);
                    y2 = y2 + 62;
                    t.run();
                    recor = recor.next;
                }
                y = y - 62;
            }
        }
    }
}
