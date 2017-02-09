using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _99Park.Code.BLL;
using _99Park.Code.DTO;

namespace _99Park
{
    public partial class frmLogin : Form
    {
        usuarioBLL oUsuarioBLL = new usuarioBLL();
        usuarioDTO oUsuarioDTO = new usuarioDTO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            oUsuarioDTO.usuario  =   txtUsuario.Text;
            oUsuarioDTO.senha    =   txtSenha.Text;
            oUsuarioBLL.realizaLogin(oUsuarioDTO);

        }
    }
}
