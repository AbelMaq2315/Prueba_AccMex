using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;


namespace ABB_ACCMEX.Datos
{
    public class ConexionBD_ABBACCMEX
    {
        //public static string conexion = "Data Source=35.224.226.204;Initial Catalog=bd_ABB_ACCMEX;User ID=AdminABB;Password=visual2023;";
        //public static SqlConnection conectar = new SqlConnection(conexion);
        private SqlConnection connection = null;

        public ConexionBD_ABBACCMEX()
        {
            this.connection = new SqlConnection("Data Source=35.224.226.204;Initial Catalog=bd_ABB_ACCMEX;User ID=AdminABB;Password=visual2023;");
        }
        public void Abrir()
        {
            try
            {
                connection.Open();
            }catch(Exception ex)
            {
                throw new Exception("Error: "+ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: "+ex.Message);
            }
        }

        public DataTable Confirmar(string id,string pass)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.CommandText = "EXEC sp_ABB_ConfirmarLogin '"+id+"','"+pass+"'";
                //dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
              //  dataAdapter.SelectCommand.Parameters.AddWithValue("@id",id);
                //dataAdapter.SelectCommand.Parameters.AddWithValue("@pass", pass);
                dataAdapter.SelectCommand.Connection = connection;
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }catch(Exception ex)
            {
                throw new YourCustomException("Error: "+ex);
            }
        }


    } 

}

