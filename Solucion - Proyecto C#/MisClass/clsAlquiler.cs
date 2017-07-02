using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MisClass
{
    public class clsAlquiler :clsArchivos
    {
        int idAlquiler;
        int idVehiculo;
        int idTarifa;
        int idLote;

        /*
         * dias
         * meses
         * años
         * horas
         * minutos                 
         */
        DateTime entrada;
        DateTime salida;
        bool estado;


        #region getyset 

        public int IdAlquiler
        {
            get { return idAlquiler; }
            set { idAlquiler = value; }
        }
   

        public int IdVehiculo
        {
            get { return idVehiculo; }
            set { idVehiculo = value; }
        }

        public int IdTarifa
        {
            get { return idTarifa; }
            set { idTarifa = value; }
        }

        public int IdLote
        {
            get { return idLote; }
            set { idLote = value; }
        }


        public DateTime Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public DateTime Salida
        {
            get { return salida; }
            set { salida = value; }
        }

        bool pago;

        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }


#endregion



        public clsAlquiler(string arch, string dir):base(arch,dir)
        { 
        
        }

        public clsAlquiler() { 
        
        }



       //metodo Alquiler esta definido para alquileres por DIAS definidos
        public string grabarAlquilerDias(int Vehiculo,int Tarifa, int Lote, DateTime salida,bool pago) {

          

            string valor = string.Empty;

            try
            {
                GrabarEntero(this.obtenerID() + 1);
                GrabarEntero(Vehiculo);
                GrabarEntero(Tarifa);
                GrabarEntero(Lote);


                GrabarEntero(DateTime.Today.Day);
                GrabarEntero(DateTime.Today.Month);
                GrabarEntero(DateTime.Today.Year);
                
                GrabarEntero(salida.Day);
                GrabarEntero(salida.Month);
                GrabarEntero(salida.Year);


                GrabarBool(pago);
                GrabarBool(true);
                aumentarID();

            }
                

            catch (Exception ex)
            {
                valor = ex.Message;
            }


            return valor;

        }

        //metodo Alquiler esta definido por horas o dias indefinido
        public string grabarAlquilerIndefinido(int Vehiculo, int Tarifa, int Lote)
        {


            string valor = string.Empty;

            try
            {
                GrabarEntero(this.obtenerID() + 1);
                GrabarEntero(Vehiculo);
                GrabarEntero(Tarifa);
                GrabarEntero(Lote);

                GrabarEntero(DateTime.Today.Day);
                GrabarEntero(DateTime.Today.Month);
                GrabarEntero(DateTime.Today.Year);


                GrabarEntero(0);
                GrabarEntero(0);
                GrabarEntero(0);


                GrabarBool(false);
                GrabarBool(true);

                aumentarID();

            }


            catch (Exception ex)
            {
                valor = ex.Message;
            }

            return valor;

        }


        //metodo Alquiler con ID para generarArchivos.
        public string grabarAlquilerDias(int idelim, int Vehiculo, int Tarifa, int Lote, DateTime entrada, DateTime salida,bool pago,bool estado)
        {



            string valor = string.Empty;

            try
            {
                GrabarEntero(idelim);
                GrabarEntero(Vehiculo);
                GrabarEntero(Tarifa);
                GrabarEntero(Lote);


                GrabarEntero(entrada.Day);
                GrabarEntero(entrada.Month);
                GrabarEntero(entrada.Year);


                GrabarEntero(salida.Day);
                GrabarEntero(salida.Month);
                GrabarEntero(salida.Year);




                GrabarBool(pago);
                GrabarBool(estado);


            }


            catch (Exception ex)
            {
                valor = ex.Message;
            }


            return valor;

        }
        //metodo Alquiler indefinido con ID para generarArchivos.
        public string grabarAlquilerIndefinido(int idelim, int Vehiculo, int Tarifa, int Lote, DateTime entrada, bool pago, bool estado)
        {


            string valor = string.Empty;

            try
            {
                GrabarEntero(idelim);
                GrabarEntero(Vehiculo);
                GrabarEntero(Tarifa);
                GrabarEntero(Lote);

                GrabarEntero(entrada.Day);
                GrabarEntero(entrada.Month);
                GrabarEntero(entrada.Year);


                GrabarEntero(0);
                GrabarEntero(0);
                GrabarEntero(0);


                GrabarBool(pago);
                GrabarBool(estado);

            }


            catch (Exception ex)
            {
                valor = ex.Message;
            }

            return valor;

        }


        public string darBaja(int idElim)
        {
            string estado = "no encontrado";
            List<clsAlquiler> lista = listar();

            foreach (clsAlquiler alq in lista)
            {
                if (idElim == alq.idAlquiler)
                {
                    alq.estado = false;
                    estado = "eliminado";
                    clsLote misLotes = new clsLote("Lotes", "C:\\Sistema de Cochera\\Lotes");
                    misLotes.setLibre(alq.idLote);
                }
            }

            if (estado.Equals("eliminado")) 
                  generArchivos(lista); 
            
            return estado;

        }

        public string darAlta(int idVeh)
        {
            string estado = "no encontrado";
            List<clsAlquiler> lista = listar();

            foreach (clsAlquiler alq in lista)
            {
                if (idVeh == alq.idVehiculo)
                {
                    alq.estado = true;
                    estado = "eliminado";
                    clsLote misLotes = new clsLote("Lotes", "C:\\Sistema de Cochera\\Lotes");                    
                }
            }

            if (estado.Equals("eliminado"))
                generArchivos(lista);

            return estado;

        }

        public List<clsAlquiler> listarAlta()
        {

            List<clsAlquiler> lista = new List<clsAlquiler>();
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

                    clsAlquiler alq = new clsAlquiler();
                    alq.idAlquiler = br.ReadInt32();
                    alq.idVehiculo = br.ReadInt32();
                    alq.idTarifa = br.ReadInt32();
                    alq.idLote = br.ReadInt32();

                    int diaE = br.ReadInt32();
                    int mesE = br.ReadInt32();
                    int añoE = br.ReadInt32();

                    alq.entrada = new DateTime(añoE, mesE, diaE, 0, 0, 0);

                    int diaS = br.ReadInt32();
                    int mesS = br.ReadInt32();
                    int añoS = br.ReadInt32();

                    if (añoS == 0)
                    {
                        alq.salida = new DateTime();
                    }
                    else
                    {
                        alq.salida = new DateTime(añoS, mesS, diaS, 0, 0, 0);
                    }
                    alq.pago = br.ReadBoolean();
                    alq.estado = br.ReadBoolean();

                    if (alq.estado)
                    {
                        lista.Add(alq);
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

        public List<clsAlquiler> listar()
        {

            List<clsAlquiler> lista = new List<clsAlquiler>();
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

                    clsAlquiler alq = new clsAlquiler();
                    alq.idAlquiler = br.ReadInt32();
                    alq.idVehiculo = br.ReadInt32();
                    alq.idTarifa = br.ReadInt32();
                    alq.idLote = br.ReadInt32();

                    int diaE = br.ReadInt32();
                    int mesE = br.ReadInt32();
                    int añoE = br.ReadInt32();

                    alq.entrada = new DateTime(añoE, mesE, diaE, 0, 0, 0);

                    int diaS = br.ReadInt32();
                    int mesS = br.ReadInt32();
                    int añoS = br.ReadInt32();

                    if (añoS == 0)
                    {
                        alq.salida = new DateTime();
                    }
                    else
                    {
                        alq.salida = new DateTime(añoS, mesS, diaS, 0, 0, 0);
                    }
                    alq.pago = br.ReadBoolean();
                    alq.estado = br.ReadBoolean();

                   
                        lista.Add(alq);
                    


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

        public void generArchivos(List<clsAlquiler> miLista)
        {

            if (File.Exists(this.Completo))
                File.Delete(this.Completo);

            foreach (clsAlquiler  alq in miLista)
            {
                if (alq.salida.Year != 0) {

                    grabarAlquilerDias(alq.idAlquiler, alq.idVehiculo, alq.idTarifa, alq.idLote, alq.entrada, alq.salida,alq.pago,alq.estado);
                }

                else {
                    grabarAlquilerIndefinido(alq.idAlquiler, alq.idVehiculo, alq.idTarifa, alq.idLote, entrada, alq.pago, alq.estado);
                }
            }

        }


        public bool enUso(int IdVeh) {

            foreach (clsAlquiler alq in this.listar()) {

                if (alq.idVehiculo == IdVeh && alq.estado) {
                    return true;
                    }
            
            }
            return false;        
        }



        public string marcarPago(int idApagar){
            string respuesta = "Nada";

            List<clsAlquiler> listado = this.listar();

            foreach (clsAlquiler alq in listado) {

                if (alq.idAlquiler == idApagar) {
                    alq.pago = true;
                    respuesta = "Pago";
                }

            }


                generArchivos(listado);
            

            return respuesta;
        
        }


        public List<clsAlquiler> listarHOY()
        {

            List<clsAlquiler> lista = new List<clsAlquiler>();
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

                    clsAlquiler alq = new clsAlquiler();
                    alq.idAlquiler = br.ReadInt32();
                    alq.idVehiculo = br.ReadInt32();
                    alq.idTarifa = br.ReadInt32();
                    alq.idLote = br.ReadInt32();

                    int diaE = br.ReadInt32();
                    int mesE = br.ReadInt32();
                    int añoE = br.ReadInt32();

                    alq.entrada = new DateTime(añoE, mesE, diaE);

                    int diaS = br.ReadInt32();
                    int mesS = br.ReadInt32();
                    int añoS = br.ReadInt32();

                    if (añoS == 0)
                    {
                        alq.salida = new DateTime();
                    }
                    else
                    {
                        alq.salida = new DateTime(añoS, mesS, diaS);
                    }
                    alq.pago = br.ReadBoolean();
                    alq.estado = br.ReadBoolean();

                    if (alq.salida == DateTime.Today && alq.estado != false)
                    {
                        lista.Add(alq);
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


}
