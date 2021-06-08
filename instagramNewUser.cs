using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using instagramforce.Clases.XML;
using System.IO;
using instagramforce.Clases.Arbol_AVL;
using instagramforce.Clases.Usuarios;
using System.Xml;
namespace instagramforce
{
    public partial class instagramNewUser : Form
    {
        string nickNameUser = "";
        string nameRealUser = "";
        string passwordUser = "";
        string dateOfBirthUser = "";
        string pathImagenProfileUser = "";
        Xml_acciones xml_acciones = new Xml_acciones();
        ArbolAVL NuevosUsuarios = new ArbolAVL();
        


        public instagramNewUser()
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
                    foreach (XmlNode item in ItemNode.SelectSingleNode("FULLNAME"))
                    {
                        FULLNAME = item.InnerText;
                    }
                    foreach (XmlNode item in ItemNode.SelectSingleNode("PASSWORD"))
                    {
                        PASSWORD = item.InnerText;
                    }
                    foreach (XmlNode item in ItemNode.SelectSingleNode("PROFILEIMAGE"))
                    {
                        PROFILEIMAGE = item.InnerText;
                    }
                    foreach (XmlNode item in ItemNode.SelectSingleNode("BIRTHDATE"))
                    {
                        BIRTHDATE = item.InnerText;
                    }
                    Nuevos_usuarios newUsers = new Nuevos_usuarios(USERNAME, FULLNAME, PASSWORD, PROFILEIMAGE, BIRTHDATE);
                    NuevosUsuarios.insertar(newUsers);
                }
            }
            else
            {
                xml_acciones.crearXml(FileName, "Usuarios");
            }
        }
        private void instagramNewUser_Load(object sender, EventArgs e)
        {
            txtNickNameUser.Text = "Nombre de usuario";
            txtNickNameUser.ForeColor = Color.Gray;
            txtNameUser.Text = "Nombre completo";
            txtNameUser.ForeColor = Color.Gray;
            txtPasswordUser.PasswordChar = '\0';
            txtPasswordUser.Text = "Contraseña";
            txtPasswordUser.ForeColor = Color.Gray;
            gunaPictureBox1.Image = Image.FromFile("instagramLogin.jpg");
        }

        private void txtNickNameUser_Enter(object sender, EventArgs e)
        {
            nickNameUser = txtNickNameUser.Text;
            if (txtNickNameUser.Text.Equals("") || txtNickNameUser.Text == "Nombre de usuario")
            {
                txtNickNameUser.Text = "";
                txtNickNameUser.ForeColor = Color.Black;
            }
            else
            {
                txtNickNameUser.ForeColor = Color.Black;
            }
        }

        private void txtNameUser_Enter(object sender, EventArgs e)
        {
            nameRealUser = txtNameUser.Text;
            if (txtNameUser.Text.Equals("") || txtNameUser.Text == "Nombre completo")
            {
                txtNameUser.Text = "";
                txtNameUser.ForeColor = Color.Black;
            }
            else
            {
                txtNameUser.ForeColor = Color.Black;
            }
        }
        private void txtPasswordUser_Enter(object sender, EventArgs e)
        {
            passwordUser = txtPasswordUser.Text;
            if (txtPasswordUser.Text.Equals("") || txtPasswordUser.Text == "Contraseña")
            {
                txtPasswordUser.Text = "";
                txtPasswordUser.ForeColor = Color.Black;
                txtPasswordUser.PasswordChar = '*';
            }
            else
            {
                txtPasswordUser.ForeColor = Color.Black;
            }
        }


        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            if (image.ShowDialog() == DialogResult.OK)
            {
                photoProfileUser.Image = Image.FromFile(image.FileName);
                pathImagenProfileUser = image.FileName;
                photoProfileUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void loginExistAccount_Click(object sender, EventArgs e)
        {
            login formLogin = new login();
            this.Hide();
            formLogin.Show();
        }

        private void btnRegistrarCuenta_Click(object sender, EventArgs e)
        {
            nickNameUser = txtNickNameUser.Text;
            nameRealUser =  txtNameUser.Text;
            passwordUser = txtPasswordUser.Text;
            dateOfBirthUser = gunaDateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (pathImagenProfileUser.Equals(""))
            {
                pathImagenProfileUser = "imageDefaultProfile.png";
            }
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            Nuevos_usuarios newUsers = new Nuevos_usuarios(nickNameUser, nameRealUser, passwordUser, pathImagenProfileUser, dateOfBirthUser);


            xml_acciones.Añadir_usuario(FileName, nickNameUser, nameRealUser, passwordUser, pathImagenProfileUser, dateOfBirthUser);
            
            MessageBox.Show("Bienvenido: " + nickNameUser);
            instagramHome fHome = new instagramHome();
            this.Hide();
            fHome.Show();
        }

        private void txtNameUser_Validating(object sender, CancelEventArgs e)
        {
            if(txtNameUser.Text.Equals("Nombre completo") || string.IsNullOrEmpty(txtNameUser.Text))
            {
                e.Cancel = true;
                txtNameUser.Focus();
                errorProvider.SetError(txtNameUser, "Ingrese Nombre completo");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNameUser, null);
            }
        }

        private void txtNickNameUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtNickNameUser.Text.Equals("Nombre de usuario") || string.IsNullOrEmpty(txtNickNameUser.Text))
            {
                e.Cancel = true;
                txtNameUser.Focus();
                errorProvider.SetError(txtNickNameUser, "Ingrese Nombre de usuario");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNickNameUser, null);
            }
        }

        private void txtPasswordUser_Validating(object sender, CancelEventArgs e)
        {
            if(txtPasswordUser.Text.Equals("Contraseña")|| string.IsNullOrEmpty(txtPasswordUser.Text))
            {
                e.Cancel = true;
                txtPasswordUser.Focus();
                errorProvider.SetError(txtPasswordUser, "Ingrese contraseña");
            }
            else
            {
                e.Cancel = false;
                btnRegistrarCuenta.Enabled = true;
                errorProvider.SetError(txtPasswordUser, null);
            }
        }
    }
}
