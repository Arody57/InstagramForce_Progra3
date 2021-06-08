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

namespace instagramforce
{
    public partial class instagramEditProfile : Form
    {
        public instagramEditProfile()
        {
            InitializeComponent();
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
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                photoProfileUser.Image = Image.FromFile(abrir.FileName);
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
    }
}
