using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954
{
    public class Nodo_cola
    {
        private string fila;
        private int caja;
        private Panel nodoV;
        private int prioridad;
        public Nodo_cola next;
        private string campo1, campo2, campo3, campo4, servicion;
        
      public Nodo_cola()
      {
            fila = "";
            caja = 1;
            nodoV = new Panel();
            prioridad = 1;
            next = null;
            
      }

        public string Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        public int Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public Panel NodoV
        {
            get { return nodoV; }
            set { nodoV = value; }
            
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public string Campo1
        {
            get { return campo1; }
            set { campo1 = value; }
        }
        public string Campo2
        {
            get { return campo2; }
            set { campo2 = value; }
        }

        public string Campo3
        {
            get { return campo3; }
            set { campo3 = value; }
        }

        public string Campo4
        {
            get { return campo4; }
            set { campo4 = value; }
        }

        public string Servicio
        {
            get { return servicion; }
            set { servicion = value; }
        }




    }
}
