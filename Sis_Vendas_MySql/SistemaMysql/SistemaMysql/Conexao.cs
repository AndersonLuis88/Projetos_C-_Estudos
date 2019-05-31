using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql
{
    class Conexao
    {

        //HOSPEDAGEM LOCAL SERVIDOR XAMPP
        string conexao = "SERVER=localhost; DATABASE=sistema_clientes; UID=root; PWD=;";

        
        public MySqlConnection con = null;
        

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
