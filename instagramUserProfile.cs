using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instagramforce.Clases.Acciones;
using System.Windows.Forms;
using System.Xml;

namespace instagramforce
{
    public partial class instagramUserProfile : Form
    {
        public string Username;
        public string fullNameUser;
        public string photoUserName;
        public string userBirthDate;
        public string followersUser;
        public string followingUser;
        public int postUser;
        public int y = 72;
        public int x = 45;
        public int count = 1;
        public List<(string, string, string, string)> myPostListUsers = new List<(string, string, string, string)>();
        public instagramUserProfile()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                gunaPanel1.VerticalScroll.Value = e.NewValue;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            feedApp.Username = Username;
            feedApp.fullNameUser = fullNameUser;
            feedApp.photoUserName = photoUserName;
            feedApp.userBirthDate = userBirthDate;
            feedApp.followersUser = followersUser;
            feedApp.followingUser = followingUser;
            feedApp.countPostUser = postUser;
            this.Hide();
            feedApp.Visible = true;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            instagramEditProfile feedApp = new instagramEditProfile();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            if (string.IsNullOrEmpty(photoUserName))
            {
            string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            imageUser.Image = Image.FromFile(FileName);
            }
            else
            {
                string FileName = string.Format("{0}" + photoUserName + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                imageUser.Image = Image.FromFile(FileName);
            }
        }

        private void instagramUserProfile_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Username;
            lblSeguidores.Text = followersUser;
            //lblSeguidos.Text = followingUser;
            lblPost.Text = Convert.ToString(postUser);
            readXmlPostUser();

        }

        public void readXmlPostUser()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\FeedData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            if (File.Exists(FileName))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//Posts//Post");
                XmlNode user;

                for (int i = 0; i < itemsNodes.Count; i++)
                    {
                        user = itemsNodes.Item(i);
                        string userNames = user.SelectSingleNode("USERNAME").InnerText;
                    if (userNames == Username)
                    {
                            string imagePost = user.SelectSingleNode("IMAGEPOST").InnerText;
                            string dataPost = user.SelectSingleNode("DATAPOST").InnerText;
                            string datePost = user.SelectSingleNode("DATEPOST").InnerText;

                            drawingGeneralPanel panels = new drawingGeneralPanel();
                        myPostListUsers.Add((userNames, imagePost, dataPost, datePost));
                        Panel panelComponentes = panels.addNewPanelFeed(userNames, imagePost, dataPost, datePost, imagePost, x, y);
                            panelFeedUser.Controls.Add(panelComponentes);
                            y = (424 * count) + 72;
                            count += 1;
                    }
                }
            } 
        }
    }
}
