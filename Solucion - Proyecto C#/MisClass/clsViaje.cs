using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MisClass
{
    class clsViaje : clsArchivos
    {

        // CONSULTAR GUARDAR PRECIO INT

        /* IDvehiculo
         * IDchofer
         * fecha salida
         * fecha vuelta
         * precio;
         * 
         */
        int id_viaje;
        int id_chofer;
        int id_vehiculo;
        int diaSalida;
        int mesSalida;
        int añoSalida;
        int diaRetorno;
        int mesRetorno;
        int añoRetorno;
        int precio;

        public clsViaje(string arch, string dir)
            : base(arch, dir)
        {

        }



        public string grabarViaje(int idvehiculo, int idchofer, DateTime fechaSalida, DateTime fechaRetorno, int precio)
        {

            string msg = string.Empty;


            try
            {
                GrabarEntero(this.obtenerID());
                GrabarEntero(idvehiculo);
                GrabarEntero(idchofer);
                //fecha Salida
                GrabarEntero(fechaSalida.Day);
                GrabarEntero(fechaSalida.Month);
                GrabarEntero(fechaSalida.Year);
                //FechaEntrada
                GrabarEntero(fechaRetorno.Day);
                GrabarEntero(fechaRetorno.Month);
                GrabarEntero(fechaRetorno.Year);
                GrabarEntero(precio);
                this.aumentarID();

            }

            catch (Exception ex)
            {
                msg = ex.Message;
            }



            return msg;

        }


        public List<clsViaje> listar()
        {

            List<clsViaje> lista = new List<clsViaje>();

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
                    this.id_viaje = br.ReadInt32();
                    this.id_chofer = br.ReadInt32();
                    this.id_vehiculo = br.ReadInt32();
                    this.diaSalida = br.ReadInt32();
                    this.mesSalida = br.ReadInt32();
                    this.añoSalida = br.ReadInt32();
                    this.diaRetorno = br.ReadInt32();
                    this.mesRetorno = br.ReadInt32();
                    this.añoRetorno = br.ReadInt32();
                    lista.Add(this);

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





        public void generArchivos(List<clsViaje> miLista)
        {

            if (Directory.Exists(this.Completo))
                Directory.Delete(this.Completo);
            if (File.Exists(this.Archivo))
                File.Delete(this.Archivo);

            foreach (clsViaje v in miLista)
            {
                DateTime salida = new DateTime(v.añoSalida, v.mesSalida, v.añoSalida);
                DateTime vuelta = new DateTime(v.añoRetorno, v.mesRetorno, v.diaRetorno);
                grabarViaje(v.id_vehiculo, v.id_chofer, salida, vuelta, v.precio);

            }

        }



        public int choferDisponible(int idChof, DateTime consultaSalida,DateTime consultaVuelta)
        {
            int resultado = 0;
            List<clsViaje> misViajes = this.listar();

            foreach (clsViaje viaje in misViajes)
                if (viaje.id_chofer == idChof)                   
                {
                    DateTime Salida = new DateTime(viaje.añoSalida,viaje.mesSalida,viaje.diaSalida);
                    DateTime Vuelta = new DateTime(viaje.añoRetorno,viaje.mesRetorno,viaje.diaRetorno);
                    if ((consultaSalida > Vuelta || consultaVuelta < Salida))
                    {
                        resultado = -1;
                    }
                    else
                    {
                        return viaje.id_viaje;
                    }
                }
            return resultado;
            //si resultado es 0 no se encontró el chofer, si el resultado es -1 esta libre
            //si esta ocupado, devuelve el ID del viaje en el cual esta ocupado en esa fecha.
        }


        public int VehiculoDisponible(int idVeh, DateTime consultaSalida, DateTime consultaVuelta)
        {
            int resultado = 0;
            List<clsViaje> misViajes = this.listar();

            foreach (clsViaje viaje in misViajes)
                if (viaje.id_vehiculo == idVeh)
                {
                    DateTime Salida = new DateTime(viaje.añoSalida, viaje.mesSalida, viaje.diaSalida);
                    DateTime Vuelta = new DateTime(viaje.añoRetorno, viaje.mesRetorno, viaje.diaRetorno);
                    if ((consultaSalida > Vuelta || consultaVuelta < Salida))
                    {
                        resultado = -1;
                    }
                    else
                    {
                        return viaje.id_viaje;
                    }
                }
            return resultado;
            //si resultado es 0 no se encontró el Vechiulo, si el resultado es -1 esta libre
            //si esta ocupado, devuelve el ID del viaje en el cual esta ocupado en esa fecha.
        }

    }


}

            










    

