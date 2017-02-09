using System;
using System.Windows.Forms;
using _99Park.Code.BLL;
using _99Park.Code.DTO;

namespace _99Park
{
    public partial class frmLogin : Form
    {
        UsuarioBLL oUsuarioBLL = new UsuarioBLL();
        UsuarioDTO oUsuarioDTO = new UsuarioDTO();

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
