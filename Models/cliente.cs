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

    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.facturaMantenimientos = new HashSet<facturaMantenimientos>();
            this.factura = new HashSet<factura>();
        }

        [Display(Name = "Identificación")]
        [Required(ErrorMessage = "La identificación es un campo obligatorio")]
        public int clienteId { get; set; }
        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "La cédula es un campo obligatorio")]
        public string cedula { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string nombreCliente { get; set; }
        [Display(Name = "Apellido 1")]
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string apellido1 { get; set; }
        [Display(Name = "Apellido 2")]
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string apellido2 { get; set; }
        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es un campo obligatorio")]
        public string telefono { get; set; }
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "La dirección es un campo obligatorio")]
        public string direccion { get; set; }
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El Correo es un campo obligatorio")]
        [EmailAddress]
        public string correo { get; set; }
        [Display(Name = "Género")]
        [Required(ErrorMessage = "El Género es un campo obligatorio")]
        [StringLength(1, ErrorMessage = "Tamaño máximo de 1 caracter")]
        public string genero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturaMantenimientos> facturaMantenimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> factura { get; set; }
    }
}
