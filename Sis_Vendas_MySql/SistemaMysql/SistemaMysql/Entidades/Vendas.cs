using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Entidades
{
   public class Vendas
    {
        int id, id_cliente;
        decimal valor;
        DateTime data;

        public int Id { get => id; set => id = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
