using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
   
    public class NLogin
    {
        
        public void informacionLogin(String usuario,String conexionBD)
        {
            DLogin.usuario = usuario;
            DLogin.conexionBD = conexionBD;
            DLogin.sacaTecnico(usuario);
            //return login;
        }


    }
}
