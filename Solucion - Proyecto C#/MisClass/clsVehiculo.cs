using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class clsVehiculo : clsArchivos
{

    /*Estructura Vehiculo:
     * ID
     * idDueño
     * Patente
     * Modelo
     * Color
     * Tipo
     * Observaciones
     * Estado
     * */

    #region atributos 
    int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    int idDueño;

    public int IdDueño
    {
        get { return idDueño; }
        set { idDueño = value; }
    }
    string patente;

    public string Patente
    {
        get { return patente; }
        set { patente = value; }
    }
    string modelo;

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    string tipo; //0- Auto 1-Moto 2-Camioneta 3-Camion

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
    string obs;

    public string Observaciones
    {
        get { return obs; }
        set { obs = value; }
    }
    bool estado;

    public bool Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    #endregion


    public clsVehiculo(string arch, string dir): base(arch, dir)
    {
        this.Completo = "C:\\Sistema de Cochera\\Vehiculos\\Vehiculos.dat";
    }
    public clsVehiculo(){
        this.Completo = "C:\\Sistema de Cochera\\Vehiculos\\Vehiculos.dat";
    }


    public string GrabarVehiculo(int idDueño, string patente, string modelo, string color, string tipo, string obs, bool est)
    {
        
        string valor = string.Empty;

        try
        {
            GrabarEntero(this.obtenerID()+1);
            GrabarEntero(idDueño);
            GrabarTexto(patente);
            GrabarTexto(modelo);
            GrabarTexto(color);
            GrabarTexto(tipo);
            GrabarTexto(obs);
            GrabarBool(est);
        }

        catch (Exception ex)
        {
            valor = ex.Message;
        }


        aumentarID();

        return valor;
    }

    public string GrabarVehiculo(int idelim, int idDueño, string patente, string modelo, string color, string tipo, string obs, bool est)
    {

        string valor = string.Empty;

        try
        {
            GrabarEntero(idelim);
            GrabarEntero(idDueño);
            GrabarTexto(patente);
            GrabarTexto(modelo);
            GrabarTexto(color);
            GrabarTexto(tipo);
            GrabarTexto(obs);
            GrabarBool(est);
        }



        catch (Exception ex)
        {
            valor = ex.Message;
        }





        return valor;
    }


    public List<clsVehiculo> listar()
    {

        List<clsVehiculo> lista = new List<clsVehiculo>();

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
                clsVehiculo vehi = new clsVehiculo();

                vehi.id = br.ReadInt32();
                vehi.idDueño = br.ReadInt32();
                vehi.patente = br.ReadString();
                vehi.modelo = br.ReadString();
                vehi.color = br.ReadString();
                vehi.tipo = br.ReadString();
                vehi.obs = br.ReadString();
                vehi.estado = br.ReadBoolean();
                lista.Add(vehi);

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

    public List<clsVehiculo> listarAlta()
    {

        List<clsVehiculo> lista = new List<clsVehiculo>();

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
                clsVehiculo vehi = new clsVehiculo();

                vehi.id = br.ReadInt32();
                vehi.idDueño = br.ReadInt32();
                vehi.patente = br.ReadString();
                vehi.modelo = br.ReadString();
                vehi.color = br.ReadString();
                vehi.tipo = br.ReadString();
                vehi.obs = br.ReadString();
                vehi.estado = br.ReadBoolean();

                if (vehi.estado)
                {
                    lista.Add(vehi);
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


    public void generArchivos(List<clsVehiculo> miLista)
    {

        if (File.Exists(this.Completo))
            File.Delete(this.Completo);

        foreach (clsVehiculo v in miLista)
        {
            GrabarVehiculo(v.id, v.idDueño, v.patente, v.modelo, v.color, v.tipo, v.obs, v.estado);

        }




    }

    public string eliminarVehiculo(int idElim)
    {
        string estado = "no encontrado";
        List<clsVehiculo> lista = listar();
        

        foreach (clsVehiculo v in lista)
        {
            if (idElim == v.id)
            {
                v.estado = false;
                estado = "eliminado";
                generArchivos(lista);
                return estado;
            }
        }        
        return estado;
    }

    public clsVehiculo existe(string pate)
    {
        clsVehiculo ex = null;
        List<clsVehiculo> lista = listar();
        if (lista != null)
        {
            foreach (clsVehiculo v in lista)
            {
                if (v.patente.Equals(pate))
                    ex = v;
            }
        }         
        

        return ex;

    }

    public clsVehiculo retornar(int id)
    {
        clsVehiculo ex = null;
        List<clsVehiculo> lista = listar();
        if (lista != null)
        {
            foreach (clsVehiculo v in lista)
            {
                if (v.id == id)
                {
                    ex = v;
                    ex.Completo = "C:\\Sistema de Cochera\\Vehiculos\\Vehiculos.dat";
                }
            }
        }


        return ex;

    }


    public string modificar(int idX, int idDueñoX, string patX,string modX, string colorX,string tipoX, string obsX)
    {

        string res = "Vehiculo no encontrado";

        List<clsVehiculo> miLista = listar();

        foreach (clsVehiculo v in miLista)
        {
            if (v.id == idX)
            {
                v.idDueño = idDueñoX;
                v.patente = patX;
                v.modelo = modX;
                v.color = colorX;
                v.tipo = tipoX;
                v.obs = obsX;
                res = "cambio realizado";
            }
        }

        generArchivos(miLista);

        return res;
    }
    
    public string modificar(int idX, bool estadoX)
    {

        string res = "Vehiculo no encontrado";

        List<clsVehiculo> miLista = listar();

        foreach (clsVehiculo v in miLista)
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

    public string bajaDueños(int idDueñoX)
    {
        int i = 0;
        string res = "0 Vehiculos dados de baja.";

        List<clsVehiculo> miLista = listar();

        foreach (clsVehiculo v in miLista)
        {
            if (v.idDueño == idDueñoX)
            {
                i++;
                v.estado = false;
                res = "Se han dado de baja" + i + "vehiculos";
            }
        }

        generArchivos(miLista);

        return res;
    }

    public string altaDueño(int idDueñoX) {

        int i = 0;
        string res = "0 Vehiculos dados de alta.";

        List<clsVehiculo> miLista = listar();

        foreach (clsVehiculo v in miLista)
        {
            if (v.idDueño == idDueñoX)
            {
                i++;
                v.estado = true;
                res = "Se han dado de alta" + i + "vehiculos";
            }
        }

        generArchivos(miLista);

        return res;
    }

    public string cambiarDueño(int idDueñoNuevo, int idVeh) {

        string res = "Cambio no realizado";

        try
        {

            List<clsVehiculo> miLista = listar();

            foreach (clsVehiculo v in miLista)
            {
                if (v.id == idVeh)
                {
                    v.idDueño = idDueñoNuevo;
                    res = "cambio realizado";
                }
            }

            generArchivos(miLista);

        }

        catch (Exception e) {
            res = e.Message.ToString();
        }



        return res;
    
    }

    public string recuperarPatente(int Idbusqueda) { 
        foreach(clsVehiculo x in this.listar()){

            if (x.id == Idbusqueda) {
                return x.patente;
            }


        }
        return string.Empty;
    
    }


}






