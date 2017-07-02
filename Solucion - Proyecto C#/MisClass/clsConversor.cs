using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClass
{
    public class clsConversor
    {

        int idAlq;

        public int IdAlq
        {
            get { return idAlq; }
            set { idAlq = value; }
        }


        DateTime salida;

        public DateTime Salida
        {
            get { return salida; }
            set { salida = value; }
        }



        public string Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }

        string patente;

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        string dueño; //nombre + apellido

        DateTime entrada;


        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        private decimal precio;



        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }


        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public DateTime Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        string lote;

        bool pago;




        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }




        private clsVehiculo miauto;
        private clsDueño midueño;
        private clsLote milote;
        private clsTarifa miTarifa;
        private clsAlquiler mialquiler;

        public clsConversor(clsAlquiler a,clsVehiculo v,clsTarifa t, clsDueño d, clsLote l) {

            mialquiler = a;
            
            miauto = v;
            midueño = d;
            miTarifa = t;
            milote = l;

        }



        public List<clsConversor> convertir(List<clsAlquiler> listado) {


            List<clsConversor> lista = new List<clsConversor>();

            foreach(clsAlquiler alq in listado){

            
            miauto = miauto.retornar(alq.IdVehiculo);

            milote = milote.existe(alq.IdLote);

            midueño = midueño.obtener(miauto.IdDueño);

            miTarifa = miTarifa.existe(alq.IdTarifa);


            clsConversor c = new clsConversor(alq,miauto,miTarifa,midueño,milote);

            c.idAlq = alq.IdAlquiler;
            c.salida = alq.Salida;
            c.patente = miauto.Patente;
            c.dueño = midueño.Nombre + " " + midueño.Apellido;
            c.entrada = alq.Entrada;
            c.lote = milote.Nombre;
            c.pago = alq.Pago;
            c.estado = alq.Estado;
            if (c.salida.Year == 1) {
                int dias = (int)(DateTime.Today - c.entrada).TotalDays;
                c.precio = (1+dias) * miTarifa.Precio;
            }
            else {
                int dias = (int)(c.salida - c.entrada).TotalDays;
                c.precio = ((1+dias) * miTarifa.Precio);
            }


                //ATRIBUTOS RECUPERADOS Y CARGADOS ^


            lista.Add(c);

        }

            return lista;

        }


    }
}
