//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CicloMania.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Usuarios
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Usuarios()
        //{
        //    this.UserRolesMapping = new HashSet<UserRolesMapping>();
        //}

        public int Id { get; set; }
        [Display(Name = "Nombre de Usuario")]
        [Required]
        public string Nombre_de_usuario { get; set; }
        [Display(Name = "Contraseña")]
        [Required]
        public string C_Contraseña_ { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRolesMapping> UserRolesMapping { get; set; }


    }
}
