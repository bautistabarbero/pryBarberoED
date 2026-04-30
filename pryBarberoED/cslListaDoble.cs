using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarberoED
{
    internal class cslListaDoble
    {
        //declaro los dos campos
        private clsNodo pri;
        private clsNodo ult;

        //declaro las dos propiedades
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

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                if (nuevo.Codigo < pri.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero.Anterior = nuevo;
                    Primero = nuevo;
                }
                else
                {
                    if (nuevo.Codigo < Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = nuevo;
                        nuevo.Anterior = Aux;
                        Ant.Siguiente = nuevo;
                        nuevo.Siguiente = Ant;

                    }

                }

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
