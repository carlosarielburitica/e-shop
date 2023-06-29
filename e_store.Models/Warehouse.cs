using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_store.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="Nombre máximo de 60 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descripción Requerida")]
        [MaxLength(100, ErrorMessage = "Nombre máximo de 100 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Estado es requerido")]
        public bool Status { get; set; }
    }
}
