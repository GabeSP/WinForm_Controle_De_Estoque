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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            EfectTime();
        }

        private bool Efect = true; //Variavel Logica

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (Efect)
            {
                this.Opacity -= 0.01D;
            }
            if(Opacity == 0)
            {
                Efect = false;

                SplashTimer.Enabled = false;//desliga o Timer
                frmLogin frmLogin = new frmLogin();//instancia um form
                frmLogin.Show();//Mostra o login
                Hide();//Oculta o form splash
            }
        }

        private void EfectTime()
        {
            SplashTimer.Interval = 1;//define o tempo do Timer
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick);//Dispara o evento Tick
            SplashTimer.Enabled = true; //Ativa o Timer
            Opacity = 1; //Define Opacidade do form 100%
        }
    }
}
