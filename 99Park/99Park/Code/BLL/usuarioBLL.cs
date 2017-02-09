using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _99Park.Code.DTO;
using _99Park.Code.DAL;
using System.Windows.Forms;

namespace _99Park.Code.BLL
{
    class usuarioBLL
    {
        public bool realizaLogin(usuarioDTO oUsuarioDTO)
        {
            acessoAoBanco.FechaConexao();
            acessoAoBanco.conexao();
            acessoAoBanco.AbreConexao();

            MessageBox.Show("Primeiro Teste com conexão");

            return true;
        }
    }
}
