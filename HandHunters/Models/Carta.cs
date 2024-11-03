using Microsoft.AspNetCore.Identity;

namespace HandHunters.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public string NombreCarta { get; set; }
        public string? Descripcion { get; set; }
        public double Costo { get; set; }

        // Foreign keys
        public int IdCalidad { get; set; }
        public Calidad Calidad { get; set; }

        public int IdEstado { get; set; }
        public Estado Estado { get; set; }

        public int IdIdioma { get; set; }
        public Idioma Idioma { get; set; }

        public string Foto { get; set; } 

        public int IdFranquicia { get; set; }
        public Franquicia Franquicia { get; set; }

        // Relación con el usuario de Identity
        public string IdUser { get; set; }
        public IdentityUser User { get; set; }
    }
}
