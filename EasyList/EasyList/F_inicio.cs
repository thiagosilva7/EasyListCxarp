using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyList
{
    public partial class F_inicio : Form
    {
        public F_inicio()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            F_gerenciaLista f_GerenciaLista = new F_gerenciaLista();
            f_GerenciaLista.Show();
            Visible = false;
        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Visible = false;
            F_main f_Main = new F_main();
            f_Main.Show();
        }
    }
}
