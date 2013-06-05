using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=SSPI;";
                //return "Data Source=" + ConfigurationSettings.AppSettings["DataSource"] + " ;Initial Catalog=" + ConfigurationSettings.AppSettings["InitialCatalog"]
                //    + ";Persist Security Info=True;User ID=" + ConfigurationSettings.AppSettings["UserID"] + ";Password=" + ConfigurationSettings.AppSettings["Password"] + ";";
            }
        }
    }
}