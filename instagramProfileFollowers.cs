using instagramforce.Clases.Acciones;
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
    public partial class instagramProfileFollowers : Form
    {
        public string Username;
        public string fullNameUser;
        public string photoUserName;
        public string userBirthDate;
        public string followersUser;
        public string followingUser;
        public string postUser;


        public string perfilUser;
        public int y = 72;
        public int x = 45;
        public int count = 1;
        public List<(string, string, string, string)> myPostListUsers = new List<(string, string, string, string)>();
        public instagramProfileFollowers()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void instagramProfileFollowers_Load(object sender, EventArgs e)
        {
            lblUserName.Text = perfilUser;

            //readXmlPostUser();
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
                    if (userNames == perfilUser)
                    {
                        string imagePost = user.SelectSingleNode("IMAGEPOST").InnerText;
                        string dataPost = user.SelectSingleNode("DATAPOST").InnerText;
                        string datePost = user.SelectSingleNode("DATEPOST").InnerText;

                        drawingGeneralPanel panels = new drawingGeneralPanel();
                        myPostListUsers.Add((userNames, imagePost, dataPost, datePost));
                        Panel panelComponentes = panels.addNewPanelFeed(userNames, imagePost, dataPost, datePost, imagePost, x, y);
                        panelFollower.Controls.Add(panelComponentes);
                        y = (424 * count) + 72;
                        count += 1;
                    }
                }
            }
            if (string.IsNullOrEmpty(myPostListUsers[0].Item2))
            {
                string FilePath = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                imageUser.Image = Image.FromFile(FilePath);
            }
            else
            {
                string FileNames = string.Format("{0}" + myPostListUsers[0].Item2 + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                imageUser.Image = Image.FromFile(FileNames);
            }
        }
    }
}
