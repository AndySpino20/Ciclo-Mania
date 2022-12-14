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

    public partial class facturaMantenimientos
    {
        [Display(Name = "ID Factura")]
        [Required(ErrorMessage = "El ID de la factura es un campo obligatorio")]
        public int facturaidM { get; set; }
        [Display(Name = "Identificación")]
        [Required(ErrorMessage = "La identificación es un campo obligatorio")]
        public int clienteId { get; set; }
        [Display(Name = "Detalles Arreglo")]
        [Required(ErrorMessage = "Detalles Arreglo es un campo obligatorio")]
        [StringLength(20, ErrorMessage = "Tamaño máximo de 20 caracteres")]
        public string detallesArreglo { get; set; }
        [Display(Name = "Total")]
        [Required(ErrorMessage = "El total es un campo obligatorio")]
        public double total { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}
