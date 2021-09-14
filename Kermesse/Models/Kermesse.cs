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
    
    public partial class Kermesse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kermesse()
        {
            this.ArqueoCajas = new HashSet<ArqueoCaja>();
            this.Gastos = new HashSet<Gasto>();
            this.IngresoComunidads = new HashSet<IngresoComunidad>();
            this.ListaPrecios = new HashSet<ListaPrecio>();
        }
    
        public int idKermesse { get; set; }
        public string nombre { get; set; }
        public System.DateTime fInicio { get; set; }
        public System.DateTime fFinal { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public int tblEncargadoidEncargado { get; set; }
        public int usuarioCreacion { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public Nullable<int> usuarioModificacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<int> usuarioEliminacion { get; set; }
        public Nullable<System.DateTime> fechaEliminacion { get; set; }
        public int idParroquia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCaja> ArqueoCajas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gastos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoComunidad> IngresoComunidads { get; set; }
        public virtual Parroquia Parroquia { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaPrecio> ListaPrecios { get; set; }
    }
}
