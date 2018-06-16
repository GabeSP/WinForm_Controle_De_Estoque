using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasLogin()
        {
            if (txtUsuario.Text == "")
            {
                errError.SetError(txtUsuario, "Informar usuário!");
                return false;
            }
            else
            {
                errError.SetError(txtUsuario, "");
            }

            if (txtSenha.Text == "")
            {
                errError.SetError(txtSenha, "Informar senha!");
                return false;
            }
            else
            {
                errError.SetError(txtSenha, "");
                return true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CaixasLogin())
            {
                if (txtUsuario.Text != "Anne" || txtSenha.Text != "123")
                {
                    MessageBox.Show("Usuário ou Senha inválidos!");
                    vErros++;//é o mesmo que vErros = vErros +1;
                    if (vErros == 3)
                    {
                        MessageBox.Show("Números de tentativas esgotado...");

                        Close();
                    }
                }
                else
                {
                    Properties.Settings.Default.NivelUsuarioLogado = 1;
                    Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                    MDI_Menu frmMenuPrincipal = new MDI_Menu();
                    frmMenuPrincipal.Show();
                    Close();
                }
            }
            /*if (CaixasLogin())
            {
                DataSet_Dados_Do_Banco.UsuarioDataTable dtUsuario;
                UsuarioTableAdapter taUsuario = new UsuarioTableAdapter();
                dtUsuario = taUsuario.VerificaNivel(txtUsuario.Text,txtSenha.Text); 
                if (dtUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou Senha inválidos!");
                    vErros++;//é o mesmo que vErros = vErros +1;
                    if (vErros == 3)
                    {
                        MessageBox.Show("Números de tentativas esgotado...");
                        taUsuario.Dispose();
                        Close();
                    }
                }
                else
                {
                    Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
                    Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                    MDI_Menu frmMenuPrincipal = new MDI_Menu();
                    frmMenuPrincipal.Show();
                    Close();
                }
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
