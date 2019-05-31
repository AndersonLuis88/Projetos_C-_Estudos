using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMysql.DAO;
using SistemaMysql.Entidades;

namespace SistemaMysql.Model
{
    public class ClienteModel
    {
        ClienteDAO dao = new ClienteDAO();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }
            catch (Exception )
            {

                throw;
            }
        }


        public void Salvar(Clientes dado)
        {
            try
            {
                dao.Salvar(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Editar(Clientes dado)
        {
            try
            {
                dao.Editar(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Clientes dado)
        {
            try
            {
                dao.Excluir(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object Buscar(Clientes dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Buscar(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
