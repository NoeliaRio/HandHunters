namespace HandHunters.Models
{
    public class Franquicia
    {
        public int Id { get; set; }
        public string NombreFranquicia { get; set; }


        public ICollection<Carta> Cartas { get; set; }
    }
}
