//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUBibliotecaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
        }

        [ScaffoldColumn(false)]
        public int idvideo { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Necesitamos el título requerido "), MaxLength(55)]
        [Display(Name = "Título del Video")]
        public string titulo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd'/'MM'/'yyyy}")]
        [Display(Name = "Fecha de Publicación")]
        public Nullable<System.DateTime> fecha_publicacion { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Se requiere el formato"), MaxLength(55)]
        [Display(Name = "Formato")]
        public string formato { get; set; }
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "¿Cuál es el tiempo de duración?"), MaxLength(55)]
        [Display(Name = "Duración")]
        public string duracion { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Se requiere de la categoría"), MaxLength(55)]
        [Display(Name = "Categoría")]
        public string categoria { get; set; }
    }
}
