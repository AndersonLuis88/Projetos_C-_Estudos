using SistemaMysql.Entidades;
using SistemaMysql.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.View;

namespace SistemaMysql
{
    public partial class Login : Form
    {
        UsuarioModel model = new UsuarioModel();

        public Login()
        {
            InitializeComponent();
        }


        public void Logar(User dado)
        {
            try
            {

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o Usuário!");
                    txtUsuario.Focus();
                    return;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha a Senha!");
                    txtSenha.Focus();
                    return;
                }

                dado.Usuario = txtUsuario.Text;
                dado.Senha = txtSenha.Text;
              


                dado = model.Login(dado);

                if(dado.Usuario == null)
                {
                    lblMensagem.Text = "Usuário ou senha incorretos!!";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }

                TelaPrincipal form = new TelaPrincipal();
                this.Hide();
                form.Show();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Logar " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User usuario = new User();
            Logar(usuario);
        }
    }
}
