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
using System.Xml;
using instagramforce.Clases.Usuarios;

namespace instagramforce
{
    public partial class instagramSearch : Form
    {
        public int panelFollowingsY = 7;
        public int panelFollowingsX = 16;
        public int countFollowings = 0;
        public int contador = 0;

        public string Username;
        public instagramSearch()
        {
            InitializeComponent();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            this.Hide();
            feedApp.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            limpiar_panel();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Busqueda_Usuario mandarTexto = new Busqueda_Usuario();
                string value = txtSearch.Text;
                List<string> listCoincidencias = mandarTexto.LoadingTxt(value);
                foreach (var UserCoincidencias in listCoincidencias)
                {
                    string PROFILEIMAGE = pathimage(UserCoincidencias);
                    addNewPanelSearch(UserCoincidencias, PROFILEIMAGE);
                }
            }
         }

        private void limpiar_panel() 
        {
            panelFeed.Controls.Clear();
            countFollowings = 0;
            panelFollowingsY = 7;
            panelFollowingsX = 16;
            panelFeed.Refresh();
        }

        private string pathimage(string USER)
        {

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            string PROFILEIMAGEPAHT = "";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(FileName);
            string PROFILEIMAGE = string.Empty;
            XmlNodeList ItemNodes = xmldoc.SelectNodes("Usuarios/Usuario");
            foreach (XmlNode itemNode in ItemNodes)
            {
                if (itemNode.FirstChild.InnerText == USER)
                {
                    foreach (XmlNode itemPaht in itemNode.SelectSingleNode("PROFILEIMAGE"))
                    {
                        PROFILEIMAGE = itemPaht.InnerText;
                        if (PROFILEIMAGE.Contains("Resources"))
                        {
                            PROFILEIMAGEPAHT = string.Format(Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                            PROFILEIMAGEPAHT += PROFILEIMAGE;
                        }
                        else
                        {
                            PROFILEIMAGEPAHT = PROFILEIMAGE; 
                        }
                    }
                }
            }
            return PROFILEIMAGEPAHT;
        }

        public void Label_Click(object sender, EventArgs e)
        {
            Label lblUsers = (Label)sender;
            string dato = this.panelFeed.Controls.Find("Label", true).ToString();
            instagramProfileFollowers feedApp = new instagramProfileFollowers();
            feedApp.Username = Username;
            feedApp.perfilUser = lblUsers.Text; ;
            this.Hide();
            feedApp.Show();
        }

        public void addNewPanelSearch(string USERNAME, string pathimage)
        {
            Panel panelSearch = new Panel();
            Guna.UI.WinForms.GunaCirclePictureBox pictureBoxFollowers = new Guna.UI.WinForms.GunaCirclePictureBox();


            Label nameFollowers = new Label();
            //LinkLabel nameFollowers = new LinkLabel();
            
            //creacion del panel
            panelSearch.Size = new Size(435, 80);
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Creacion del pictureBox
            pictureBoxFollowers.Location = new Point(14, 8);
            pictureBoxFollowers.BackColor = Color.Gray;
            pictureBoxFollowers.Size = new Size(70, 63);
            pictureBoxFollowers.Image = Image.FromFile(pathimage);
            panelSearch.Controls.Add(pictureBoxFollowers);

            //Creacion de la label
            nameFollowers.Location = new Point(89, 32);
            nameFollowers.Text = USERNAME;
            nameFollowers.Cursor = Cursors.Hand;
            nameFollowers.Click += new EventHandler(Label_Click);
            nameFollowers.Size = new Size(435, 15);
            panelSearch.Controls.Add(nameFollowers);

            panelSearch.Location = new Point(panelFollowingsX, panelFollowingsY);
            panelFeed.Controls.Add(panelSearch);

            panelFollowingsY = (86 * countFollowings) + 7;
            countFollowings += 1;
        }

    }
}
