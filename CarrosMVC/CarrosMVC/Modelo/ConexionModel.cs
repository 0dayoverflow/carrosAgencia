using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosMVC.Modelo
{
    internal class ConexionModel
    {
        public string ServerName { get; set; } //MONSTER\\SQLEXPRESS
        public string DatabaseName { get; set; }
        public string GetConnectionString()
        {
            string connectionString = $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security=True;Encrypt=False;";
            return connectionString;
        }
    }
}
