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

    public partial class empleado
    {
        [Display(Name = "Identificación")]
        [Required(ErrorMessage = "La identificación es un campo obligatorio")]
        public int idEmpleado { get; set; }
        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "La cédula es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string cedula { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string nombre { get; set; }
        [Display(Name = "Apellido 1")]
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string apellido1 { get; set; }
        [Display(Name = "Apellido 2")]
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string apellido2 { get; set; }
        [Display(Name = "Puesto")]
        [Required(ErrorMessage = "El puesto es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string puesto { get; set; }
        [Display(Name = "Fecha Ingreso")]
        [Required(ErrorMessage = "La fecha ingreso es un campo obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime fechaIngreso { get; set; }
        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es un campo obligatorio")]
        public string telefono { get; set; }
        [Display(Name = "Género")]
        [Required(ErrorMessage = "El Género es un campo obligatorio")]
        [StringLength(1, ErrorMessage = "Tamaño máximo de 1 caracter")]
        public string genero { get; set; }
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El Correo es un campo obligatorio")]
        [EmailAddress]
        public string correo { get; set; }
        [Display(Name = "Numero de Cuenta")]
        [Required(ErrorMessage = "El Numero de Cuenta es un campo obligatorio")]
        [Range(1, 9999, ErrorMessage = "El Numero de Cuenta no debe sobrepasar 5 dígitos")]
        public string NumCuenta { get; set; }
        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "El sueldo es un campo obligatorio")]
        public decimal sueldo { get; set; }
    }
}
