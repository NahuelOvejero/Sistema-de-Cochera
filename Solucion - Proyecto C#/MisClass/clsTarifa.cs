using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MisClass
{
    public class clsTarifa:clsArchivos
    {

        //BOOL[] TIPO 0-AUTO 1-MOTO 2-CAMIONETA -3CAMION

        int id;
        string nombre;
        string descripcion;
        decimal precio;
        bool[] tipo;
        bool estado;

#region GETYSET

        
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


        public bool[] Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Descripcion
        {
          get { return descripcion; }
          set { descripcion = value; }
        }
                

             public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }



        #endregion


        public clsTarifa(string arch,string dir): base(arch,dir) {    
     
            
        }

        public clsTarifa() {    
     
            
        }


        public string GrabarTarifa(string nombre, string desc, decimal precio, bool[] tipo, bool est)
        {
            //metodo usado para Grabar Nueva tarifa


            string valor = string.Empty;

            try
            {
                GrabarEntero(this.obtenerID()+1);
                GrabarTexto(nombre);
                GrabarTexto(desc);
                GrabarDecimal(precio);
                for (int i = 0; i < 4;i++ )
                {
                    GrabarBool(tipo[i]);
                }
                GrabarBool(est);
                aumentarID();
            }


            catch(Exception ex) {
                valor = ex.Message;
            }

            return valor;
        }

        public string GrabarTarifa(int idelim, string nombre, string desc, decimal precio,bool[] tipo, bool est)
        {
            //Metodo usado para Generar Lista
            string valor = string.Empty;

            try
            {
                GrabarEntero(idelim);
                GrabarTexto(nombre);
                GrabarTexto(desc);
                GrabarDecimal(precio); for (int i = 0; i < 4; i++)
                {
                    GrabarBool(tipo[i]);
                }
                GrabarBool(est);
           
            }



            catch (Exception ex)
            {
                valor = ex.Message;
            }


            return valor;
        }

        public string eliminarTarifa(int idElim) {
            string estado = "no encontrado";
            List<clsTarifa> lista = listar();
            clsTarifa aux = null;

            foreach (clsTarifa t in lista)
            {
                if (idElim == t.Id ) {
                    aux = t;
                    estado = "eliminado";
                    }
            }
            if (aux != null)
            {
                aux.estado = false;
            }

            if (estado.Equals("eliminado"))
                generArchivos(lista);

            return estado;

          
    }

        public void generArchivos(List<clsTarifa> miLista)
        {

            if (File.Exists(this.Completo))
                File.Delete(this.Completo);

            foreach (clsTarifa t in miLista)
            {
                GrabarTarifa(t.id, t.nombre, t.descripcion, t.precio, t.tipo, t.estado);                     
            }

        }    

        public List<clsTarifa> listar()
        {

            List<clsTarifa> lista = new List<clsTarifa>();
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
         
                    clsTarifa t = new clsTarifa();
                    t.tipo = new bool[4];
                    t.id = br.ReadInt32();
                    t.nombre = br.ReadString();
                    t.descripcion = br.ReadString();
                    t.precio = br.ReadDecimal();                    
                    for (int i = 0; i < 4; i++)
                    {
                        t.tipo[i] = br.ReadBoolean();
                    }
                    t.estado = br.ReadBoolean();  
                    
                    lista.Add(t);
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

        public clsTarifa existe(string nombreCheck) {
            clsTarifa ex = null;
            List<clsTarifa> lista = listar();

            foreach(clsTarifa t in lista){
                if (t.nombre.Equals(nombreCheck))
                    ex = t;
                }           

            return ex;
        
        }

        public clsTarifa existe(int idCheck)
        {
            clsTarifa ex = null;
            List<clsTarifa> lista = listar();

            foreach (clsTarifa t in lista)
            {
                if (t.Id == idCheck)
                {
                    ex = t;
                    ex.Completo = "C:\\Sistema de Cochera\\Tarifas\\Tarifas.dat";
                }
            }

            return ex;

        }


        public string modificar(int idX, string nombreX, string desX, bool[] tipoX, decimal precioX) { 
            
            string res="Tarifa no encontrada";

             List<clsTarifa> miLista = listar();

             foreach (clsTarifa t in miLista)
             {
                 if (t.id == idX) 
                 {
                     t.nombre = nombreX;
                     t.descripcion = desX;
                     t.precio = precioX;
                     for (int i = 0; i < 4; i++)
                     {
                         t.tipo[i] = tipoX[i];
                     }

                     res = "cambio realizado";
                 }             
             }

             generArchivos(miLista);                

            return res;
        }

        public string cambiarEstado(int idX,bool estadoX) {

            string res = "Tarifa no encontrado";

            List<clsTarifa> miLista = listar();

            foreach (clsTarifa v in miLista)
            {
                if (v.id == idX)
                {
                    v.estado = estadoX;
                    res = "cambio realizado";
                }
            }

            generArchivos(miLista);

            return res;
        }

        public List<clsTarifa> listarAlta()
        {

            List<clsTarifa> lista = new List<clsTarifa>();
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


                    //id - nombre - desc - precio - tipo x 4 - xhora-est

                    clsTarifa t = new clsTarifa();
                    t.tipo = new bool[4];
                    t.id = br.ReadInt32();
                    t.nombre = br.ReadString();
                    t.descripcion = br.ReadString();
                    t.precio = br.ReadDecimal();
                    for (int i = 0; i < 4; i++)
                    {
                        t.tipo[i] = br.ReadBoolean();
                    }
                    t.estado = br.ReadBoolean();

                    if (t.estado)
                    {
                        lista.Add(t);
                    }
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


        public string obtenerTipos() {

            string tipos = "";

            if (tipo[0]) { tipos+=" Auto "; }
            if (tipo[1]) { tipos+=" Moto ";}
            if (tipo[2]) { tipos+=" Camioneta "; }
            if (tipo[3]) { tipos += " Camion "; }
            

            return tipos;

        
        }
        


    }
}
