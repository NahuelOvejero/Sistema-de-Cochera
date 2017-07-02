using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MisClass
{
    public class clsLote : clsArchivos
    {
        int id;
        string nombre;     
        string estado;
        string tipo;

        #region getyset

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        public clsLote(string arch,string dir): base(arch,dir) {

            this.Completo = "C:\\Sistema de Cochera\\Lotes\\Lotes.dat";
        }

        public clsLote()
        {
            this.Completo = "C:\\Sistema de Cochera\\Lotes\\Lotes.dat";
        }



        public string NuevoLote(string nombre, string estado,string tipo)
        {
            //metodo usado para Grabar un Nuevo Lote


            string valor = string.Empty;

            try
            {
                GrabarEntero(this.obtenerID() + 1);
                GrabarTexto(nombre);
                GrabarTexto(estado);
                GrabarTexto(tipo);
                aumentarID();

            }


            catch (Exception ex)
            {
                valor = ex.Message;
            }

            return valor;
        }

        public string CargarLote(int id, string nombre, string estado,string tipo) {


            string valor = string.Empty;

            try
            {
                GrabarEntero(id);
                GrabarTexto(nombre);
                GrabarTexto(estado);
                GrabarTexto(tipo);
                aumentarID();
            }


            catch (Exception ex)
            {
                valor = ex.Message;
            }

            return valor;
        
        }

       
        public void generArchivos(List<clsLote> miLista)
        {

            if (File.Exists(this.Completo))
                File.Delete(this.Completo);

            foreach (clsLote l in miLista)
            {
                CargarLote(l.id, l.nombre, l.estado,l.tipo);
            }

        }

        public List<clsLote> listar()
        {

            List<clsLote> lista = new List<clsLote>();
            lista.Clear();
            try
            {
                FileStream fs = null;
                BinaryReader br = null;
                if (!File.Exists(this.Completo))
                    File.Create(this.Completo);
                fs = new FileStream(this.Completo, FileMode.Open);
                br = new BinaryReader(fs);
                while (br.PeekChar() != -1)
                {
                    clsLote l = new clsLote();

                    l.id = br.ReadInt32();
                    l.nombre = br.ReadString();
                    l.estado = br.ReadString();
                    l.tipo = br.ReadString();

                    lista.Add(l);
                }


                br.Close();
                fs.Close();

            }
            catch (IOException x)
            {

                lista = null; // excepción  
            }


            return lista;
        }


        public bool existe(string nombreCheck)
        {

            List<clsLote> lista = listar();

            if (lista.Count > 0)
            {
                foreach (clsLote t in lista)
                {
                    if (t.nombre.Equals(nombreCheck))
                        return true;
                }
            }

            return false;

        }

        public clsLote existe(int idCheck)
        {
            clsLote ex = null;
            List<clsLote> lista = listar();

            foreach (clsLote t in lista)
            {
                if (t.Id == idCheck)
                {
                    ex = t;
                    ex.Completo = "C:\\Sistema de Cochera\\Lotes\\Lotes.dat";
                }
            }

            return ex;

        }

        public int RetornarID(string nombreBusqueda)
        {
            List<clsLote> lista = listar();

            foreach (clsLote lot in lista)
            {
                if (lot.nombre.Equals(nombreBusqueda))
                {
                    return lot.id;
                }
            }

            return -1;

        }

        public string setLibre(int id) {
            string res = "no encontrado";
            List<clsLote> lista = listar();
            clsLote aux = null;

            foreach (clsLote l in lista)
            {
                if (id == l.Id)
                {
                    aux = l;
                    res = "liberado OK";
                }
            }
            if (aux != null)
            {
                aux.estado = "Libre";
                generArchivos(lista);
            }


            return res;
        }

        public string setMantenimiento()
        {
            string res = "no encontrado";
            List<clsLote> lista = listar();
            clsLote aux = null;

            foreach (clsLote l in lista)
            {
                if (id == l.Id)
                {
                    aux = l;
                    res = "Mantenimiento OK";
                }
            }
            if (aux != null)
            {
                aux.estado = "Mantenimiento";
                generArchivos(lista);
            }


            return res;
        }

        public string setOcupado(int id)
        {
            string res = "no encontrado";
            List<clsLote> lista = listar();
            clsLote aux = null;

            foreach (clsLote l in lista)
            {
                if (id == l.id)
                {
                    aux = l;
                    res = "Ocupado OK";
                }
            }
            if (aux != null)
            {
                aux.estado = "Ocupado";
                generArchivos(lista);
            }


            return res;
        }

        public string darBaja(int idElim)
        {
            string res = "no encontrado";
            List<clsLote> lista = listar();
            clsLote aux = null;

            foreach (clsLote l in lista)
            {
                if (idElim == l.Id)
                {
                    aux = l;
                    estado = "eliminado";
                }
            }
            if (aux != null)
            {
                aux.estado = "Baja";
            }

            if (estado.Equals("eliminado"))
                generArchivos(lista);

            return res;
        }

        public string modificar(int idX, string nombreX,string estadoX,string tipoX)
        {

            string res = "Lote no encontrado";

            List<clsLote> miLista = listar();
            if (miLista != null)
            {
                foreach (clsLote l in miLista)
                {
                    if (l.id == idX)
                    {
                        l.nombre = nombreX;
                        l.estado = estadoX;
                        l.tipo = tipoX;
                        res = "cambio realizado";
                    }
                }
            
            generArchivos(miLista);

            return res;
            }
            return res;
        }
        
        
    }
}
