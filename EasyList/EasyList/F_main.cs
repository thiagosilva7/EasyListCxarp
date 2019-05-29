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
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();

        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            F_inicio f_Inicio = new F_inicio();
            f_Inicio.Show();
            Visible = false;
        }
    }
}
