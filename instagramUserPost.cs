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


namespace instagramforce
{
    public partial class instagramUserPost : Form
    {
        public string Username;
        string nickNameUser = "";
        string pathImagenPost = "";
        string dataPost = "";
        string datePost = "";
        string pathFinalPostImage = "";
        Xml_acciones xml_Acciones = new Xml_acciones();

        public instagramUserPost()
        {
            InitializeComponent();
            bttPublicar.Enabled = false;
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                photoPost.Image = Image.FromFile(abrir.FileName);
                pathImagenPost = abrir.FileName;
                pathFinalPostImage = pathImagenPost.Substring(pathImagenPost.IndexOf("Resources"));
                if (!pathImagenPost.Equals(""))
                {
                    bttPublicar.Enabled = true;
                }
                photoPost.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            nickNameUser = Username;
            dataPost = txtdataPost.Text;
            DateTime fecha = DateTime.Now;
            datePost = fecha.ToString("yyyy-MM-dd hh:mm:ss");
            instagramHome fHome = new instagramHome();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\FeedData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            if (File.Exists(FileName))
            {
                xml_Acciones.Añadir_post(FileName, nickNameUser, pathFinalPostImage, dataPost, datePost);
                MessageBox.Show("Se a posteado exitosamente " + nickNameUser);
                fHome.Username = Username;
                this.Hide();
                fHome.Show();
            }
            else
            {
                xml_Acciones.crearXml(FileName, "Posts");
                xml_Acciones.Añadir_post(FileName, nickNameUser, pathFinalPostImage, dataPost, datePost);
                MessageBox.Show("Se a posteado exitosamente " + nickNameUser);
                fHome.Username = Username;
                this.Hide();
                fHome.Show();
            }
        }
    }
}
