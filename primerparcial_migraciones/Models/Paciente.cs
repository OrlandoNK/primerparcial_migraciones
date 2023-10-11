using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace primerparcial_migraciones.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set;}
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }

    }
}
