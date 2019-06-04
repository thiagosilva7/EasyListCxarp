﻿using EasyList.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;


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

            if ((email.Text == "") && (password.Text ==""))
            {
                MessageBox.Show("Informe os dados necessarios", "Alerta!", MessageBoxButtons.OK);
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.email = email.Text;
                usuario.password = password.Text;

                try
                {
                    string URL = "http://10.42.0.1:8080/EasyListRest/usuario?email=" + usuario.email + "&password=" + usuario.password;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "GET";
                    request.Accept = "application/json";
                    WebResponse webResponse = request.GetResponse();
                    HttpStatusCode response_code = ((HttpWebResponse)webResponse).StatusCode;

                    Stream webStream = webResponse.GetResponseStream();
                    StreamReader responseReader = new StreamReader(webStream);
                    string response = responseReader.ReadToEnd();

                    if (response_code == HttpStatusCode.OK)
                    {
                        if (!String.IsNullOrEmpty(response))
                        {
                            MessageBox.Show("Os valores são" + response, "Alerta do sistema", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Valores em branco.", "Alerta do sistema", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro no servidor:" + response, "Alerta do sistema", MessageBoxButtons.OK);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no lado do servidor.", "Alerta do sistema", MessageBoxButtons.OK);
                }
            }

        }
    }
}
