using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMysql.DAO;
using SistemaMysql.Entidades;

namespace SistemaMysql.Model
{
    public class UsuarioModel
    {
        UsuarioDAO dao = new UsuarioDAO();

        public User Login(User dado)
        {
            try
            {
                return dao.Login(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
