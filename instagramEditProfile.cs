using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class instagramEditProfile : Form
    {
        string nickNameUser = "";
        string nameRealUser = "";
        string passwordUser = "";
        string dateOfBirthUser = "";
        string pathImagenProfileUser = "";
        public string Username;
        Xml_acciones xml_acciones = new Xml_acciones();

        public instagramEditProfile()
        {
            InitializeComponent();
            txtNicknameUser.Text = Username;
            txtNicknameUser.ForeColor = Color.Gray;
        }

        public void backPage()
        {
            instagramUserProfile feedApp = new instagramUserProfile();
            this.Hide();
            feedApp.Visible = true;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            backPage();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            backPage();
            nickNameUser = Username;
            nameRealUser = txtNameUser.Text;
            passwordUser = txtpasswordUser.Text;
            dateOfBirthUser = gunaDateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (pathImagenProfileUser.Equals(""))
            {
                pathImagenProfileUser = "imageDefaultProfile.png";
            }

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            xml_acciones.UpdateXml(FileName, nickNameUser, nameRealUser, passwordUser, pathImagenProfileUser, dateOfBirthUser);
            MessageBox.Show("Se ha actualizado la información del usuario: " + nickNameUser);
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                photoProfileUser.Image = Image.FromFile(abrir.FileName);
                pathImagenProfileUser = abrir.FileName;
                photoProfileUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void instagramEditProfile_Load(object sender, EventArgs e)
        {
            //Validar para que cargue la foto del usuario
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            photoProfileUser.Image = Image.FromFile(FileName);
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
