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

namespace instagramforce
{
    public partial class instagramUserFollowers : Form
    {
        public int panelFollowersY = 7;
        public int panelFollowersX = 16;
        public int contador = 1;
        public List<string> myPreliminarList = new List<string>();
        public List<(string, string, string, string)> myUsersFeed = new List<(string, string, string, string)>();
        public string userGlobal;
        public instagramUserFollowers()
        {
            InitializeComponent();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            feedApp.Username = userGlobal;
            this.Hide();
            feedApp.Visible = true;
        }

        public void getData()
        {
            string RunningPaths = AppDomain.CurrentDomain.BaseDirectory;
            string FileNames = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPaths, @"..\..\")));
            XmlDocument xmldocs = new XmlDocument();
            xmldocs.Load(FileNames);
            XmlNodeList itemsNodes = xmldocs.SelectNodes("//Usuarios//Usuario");
            foreach (XmlNode ItemNode in itemsNodes)
            {
                string USERNAME = string.Empty, PATHIMAGE = string.Empty, FULLNAME = string.Empty, BIRTHDATE = string.Empty;
                foreach (XmlNode item in ItemNode.SelectSingleNode("USERNAME"))
                {
                    USERNAME = item.InnerText;
                    foreach (XmlNode items in ItemNode.SelectSingleNode("PROFILEIMAGE"))
                    {
                        PATHIMAGE = items.InnerText;
                    }
                    foreach ( var items in myPreliminarList)
                    {
                        if (item.InnerText == items)
                        {
                            myUsersFeed.Add((USERNAME, PATHIMAGE, FULLNAME, BIRTHDATE));
                        }
                    }
                }
            }

            foreach (var items in myUsersFeed)
            {

                    addNewPanelFollowers(items.Item1, items.Item2);
                
            }
        }
        public void addNewPanelFollowers(string nameFollower, string pathImage)
        {
            if (nameFollower != userGlobal)
            {
                //Creacion de paneles para Seguidores
                Panel panelFollowers = new Panel();
                Guna.UI.WinForms.GunaCirclePictureBox pictureBoxFollowers = new Guna.UI.WinForms.GunaCirclePictureBox();

                Label nameFollowers = new Label();
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FilePhoto = string.Format("{0}" + pathImage + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                //creacion del panel
                panelFollowers.Size = new Size(251, 96);
                panelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                //Creacion del pictureBox
                pictureBoxFollowers.Location = new Point(14, 12);
                pictureBoxFollowers.Image = Image.FromFile(FilePhoto);
                pictureBoxFollowers.Size = new Size(70, 63);
                panelFollowers.Controls.Add(pictureBoxFollowers);

                //Creacion de la label
                nameFollowers.Location = new Point(89, 32);
                nameFollowers.Text = nameFollower;
                nameFollowers.Cursor = Cursors.Hand;
                nameFollowers.Click += new EventHandler(lblEvent_Click);
                nameFollowers.Size = new Size(68, 15);
                panelFollowers.Controls.Add(nameFollowers);

                panelFollowers.Location = new Point(panelFollowersX, panelFollowersY);
                panelFeed.Controls.Add(panelFollowers);

                panelFollowersY = (86 * contador) + 7;
                contador += 1;
            }
        }
        public void lblEvent_Click(object sender, EventArgs e)
        {
            Label lblUsers = (Label)sender;
            string dato = this.panelFeed.Controls.Find("Label", true).ToString();
            instagramProfileFollowers feedApp = new instagramProfileFollowers();
            feedApp.Username = userGlobal;
            feedApp.perfilUser = lblUsers.Text; 
            this.Hide();
            feedApp.Show();
        }

        private void instagramUserFollowers_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
