namespace HandHunters.Models
{
    public class Idioma
    {
        public int Id { get; set; }
        public string NombreIdioma { get; set; }

        public ICollection<Carta> Cartas { get; set; }
    }
}
