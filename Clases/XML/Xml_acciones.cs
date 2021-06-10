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
        
        public void crearXml(string ruta, string nodoRaiz)
        {
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);


            XmlNode element1 = doc.CreateElement(nodoRaiz);
            doc.AppendChild(element1);
            doc.Save(ruta);
        }

        public void Añadir_usuario (string ruta, string nickNameUser, string nameRealUser, string passwordUseSr, string pathImagenProfileUser, string dateOfBirthUser)
        {
            doc.Load(ruta);

            XmlNode Usuario = Crear_usuario(nickNameUser, nameRealUser, passwordUseSr, pathImagenProfileUser, dateOfBirthUser);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(Usuario, nodoRaiz.LastChild);

            doc.Save(ruta);
        }

        private XmlNode Crear_usuario(string nickNameUser, string nameRealUser, string passwordUseSr, string pathImagenProfileUser, string dateOfBirthUser)
        {
 
            XmlNode Usuario = doc.CreateElement("Usuario");
 
 
            XmlElement USERNAME = doc.CreateElement("USERNAME");
            USERNAME.InnerText = nickNameUser;
            Usuario.AppendChild(USERNAME);
 
 
            XmlElement FULLNAME = doc.CreateElement("FULLNAME");
            FULLNAME.InnerText = nameRealUser;
            Usuario.AppendChild(FULLNAME);
 
 
            XmlElement PASSWORD = doc.CreateElement("PASSWORD");
            PASSWORD.InnerText = passwordUseSr;
            Usuario.AppendChild(PASSWORD);

            XmlElement PROFILEIMAGE = doc.CreateElement("PROFILEIMAGE");
            PROFILEIMAGE.InnerText = pathImagenProfileUser;
            Usuario.AppendChild(PROFILEIMAGE);

            XmlElement BIRTHDATE = doc.CreateElement("BIRTHDATE");
            BIRTHDATE.InnerText = dateOfBirthUser;
            Usuario.AppendChild(BIRTHDATE);

            return Usuario;
        }

        public void UpdateXml(string ruta, string User, string nameRealUser, string passwordUseSr, string pathImagenProfileUser, string dateOfBirthUser)
        {
            doc.Load(ruta);

            XmlElement Usuario = doc.DocumentElement;

            XmlNodeList listaEmpleados = doc.SelectNodes("Usuarios/Usuario");

            XmlNode nuevo_usuario = Crear_usuario(User, nameRealUser, passwordUseSr, pathImagenProfileUser, dateOfBirthUser);

            foreach (XmlNode item in listaEmpleados)
            {

                if (item.FirstChild.InnerText == User)
                {
                    XmlNode nodoOld = item;
                   Usuario.ReplaceChild(nuevo_usuario, nodoOld);
                }
            }

            doc.Save(ruta);
        }

        public void Añadir_post(string ruta, string nickNameUser, string pathImagenPost, string dataPost, string datePost)
        {
            doc.Load(ruta);

            XmlNode Usuario = Crear_post(nickNameUser, pathImagenPost, dataPost, datePost);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertBefore(Usuario, nodoRaiz.FirstChild);

            doc.Save(ruta);
        }

        private XmlNode Crear_post(string nickNameUser, string pathImagenPost, string dataPost, string datePost)
        {
            XmlNode Usuario = doc.CreateElement("Post");

            XmlElement USERNAME = doc.CreateElement("USERNAME");
            USERNAME.InnerText = nickNameUser;
            Usuario.AppendChild(USERNAME);

            XmlElement IMAGEPOST = doc.CreateElement("IMAGEPOST");
            IMAGEPOST.InnerText = pathImagenPost;
            Usuario.AppendChild(IMAGEPOST);

            XmlElement DATAPOST = doc.CreateElement("DATAPOST");
            DATAPOST.InnerText = dataPost;
            Usuario.AppendChild(DATAPOST);

            XmlElement DATEPOST = doc.CreateElement("DATEPOST");
            DATEPOST.InnerText = datePost;
            Usuario.AppendChild(DATEPOST);

            return Usuario;
        }
    }
}
