using System.ComponentModel.DataAnnotations;

namespace CrudUsuarios.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string Correo { get; set; } = string.Empty;
        [Range(0, 125)]
        public int Edad { get; set; } // 👈 Nuevo campo
        [StringLength(20)]
        public string Telefono { get; set; } = string.Empty;
    }
}
