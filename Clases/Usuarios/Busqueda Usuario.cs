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


            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(FileName);
            XmlNodeList itemsNodes = xmldoc.SelectNodes("//Usuarios//Usuario");
            string USERNAME = string.Empty, PROFILEIMAGE = string.Empty;

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
                    filesData.Add(USERNAME);
                }
            }

            return resultList = filesData.Where(i => myregex.IsMatch(i)).ToList();
        }
    }
}
