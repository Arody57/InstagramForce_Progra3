using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace instagramforce.Clases.XML
{
    class Xml_acciones
    {
        XmlDocument doc = new XmlDocument();
        string rutaXml;

        public void crearXml(string ruta, string nodoRaiz)
        {

            this.rutaXml = ruta;
            //doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);


            XmlNode element1 = doc.CreateElement(nodoRaiz);
            doc.AppendChild(element1);
            doc.Save(ruta);
        }

        public void Añadir_usuario (string ruta, string nickNameUser, string nameRealUser, string passwordUseSr, string dateOfBirthUser, string pathImagenProfileUser)
        {
            //doc = new XmlDocument();
            doc.Load(ruta);

            XmlNode Usuario = Crear_usuario(nickNameUser, nameRealUser, passwordUseSr, dateOfBirthUser, pathImagenProfileUser);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(Usuario, nodoRaiz.LastChild);

            doc.Save(ruta);
        }

        private XmlNode Crear_usuario(string nickNameUser, string nameRealUser, string passwordUseSr, string dateOfBirthUser, string pathImagenProfileUser)
        {
 
            XmlNode Usuario = doc.CreateElement("Usuarios");
 
 
            XmlElement NickName = doc.CreateElement("NickName");
            NickName.InnerText = nickNameUser;
            Usuario.AppendChild(NickName);
 
 
            XmlElement nameUser = doc.CreateElement("NameUser");
            nameUser.InnerText = nameRealUser;
            Usuario.AppendChild(nameUser);
 
 
            XmlElement password = doc.CreateElement("Password");
            password.InnerText = passwordUseSr;
            Usuario.AppendChild(password);
 
 
            XmlElement dateOfBirth = doc.CreateElement("DateOfBirth");
            dateOfBirth.InnerText = dateOfBirthUser;
            Usuario.AppendChild(dateOfBirth);

            XmlElement pathImagenProfile = doc.CreateElement("PathImagenProfile");
            pathImagenProfile.InnerText = pathImagenProfileUser;
            Usuario.AppendChild(pathImagenProfile);

            return Usuario;
        }
    }
}
