﻿using System;
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
    public partial class Add_Lista : Form
    {
        public Add_Lista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text;
            window.localStorage.setItem('lista', texto);
        }
    }
}
