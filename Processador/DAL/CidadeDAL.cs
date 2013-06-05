using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODEL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CidadeDAL
    {
        public void Cadastrar(CidadeINFO cidade)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", cidade.Nome);
                cmd.Parameters.AddWithValue("@Estado", cidade.Estado);
                cmd.Parameters.AddWithValue("@Capital", cidade.Capital);
                cmd.CommandText = "pr_Cidade_Inserir";
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
