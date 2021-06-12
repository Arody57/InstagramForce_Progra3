using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace instagramforce.Clases.Usuarios
{
    class Busqueda_Usuario
    {

        public List<string> resultList;
        public string Username { get; set; }
        public List<string> LoadingTxt(string value)
        {
            List<string> filesData = new List<string>();
            var myregex = new Regex(value, RegexOptions.IgnoreCase);

            //Cargar userData.xml
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(FileName);
            XmlNodeList itemsNodes = xmldoc.SelectNodes("//Usuarios//Usuario");
            string USERNAME = string.Empty;

            //Cargar Cargar userData.xml
            string RunningPathFF = AppDomain.CurrentDomain.BaseDirectory;
            string FileNameFF = string.Format("{0}Resources\\FollowerFollowingData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            XmlDocument doc = new XmlDocument();
            doc.Load(FileNameFF);
            XmlNode Seguidores = doc.DocumentElement;
            XmlNodeList listaSeguidores = doc.SelectNodes("FOLLOWINGFOLLOWERDATA/USER");


            foreach (XmlNode ItemNode in itemsNodes)
            {
                foreach (XmlNode item in ItemNode.SelectSingleNode("USERNAME"))
                {
                    USERNAME = item.InnerText;
                }
                if (USERNAME == Username)
                {
                    continue;
                }
                else
                {
                    foreach (XmlNode itemSeguidor in listaSeguidores)
                    {
                        if (itemSeguidor.SelectSingleNode("FOLLOWER").InnerText == Username && itemSeguidor.SelectSingleNode("FOLLOWING").InnerText == USERNAME)
                        {
                            break;
                        }
                        else
                        {
                            filesData.Add(USERNAME);
                            break;
                        }
                    }
                }
            }
            return resultList = filesData.Where(i => myregex.IsMatch(i)).ToList();
        }
    }
}
