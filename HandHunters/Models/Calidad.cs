namespace HandHunters.Models
{
    public class Calidad
    {
        public int Id { get; set; }
        public string NombreCalidad { get; set; }

        public ICollection<Carta> Cartas { get; set; }
    }
}
