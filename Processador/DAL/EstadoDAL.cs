using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODEL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EstadoDAL
    {
        public List<EstadoINFO> Listar(EstadoINFO estado)
        {
            var lstRetorno = new List<EstadoINFO>();
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", estado.Codigo);
                cmd.Parameters.AddWithValue("@Nome", estado.Nome);
                cmd.Parameters.AddWithValue("@Pais", estado.Pais);
                cmd.Parameters.AddWithValue("@Regiao", estado.Regiao);
                cmd.Parameters.AddWithValue("@Sigla", estado.Sigla);
                cmd.CommandText = "pr_Estado_Listar";
                cn.Open();
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(tabela);

                lstRetorno = DataTableToList(tabela);

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
            return lstRetorno;
        }

        private static List<EstadoINFO> DataTableToList(DataTable dtrEstado)
        {
            var lstEstado = new List<EstadoINFO>();
            foreach (DataRow row in dtrEstado.Rows)
            {
                var estado = new EstadoINFO();
                estado.Codigo = Convert.ToInt32(row["Codigo"].ToString());
                estado.Nome = row["Nome"].ToString();
                estado.Pais = row["Pais"].ToString();
                estado.Regiao = row["Regiao"].ToString();
                estado.Sigla = row["Sigla"].ToString();
                lstEstado.Add(estado);
            }
            return lstEstado;
        }
    }
}
