using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99Park.Code.DAL
{
    class acessoAoBanco
    {

        
        public static SqlParameter param;
        public static SqlCommand command;
        public static string strConexao = Properties.Settings.Default.strConexao;
        public static SqlConnection sqlconnection = new SqlConnection(strConexao);
      //  sqlconnection = new SqlConnection(strConexao);

        public static SqlConnection conexao(){

            try
            {
                

                

                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }

                return sqlconnection;
            }catch(Exception ex)
            {
                throw ex;
            }
            
            }

        public static void AbreConexao()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
            else {
                sqlconnection.Open();
            }
        }

        public static void FechaConexao()
        {
            sqlconnection.Close();
        }

        public static void AdicionarParmetros(string pnome, SqlDbType ptipo, int ptamanho, object pvalor)
        {
            param = new SqlParameter();
            param.ParameterName = pnome;
            param.SqlDbType = ptipo;
            param.Size = ptamanho;
            param.Value = pvalor;
        }

        public static void LimparParametros()
        {
            command.Parameters.Clear();
        }

       // public DataTable ExecutaConsulta(string sql)

    }
}
