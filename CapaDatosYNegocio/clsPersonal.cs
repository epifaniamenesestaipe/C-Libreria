using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosYNegocio
{
    public class clsPersonal
    {
        private int _CodigoPersonal;

        public int CodigoPersonal
        {
            get { return _CodigoPersonal; }
            set { _CodigoPersonal = value; }
        }
        private string _DNI;

        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        private string _Nombres;

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        private string _ApPaterno;

        public string ApPaterno
        {
            get { return _ApPaterno; }
            set { _ApPaterno = value; }
        }
        private string _ApMaterno;

        public string ApMaterno
        {
            get { return _ApMaterno; }
            set { _ApMaterno = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private bool _Sexo;

        public bool Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }
        private string _IniSesion;

        public string IniSesion
        {
            get { return _IniSesion; }
            set { _IniSesion = value; }
        }
        private string _Contrasenia;

        public string Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; }
        }
        private string _Cargo;

        public string cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private DateTime _FechaRegistro;

        public DateTime FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }




        //===============================================================
        //CONSTTRUCTOR
        //=========================================================
        public clsPersonal(int argCodigo, string argDNI, string argNombres, string argApPaterno, string argApMaterno,
                            string argDireccion, bool argsexo, string argIniSesion,
                            string argContrasenia, string argCargo, DateTime argFechaRegistro
                            )
        {
            CodigoPersonal = argCodigo;
            DNI = argDNI;
            Nombres = argNombres;
            ApPaterno = argApPaterno;
            ApMaterno = argApMaterno;
            Direccion = argDireccion;
            Sexo = argsexo;
            IniSesion = argIniSesion;
            Contrasenia = argContrasenia;
            cargo = argCargo;
            FechaRegistro = argFechaRegistro;

        }


        // ========================================================================
        //METODOS
        //==============================================================
        public void Insertar()
        {
            SqlConnection conexion;
            conexion = new SqlConnection(mdlVariables.MiCadenaConexion);

            SqlCommand MiComando;
            MiComando = new SqlCommand("usp_Personal_Insertar", conexion);
            MiComando.CommandType = System.Data.CommandType.StoredProcedure;
            //*****************************************************************
            //En los parámetros cuidado con los NULOS y con las LLAVES FORÁNEAS
            //*****************************************************************
            MiComando.Parameters.AddWithValue("@parDNI", DNI);
            MiComando.Parameters.AddWithValue("@parNombres", Nombres);
            MiComando.Parameters.AddWithValue("@parApPaterno", ApPaterno);
            MiComando.Parameters.AddWithValue("@parApMaterno", ApMaterno);
            MiComando.Parameters.AddWithValue("@parDireccion", Direccion);
            MiComando.Parameters.AddWithValue("@parTelefono", Telefono);
            MiComando.Parameters.AddWithValue("@parSexo", Sexo);
            MiComando.Parameters.AddWithValue("@parInicioSesion", IniSesion);
            MiComando.Parameters.AddWithValue("@parContrasenia", Contrasenia);
            MiComando.Parameters.AddWithValue("@parCargo", cargo);

            conexion.Open();
            MiComando.ExecuteNonQuery();
            conexion.Close();
        }
              
    }
}
