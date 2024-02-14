namespace MielMassage.Models
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public string gsm { get; set; }
        public string? adresse { get; set; }
        public string? parrain { get; set; }
        public int nb_filleuls { get; set; }
        public int filleuls_used { get; set; }
        public string? statut { get; set; }
        public string? preferences { get; set; }

    }
}
