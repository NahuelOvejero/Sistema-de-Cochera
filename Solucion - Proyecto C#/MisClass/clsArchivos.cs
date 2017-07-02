using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class clsArchivos
{

    int id;
    string archivo;
    string directorio;
    string completo;
    string idArchivo;



    public clsArchivos(string arch, string dir)
    {

        archivo = arch + ".dat";
        directorio = dir;
        completo = directorio + "\\" + archivo;
        idArchivo = directorio + "\\" + "ID" + archivo;


        this.CrearArchivos();



    }

    public clsArchivos() { 
    //sobrecarga para crear hijos sin parametros
    }








    #region getset

    public string IdArchivo
    {
        get { return idArchivo; }
        set { idArchivo = value; }
    }


    public string Directorio
    {
        get { return directorio; }
        set { directorio = value; }
    }

    public string Archivo
    {
        get { return archivo; }
        set { archivo = value; }
    }

    public string Completo
    {
        get { return completo; }
        set { completo = value; }
    }

    #endregion


    public string CrearArchivos()
    {
        FileStream fs;
        string valor = string.Empty;
        try
        {
            
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);


            if (!File.Exists(idArchivo))
            {
                fs = new FileStream(idArchivo, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(0);
                bw.Close();
                fs.Close();
                fs.Dispose();
                id = 0;
            }

            else
            {
                id = obtenerID();
            }

            if (!File.Exists(completo))
            {
               
                fs = new FileStream(completo, FileMode.Create);
                fs.Close();
                fs.Dispose();
            }
        }
        catch (IOException ex)
        { valor = ex.Message; }


        return valor;


    }


    public string GrabarTexto(string dato)
    {

        FileStream fs;
        BinaryWriter bw;

        string valor = string.Empty;


        if (!Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(completo))
            fs = new FileStream(completo, FileMode.Create);

        else
            fs = new FileStream(completo, FileMode.Append);

        bw = new BinaryWriter(fs, Encoding.ASCII);

        try
        {
            bw.Write(dato);
        }
        catch (Exception ex)
        {
            valor = ex.Message.ToString();
        }

        bw.Close();
        fs.Close();
        fs.Dispose();

        return valor;
    }


    public string GrabarEntero(int dato)
    {
        FileStream fs;
        BinaryWriter bw;

        string valor = string.Empty;


        if (!Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(completo))
            fs = new FileStream(completo, FileMode.Create);

        else
            fs = new FileStream(completo, FileMode.Append);

        bw = new BinaryWriter(fs, Encoding.ASCII);

        try
        {
            bw.Write(dato);
        }
        catch (Exception ex)
        {
            valor = ex.Message.ToString();
        }

        bw.Close();
        fs.Close();
        fs.Dispose();

        return valor;
    }


    public string GrabarBool(Boolean dato) {

        FileStream fs;
        BinaryWriter bw;

        string valor = string.Empty;


        if (!Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(completo))
            fs = new FileStream(completo, FileMode.Create);

        else
            fs = new FileStream(completo, FileMode.Append);

        bw = new BinaryWriter(fs, Encoding.ASCII);

        try
        {
            bw.Write(dato);
        }
        catch (Exception ex)
        {
            valor = ex.Message.ToString();
        }

        bw.Close();
        fs.Close();
        fs.Dispose();

        return valor;
    
    }


    public string GrabarDecimal(decimal dato) {

        FileStream fs;
        BinaryWriter bw;

        string valor = string.Empty;


        if (!Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(completo))
            fs = new FileStream(completo, FileMode.Create);

        else
            fs = new FileStream(completo, FileMode.Append);

        bw = new BinaryWriter(fs, Encoding.ASCII);

        try
        {
            bw.Write(dato);
        }
        catch (Exception ex)
        {
            valor = ex.Message.ToString();
        }

        bw.Close();
        fs.Close();
        fs.Dispose();

        return valor;
    }


    public int obtenerID()
    {
        try
        {
            FileStream fsObt = new FileStream(idArchivo, FileMode.Open);
            BinaryReader brObt = new BinaryReader(fsObt);
            while (brObt.PeekChar() != -1)
            {
                id = brObt.ReadInt32();
            }
            fsObt.Close();
            fsObt.Dispose();
            fsObt.Close();
        }
        catch (Exception ex)
        {            
            id = -2;
        }
        return id;
    }




    public string aumentarID()
    {
        string valor = string.Empty;
        
        FileStream idfs;
                
        if (!Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(idArchivo))
        { idfs = new FileStream(idArchivo, FileMode.Create);
            idfs.Close();
            idfs.Dispose();
        }
        id = obtenerID();
        id++;
            try
        {
            
            File.Delete(idArchivo);
            FileStream crearID =File.Create(idArchivo);
            crearID.Close();
            FileStream fsAuID = new FileStream(idArchivo, FileMode.Append);
            BinaryWriter brAuId = new BinaryWriter(fsAuID);
            brAuId.Write(id);
            fsAuID.Close();
            brAuId.Close();
        }
        
       
           
        
        catch (Exception ex)
        {
            valor = ex.Message.ToString();
        }
        return valor;






    }




}






    
    





