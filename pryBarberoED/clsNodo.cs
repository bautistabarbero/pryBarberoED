using System;


namespace pryBarberoED
{
    internal class clsNodo
    {
        //campos del nodo
        private Int32 cod;
        private string nom;
        private string tra;

        private clsNodo sig;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}

