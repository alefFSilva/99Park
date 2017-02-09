using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99Park.Code.DAL
{
    class AcessoAoBanco
    {

        
        private static SqlParameter param;
        private static string strConexao = Properties.Settings.Default.strConexao;
        private static SqlConnection sqlconnection = new SqlConnection(strConexao);
        private static SqlCommand procedure = new SqlCommand
        {
            CommandType = CommandType.StoredProcedure
        };


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

        public static void AdicionarParametro(string pnome, SqlDbType ptipo, int ptamanho, object pvalor)
        {
            param = new SqlParameter();
            param.ParameterName = pnome;
            param.SqlDbType = ptipo;
            param.Size = ptamanho;
            param.Value = pvalor;
        }

        public static void LimparParametro()
        {          
            procedure.Parameters.Clear();
        }

        public static void AdicionaParametros(string pNome, SqlDbType pTipo, object pValor )
        {
            SqlParameter param = new SqlParameter
            {
                ParameterName = pNome,
                SqlDbType = pTipo,
                Value = pValor
            };
            procedure.Parameters.Add(param);

        }

       //public static DataTable ExecutaConsulta(string pProcedure)
       // {


       //     //return DataTable
       // }

    }
}
