using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instagramforce.Clases.Arbol_AVL;

namespace instagramforce.Clases.Usuarios
{
    class Login_Usuario: Comparador
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }

        public Login_Usuario() { 
        }
        public Login_Usuario(string nickNameUser, string passowordUser)
        {
            this.USERNAME = nickNameUser;
            this.PASSWORD = passowordUser;
        }

        public bool igualQue(object q)
        {
            Login_Usuario Paux = (Login_Usuario)q;
            if (USERNAME.CompareTo(Paux.USERNAME) == 0)
            {              
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool menorQue(object q)
        {
            Login_Usuario Paux = (Login_Usuario)q;
            if (USERNAME.CompareTo(Paux.USERNAME) < 0)
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
            Login_Usuario Paux = (Login_Usuario)q;
            if (USERNAME.CompareTo(Paux.USERNAME) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool mayorQue(object q)
        {
            Login_Usuario Paux = (Login_Usuario)q;
            if (USERNAME.CompareTo(Paux.USERNAME) > 0)
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
            Login_Usuario Paux = (Login_Usuario)q;
            if (USERNAME.CompareTo(Paux.USERNAME) >= 0)
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
