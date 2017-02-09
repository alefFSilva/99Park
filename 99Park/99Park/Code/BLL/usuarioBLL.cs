using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _99Park.Code.DTO;
using _99Park.Code.DAL;

namespace _99Park.Code.BLL
{
    class usuarioBLL
    {
        public bool realizaLogin(usuarioDTO oUsuarioDTO)
        {

            acessoAoBanco.abreConexao();

            return true;
        }
    }
}
