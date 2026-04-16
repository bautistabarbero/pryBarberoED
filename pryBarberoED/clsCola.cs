using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryBarberoED
{
    internal class clsCola
    {
        //campos de la clase 
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la calse 
        public clsNodo Primero
        {
            get { return pri; } 
            set { pri = value; }

        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //  metodos de la clase

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }


        }
    }
}
