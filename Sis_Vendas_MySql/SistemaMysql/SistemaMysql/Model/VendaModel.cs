using SistemaMysql.DAO;
using SistemaMysql.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Model
{
    class VendaModel
    {
        VendaDAO dao = new VendaDAO();

        public void Salvar(Vendas dado)
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

        internal object Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        internal void Editar(Vendas dado)
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

        internal void Excluir(Vendas dado)
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

        internal object Buscar(Vendas dado)
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
