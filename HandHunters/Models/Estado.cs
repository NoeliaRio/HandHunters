namespace HandHunters.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string NombreEstado { get; set; }

        public ICollection<Carta> Cartas { get; set; }
    }
}
