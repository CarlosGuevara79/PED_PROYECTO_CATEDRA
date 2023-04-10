using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954.Servicios
{
    class SessionService
    {
        public Task<usuario> LoginAsync(String user, String contrasenia)
        {
            return Task.Run(() =>
            {
                using (ProyectoPEDEntities db = new ProyectoPEDEntities())
                {
                    try
                    {
                        usuario p = (from usuarios in db.usuario
                                     where usuarios.email.Equals(user) && usuarios.contrasenia.Equals(contrasenia)
                                     select usuarios).FirstOrDefault();
                        return p;
                    }
                    catch (Exception e)
                    {
                        usuario p = new usuario();
                        Console.WriteLine("Ocurrio un error en -> {}",e);
                        p.nombres = "Exception";
                        return p;
                    }
                }
            });
        }




    }
}
