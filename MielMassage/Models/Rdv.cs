namespace MielMassage.Models
{
    public class Rdv
    {
        public int Id { get; set; }
        public Utilisateur utilisateur { get; set; }
        public DateOnly jour { get; set; }
        public TimeOnly h_debut { get; set; }
        public int duree { get; set; }
        public TimeOnly h_fin { get; set; }
        public int tarif { get; set; }
        public string adresse { get; set; }

    }
}
