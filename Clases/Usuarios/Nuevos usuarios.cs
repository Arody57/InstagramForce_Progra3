using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instagramforce.Clases.Arbol_AVL;

namespace instagramforce.Clases.Usuarios
{
    class Nuevos_usuarios:Comparador
    {
        public string USERNAME { get; set; }
        public string REALNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PERFILEIMAGE { get; set; }
        public string BIRTHDATE { get; set; }

        public Nuevos_usuarios()
        {
        }
        public Nuevos_usuarios(string nickNameUser, string nameRealUser, string passwordUseSr, string pathImagenProfileUser, string dateOfBirthUser)
        {
            this.USERNAME = nickNameUser;
            this.REALNAME = nameRealUser;
            this.PASSWORD = passwordUseSr;
            this.PERFILEIMAGE = pathImagenProfileUser;
            this.BIRTHDATE = dateOfBirthUser;
        }

        public bool igualQue(object q)
        {
            Nuevos_usuarios Paux = (Nuevos_usuarios)q;
            if (USERNAME.CompareTo(Paux.USERNAME) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            Nuevos_usuarios Paux = (Nuevos_usuarios)q;
            if (USERNAME.CompareTo(Paux.USERNAME) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool menorQue(object q)
        {
            Nuevos_usuarios Paux = (Nuevos_usuarios)q;
            if (USERNAME.CompareTo(Paux.USERNAME) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
