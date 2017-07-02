using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MisClass
{
    public class clsFactura : clsArchivos
    {

        DateTime salida;

        public DateTime Salida
        {
            get { return salida; }
            set { salida = value; }
        }
        decimal monto;

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public clsFactura(string arch, string dir)
            : base(arch, dir)
        {
        }
        public clsFactura()
        {
            this.Completo = "C:\\Sistema de Cochera\\Facturas\\Facturas.dat";
            this.Directorio = " C:\\Sistema de Cochera\\Facturas";
        }

        public string GrabarFactura(DateTime salida, decimal monto, string nombre, string tipo)
        {

            string res = string.Empty;
            try
            {

                GrabarEntero(salida.Day);
                GrabarEntero(salida.Month);
                GrabarEntero(salida.Year);

                GrabarDecimal(monto);
                GrabarTexto(nombre);
                GrabarTexto(tipo);
            }

            catch (IOException e)
            {
                res = e.ToString();
            }

            return res;
        }

        public List<clsFactura> listarFacturas()
        {

            List<clsFactura> lista = new List<clsFactura>();
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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();
                    lista.Add(f);
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

        public List<clsFactura> listarFacturas(int mesF)
        {


            List<clsFactura> lista = new List<clsFactura>();
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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();

                    if (mesF != 0)
                    {
                        if (f.salida.Month == mesF)
                        {
                            lista.Add(f);
                        }
                    }

                    else
                        lista.Add(f);
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

        public List<clsFactura> listarFacturas(DateTime dthoy)
        {
            List<clsFactura> lista = new List<clsFactura>();
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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();


                    if (f.salida == dthoy)
                    {
                        lista.Add(f);
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


        public List<clsFactura> listarFacturasAño(int añoX)
        {


            List<clsFactura> lista = new List<clsFactura>();
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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();


                    if (f.salida.Year == añoX)
                    {
                        lista.Add(f);
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

        public List<clsFactura> listarFacturas(int mesF,int añoF)
        {


            List<clsFactura> lista = new List<clsFactura>();
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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();

                    if (mesF != 0)
                    {
                        if (añoF == f.salida.Year && f.salida.Month == mesF)
                        {
                            lista.Add(f);
                        }
                    }
                    else {
                        if (añoF == f.salida.Year)
                        {
                            lista.Add(f);
                        }
                    
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


        //operaciones Monto
        public decimal montoTotalDia(int diaX, int mesX, int añoX)
        {

            decimal totalDia = 0;

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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();

                    //si es un año especifico
                    if (añoX != 0 && añoX == f.salida.Year)
                    {
                        //si es un mes especifico
                        if (mesX != 0)
                        {
                            if (f.salida.Month == mesX && diaX == f.salida.Day)
                            {
                                totalDia += f.monto;
                            }
                        }
                        else
                        {
                            if (diaX == f.salida.Day)
                                totalDia += f.monto;

                        }
                    }

                    else {
                        if (mesX != 0)
                        {
                            if (f.salida.Month == mesX && diaX == f.salida.Day)
                            {
                                totalDia += f.monto;
                            }
                        }
                        else
                        {
                            if (diaX == f.salida.Day)
                                totalDia += f.monto;

                        }
                    }

                }


                br.Close();
                fs.Close();

            }
            catch (IOException x)
            {

                return -1;
            }


            return totalDia;

        }



        public decimal montoTotalMes(int mesX, int añoX) {
            decimal monto = 0;

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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();



                    //si es un año especifico
                    if (añoX != 0 && añoX == f.salida.Year)
                    {

                        if (f.salida.Month == mesX)
                        {
                            monto += f.monto;
                        }


                    }
                        //todo los años
                    else
                    {
                        if (f.salida.Month == mesX)
                        {
                            monto += f.monto;
                        }

                    }
                }


                br.Close();
                fs.Close();

            }
            catch (IOException x)
            {

                return -1;
            }


            return monto;
        }

        public decimal total()
        {
            List<clsFactura> lista = listarFacturas();
            decimal total = 0;
            foreach (clsFactura f in lista) {
                total += f.monto;
            }

            return total;

        }


        //operaciones Tipos

        public int tipoTotalDia(int diaX, int mesX, int añoX,string tipoX)
        {

            int TotalTipo = 0;

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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();

                    //si es un año especifico
                    if (añoX != 0 && añoX == f.salida.Year)
                    {
                        //si es un mes especifico
                        if (mesX != 0)
                        {
                            if (f.salida.Month == mesX && diaX == f.salida.Day)
                            {
                                if (f.tipo.Equals(tipoX))
                                    TotalTipo++;
                            }
                        }
                        else
                        {
                            if (diaX == f.salida.Day)
                                if (f.tipo.Equals(tipoX))
                                    TotalTipo++;

                        }
                    }

                    else
                    {
                        if (mesX != 0)
                        {
                            if (f.salida.Month == mesX && diaX == f.salida.Day)
                            {
                                if (f.tipo.Equals(tipoX))
                                TotalTipo++;
                            }
                        }
                        else
                        {
                            if (f.tipo.Equals(tipoX))
                                TotalTipo++;

                        }
                    }

                }


                br.Close();
                fs.Close();

            }
            catch (IOException x)
            {

                return -1;
            }


            return TotalTipo;

        }

        public int tipoTotalMes(int mesX, int añoX,string tipoX)
        {
            int TotalTipo = 0;

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

                    clsFactura f = new clsFactura();
                    int dia = br.ReadInt32();
                    int mes = br.ReadInt32();
                    int año = br.ReadInt32();

                    f.salida = new DateTime(año, mes, dia);

                    f.monto = br.ReadDecimal();
                    f.nombre = br.ReadString();
                    f.tipo = br.ReadString();



                    //si es un año especifico
                    if (añoX != 0)
                    {
                        if (añoX == f.salida.Year && f.salida.Month == mesX)
                        {

                            if (f.tipo.Equals(tipoX))
                                TotalTipo++;
                        }

                    }
                    //todo los años
                    else
                    {
                        if (f.salida.Month == mesX)
                        {
                            if (f.tipo.Equals(tipoX))
                                TotalTipo++;
                        }

                    }
                }


                br.Close();
                fs.Close();

            }
            catch (IOException x)
            {

                return -1;
            }


            return TotalTipo;
        }

    }
}

