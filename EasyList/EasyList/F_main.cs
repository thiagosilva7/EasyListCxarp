using EasyList.Entidades;
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
using System.Net.Http;
using System.Net.Http.Headers;
using Json.Net;



namespace EasyList
{
    public partial class F_main : Form
    {
        public F_main()
        {

            InitializeComponent();
            /*  Login login = new Login();
              if (login.id != 0)
              {
                  F_inicio f_Inicio = new F_inicio();
                  f_Inicio.Show();
                  Visible = false;
              }
              else {
                  InitializeComponent();
              }
              */

        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if ((email.Text == "") && (password.Text == ""))
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
                            //MessageBox.Show("Os valores são" + response, "Alerta do sistema", MessageBoxButtons.OK);
                            LocalStorage localStorage = new LocalStorage();
                            Login login = JsonNet.Deserialize<Login>(response);
                            //   MessageBox.Show("Os valores são" + login.id, "Alerta do sistema", MessageBoxButtons.OK);
                            Visible = false;
                            F_inicio f_Inicio = new F_inicio();
                            f_Inicio.Show();
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
                    MessageBox.Show("Erro no lado do servidor." + ex, "Alerta do sistema", MessageBoxButtons.OK);
                }
            }

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_main_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                F_inicio f_Inicio = new F_inicio();
                f_Inicio.Show();
                Visible = false;
            }
        }
    }
}
