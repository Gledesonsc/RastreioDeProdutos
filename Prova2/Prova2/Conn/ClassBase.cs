using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;

namespace Prova2.Conn
{
    internal class ClassBase
    {
        Connection connection = new Connection();

        //Metodo de cadasrtro 
       public void Cadastro(string nome,string email, string senha)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connection.Connectionstring());

            try
            {
                conn.Open();
                string sql = "INSERT INTO tbl_cadastro1 (nome,email, senha)" + $"VALUES('{nome}','{email}','{senha}')";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }



        }






    }
}
