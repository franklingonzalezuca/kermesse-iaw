//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kermesse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolUsuario
    {
        public int idRolUsuario { get; set; }
        public int tblUsuarioidUsuario { get; set; }
        public int tblRolidRol { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
