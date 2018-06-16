using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            staUsuario.Text = DateTime.Now.ToShortDateString();
            staUsuario = "Usuário atual:" + Properties.Settings.Default.NomeUsuarioLogado;
            Checa_Teclas();
        }

        private void MDI_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumLock)
                staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
            if (e.KeyCode == Keys.CapsLock)
                staCaps.Text = staCaps.Text == "CAP" ? "" : "CAP";

            Checa_Teclas();
        }

        private void Checa_Teclas()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                staCaps.Text = "CAP";
                staCaps.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staCaps.Text = "";
                staCaps.BorderStyle = Border3DStyle.Sunken;
            }

            if (Control.IsKeyLocked(Keys.NumLock))
            {
                staNum.Text = "NUM";
                staNum.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staNum.Text = "";
                staCaps.BorderStyle = Border3DStyle.Sunken;
            }

            if (Control.IsKeyLocked(Keys.NumLock))
            {
                staNum.Text = "NUM";
                staNum.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staNum.Text = "NUM";
                staNum.BorderStyle = Border3DStyle.Sunken;
            }
        }
    }
}
