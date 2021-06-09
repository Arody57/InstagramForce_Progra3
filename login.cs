using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using instagramforce.Clases.XML;
using instagramforce.Clases.Arbol_AVL;
using instagramforce.Clases.Usuarios;

namespace instagramforce
{
    public partial class login : Form
    {
        string user = "";
        string password = "";
        Xml_acciones xml_acciones = new Xml_acciones();
        ArbolAVL loginUsuarios = new ArbolAVL();

        public login()
        {
            InitializeComponent();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            if (File.Exists(FileName))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//Usuarios//Usuario");
                foreach (XmlNode ItemNode in itemsNodes)
                {
                    string USERNAME = string.Empty, FULLNAME = string.Empty, PASSWORD = string.Empty, PROFILEIMAGE = string.Empty, BIRTHDATE = string.Empty;

                    foreach (XmlNode item in ItemNode.SelectSingleNode("USERNAME"))
                    {
                        USERNAME = item.InnerText;
                    }
                    foreach (XmlNode item in ItemNode.SelectSingleNode("PASSWORD"))
                    {
                        PASSWORD = item.InnerText;
                    }
                    Login_Usuario loginUsers = new Login_Usuario(USERNAME, PASSWORD);
                    loginUsuarios.insertar(loginUsers);
                }
            }
            else
            {
                xml_acciones.crearXml(FileName, "Usuarios");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario";
            txtUser.ForeColor = Color.Gray;
            txtPass.PasswordChar = '\0';
            txtPass.Text = "Contraseña";
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (user.Equals(""))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
            else
            {
                txtUser.Text = user;
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            user = txtUser.Text;
            if (user.Equals("Usuario"))
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txtUser.Text = "Usuario";
                    txtUser.ForeColor = Color.Gray;
                }
                else
                {
                    txtUser.Text = user;
                    txtUser.ForeColor = Color.Black;
                }
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

            if (password.Equals(""))
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.Text = password;
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            password = txtPass.Text;
            if (password.Equals("Contraseña"))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Gray;
            }
            else
            {
                if (password.Equals(""))
                {
                    txtPass.PasswordChar = '\0';
                    txtPass.Text = "Contraseña";
                    txtPass.ForeColor = Color.Gray;
                }
                else
                {
                txtPass.PasswordChar = '*';
                txtPass.Text = password;
                txtPass.ForeColor = Color.Black;
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Login_Usuario Objestudiantes = new Login_Usuario(txtUser.Text, txtPass.Text);
            //Login_Usuario ObjestudiantesEncontrado = (Login_Usuario)loginUsuarios.buscar(Objestudiantes).valorNodo();
            Login_Usuario ObjestudiantesEncontrado;
            bool flag = false;

            try
            {
                ObjestudiantesEncontrado = (Login_Usuario)loginUsuarios.buscar(Objestudiantes).valorNodo();

                if (ObjestudiantesEncontrado.PASSWORD == Objestudiantes.PASSWORD && ObjestudiantesEncontrado.USERNAME == Objestudiantes.USERNAME)
                {                   
                    instagramHome feedApp = new instagramHome();
                    feedApp.Username = txtUser.Text;
                    this.Hide();
                    feedApp.Visible = true;
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrectas\n" + "¡Vuelve a interntarlo!");
                    txtPass.Text = password;
                    txtPass.Text = "Contraseña";
                    txtPass.ForeColor = Color.Gray;
                }
            }
            catch (Exception)
            {
                flag = true;
                if (flag == true)
                {
                    MessageBox.Show("El usuario es incorrectas\n" + "Usuario no existente\n"+ "¡Vuelve a interntarlo!");
                    txtUser.Text = "Usuario";
                    txtUser.ForeColor = Color.Gray;
                    txtPass.PasswordChar = '\0';
                    txtPass.Text = "Contraseña";
                    txtPass.ForeColor = Color.Gray;
                }
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void newUserProfile_Click(object sender, EventArgs e)
        {
            instagramNewUser formRegister = new instagramNewUser();
            this.Hide();
            formRegister.Show();
        }
    }
}
