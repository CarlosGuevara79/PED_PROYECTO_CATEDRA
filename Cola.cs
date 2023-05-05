using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Transitions;


namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954
{
    public class Cola
    {
        public Nodo_cola primero;
        public Nodo_cola ultimo;
        private int totnodos;
        
        

        public Cola()
        {
            primero = ultimo = null;
            totnodos = 0;
            
        }
        public int Totnodos()
        {
            return this.totnodos;
        }
        public bool Estavacia()
        {
            if (primero == null) return true;
            else return false;
        }

        public List<Nodo_cola> ConvertirALista()
        {
            if (Estavacia())
            {
                return null;
            }
            else
            {
                List<Nodo_cola> ColaList = new List<Nodo_cola>();
                Nodo_cola aux = new Nodo_cola();
                aux = primero;
                while (aux != null)
                {
                    ColaList.Add(aux);
                    aux = aux.next;
                }
                return ColaList;
            }
        }
       
        public Nodo_cola Desencolar()
        {
            Nodo_cola aux = null;
            if (!Estavacia())
            {
                aux = primero;
                primero = primero.next;
                totnodos--;
            }
            return aux;
            
        }
        public void EncoPrioridad(Nodo_cola nodo)
        {
            Nodo_cola auxiliar = nodo;
            if (nodo.Prioridad ==3)
            {
                Nodo_cola puntero;
                puntero = primero;

                if (primero == null)
                {
                    primero =ultimo= auxiliar;
                }
                else if (primero.Prioridad == 3)
                {
                    int pos;
                    pos = 0;
                    while (puntero != null)
                    {
                        if (puntero.Prioridad == 3)
                        {
                            pos++;
                        }
                        puntero = puntero.next;
                    }

                    puntero = primero;
                    for (int i = 1; i < pos; i++)
                    {
                        puntero = puntero.next;
                        if (puntero.next == null)
                        {
                            break;
                        }
                    }
                    Nodo_cola punteronext;
                    punteronext = puntero.next;
                    puntero.next = auxiliar;
                    auxiliar.next = punteronext;
                }
                else
                {
                    puntero = primero;
                    primero = auxiliar;
                    auxiliar.next = puntero;
                }


            }
            else if (nodo.Prioridad == 2)
            {
                Nodo_cola puntero;
                puntero = primero;

                if (primero == null)
                {
                    primero = ultimo=auxiliar;
                }
                else if (primero.Prioridad >= 2)
                {
                    int pos;
                    pos = 0;
                    while (puntero !=null)
                    {
                        if (puntero.Prioridad >= 2)
                        {
                            pos++;
                        }
                        puntero = puntero.next;
                    }

                    puntero = primero;
                    for (int i = 1; i < pos ; i++)
                    {
                        puntero = puntero.next;
                        if (puntero.next == null)
                        {
                            break;
                        }
                    }
                    Nodo_cola punteronext;
                    punteronext = puntero.next;
                    puntero.next = auxiliar;
                    auxiliar.next = punteronext;
                }
                else
                {
                    puntero = primero;
                    primero = auxiliar;
                    auxiliar.next = puntero;
                }


            }
            else
            {
                if (Estavacia())
                {
                    primero = ultimo = nodo;
                }
                else
                {
                    ultimo.next = nodo;
                    ultimo = nodo;
                }
            }
            totnodos++;
        }

        





    }
}
