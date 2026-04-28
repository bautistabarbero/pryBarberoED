using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarberoED
{
    internal class clsPila
    {
        // Campo de la clase
           private clsNodo pri;

            // Propiedad
            public clsNodo Primero
            {
                get { return pri; }
                set { pri = value; }
            }

            // Método para agregar a la pila
            public void Agregar(clsNodo Nuevo)
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                }
                else
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
            }

            // Método para eliminar de la pila
            public void Eliminar()
            {
                if (Primero != null)
                {
                    Primero = Primero.Siguiente;
                }
            }

            // Recorrer y mostrar en DataGridView
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

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        // Recorrer y guardar en archivo de texto
        public void Recorrer(string NmbreArchivo)
            {
                clsNodo aux = Primero;
                StreamWriter AD = new StreamWriter(NmbreArchivo, false, Encoding.UTF8);

                AD.WriteLine("Lista de personas\n");
                AD.WriteLine("Código;Nombre;Trámite");

                while (aux != null)
                {
                    AD.Write(aux.Codigo);
                    AD.Write(";");
                    AD.Write(aux.Nombre);
                    AD.Write(";");
                    AD.WriteLine(aux.Tramite);
                    aux = aux.Siguiente;
                }

                AD.Close();
            }
    }
}

