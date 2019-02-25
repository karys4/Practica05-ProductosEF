using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica05Productos.Models
{
    public class Producto
    {

        public int Id { get; set; }
        //Indica por medio de DataAnnotations que Nombre es un campo requerido 
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        //Validación desde servidor,marcar Rango de existencia de producto
        [Range(0,99,ErrorMessage = "La existencia debe de estar en el rango de 0-99")]
        public int Existencia { get; set; }
        [Display(Name = "Producto Descontinuado")]
        public bool Descontinuado { get; set; }
    }
}
