using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    public class clsDueño:clsArchivos
    {


        /*ESTRUCTURA:
         * ID
         * DNI
         * nombre
         * apellido
         * telefono - int        
         */


        int id;
        int dni;
        string nombre;
        string apellido;
        string telefono;
        bool estado;

        #region GETYSET


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }




        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        #endregion


        public clsDueño(string arch,string dir): base(arch,dir) {
            
            this.Completo =
            "C:\\Sistema de Cochera\\Inquilinos\\Inquilinos.dat";
            
            }

        public clsDueño() {
            this.Completo =
            "C:\\Sistema de Cochera\\Inquilinos\\Inquilinos.dat";
        }

        public string GrabarDueño(int dni,string nombre,string apellido, string telefono, bool est)
        {

            string valor = string.Empty;

            try
            {
                GrabarEntero(this.obtenerID()+1);
                GrabarEntero(dni);
                GrabarTexto(nombre);                    
                GrabarTexto(apellido);          
                GrabarTexto(telefono);
                GrabarBool(est);
                aumentarID();
            }



            catch(Exception ex) {
                valor = ex.Message;
            }



            

            return valor;
        }

        public string GrabarDueño(int idelim , int dni,string nombre, string apellido, string  telefono, bool est)
        {

            string valor = string.Empty;

            try
            {
                GrabarEntero(idelim);
                GrabarEntero(dni);
                GrabarTexto(nombre);
                GrabarTexto(apellido);
                GrabarTexto(telefono);
                GrabarBool(est);
            }



            catch (Exception ex)
            {
                valor = ex.Message;
            }





            return valor;
        }

        public string eliminarDueño(int idElim) {
            string estado = "no encontrado";
            List<clsDueño> lista = listar();
            clsDueño aux = null;

            foreach (clsDueño c in lista) {
                if (idElim == c.Id ) {
                    c.estado = false;
                    estado = "eliminado";
                    }
                }

            if (estado.Equals("eliminado"))
                generArchivos(lista);

            return estado;

          
    }



        public void generArchivos(List<clsDueño> miLista)
        {

            if (File.Exists(this.Completo))
                File.Delete(this.Completo);

            foreach (clsDueño v in miLista)
            {
                GrabarDueño(v.id, v.dni, v.nombre, v.apellido, v.telefono, v.estado);                               
            }

        }
    

        public List<clsDueño> listar()
        {

            List<clsDueño> lista = new List<clsDueño>();
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
         
                    clsDueño c = new clsDueño();
                    c.id = br.ReadInt32();
                    c.dni = br.ReadInt32();
                    c.nombre = br.ReadString();
                    c.apellido = br.ReadString();
                    c.telefono = br.ReadString();
                    c.estado = br.ReadBoolean();                    
                    lista.Add(c);

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


        public clsDueño existe(int verificarDni) {
            clsDueño ex = null;
            List<clsDueño> lista = listar();

            foreach(clsDueño c in lista){
                if (c.dni == verificarDni)
                    ex = c;
                }
           

            return ex;
        
        }


        public clsDueño obtener(int verificarID)
        {
            clsDueño ex = null;
            List<clsDueño> lista = listar();

            foreach (clsDueño c in lista)
            {
                if (c.id == verificarID)
                {
                    ex = c;
                    ex.Completo = "C:\\Sistema de Cochera\\Inquilinos\\Inquilinos.dat";
                }
            }


            return ex;

        }


        public string modificar(int idX, int dniX, string nombreX, string apellidoX, string telefonoX) { 
            
            string res="Inquilino no encontrado";

             List<clsDueño> miLista = listar();

             foreach (clsDueño v in miLista)
             {
                 if (v.id == idX) 
                 {
                     v.nombre = nombreX;
                     v.dni = dniX;
                     v.apellido = apellidoX;
                     v.telefono = telefonoX;                     
                     res = "cambio realizado";
                 }             
             }

             generArchivos(miLista);                

            return res;
        }


        public string modificar(int idX,bool estadoX) {

            string res = "Inquilino no encontrado";

            List<clsDueño> miLista = listar();

            foreach (clsDueño v in miLista)
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

        public List<clsDueño> listarAlta()
        {

            List<clsDueño> lista = new List<clsDueño>();
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

                    clsDueño c = new clsDueño();
                    c.id = br.ReadInt32();
                    c.dni = br.ReadInt32();
                    c.nombre = br.ReadString();
                    c.apellido = br.ReadString();
                    c.telefono = br.ReadString();
                    c.estado = br.ReadBoolean();

                    if (c.estado)
                    {
                        lista.Add(c);
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




}


    


