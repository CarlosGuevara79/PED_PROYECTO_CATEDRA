//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoCatedra_PED_MR190768_GM172474_CM221954
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public Nullable<int> tipoUsuario { get; set; }
        public string contrasenia { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
    
        public virtual TipoUsuario TipoUsuario1 { get; set; }
    }
}
