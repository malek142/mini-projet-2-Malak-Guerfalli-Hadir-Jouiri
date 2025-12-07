using System;

namespace ConsoleApp4.Models
{
    public class Candidature
    {
        public int Id { get; set; }
        public DateTime DateCandidature { get; set; } = DateTime.Now;
        public string Statut { get; set; } = "En attente";
        public string LettreMotivation { get; set; }

        // Relations
        public Etudiant Etudiant { get; set; }
        public OffreStage Offre { get; set; }

        public void Postuler()
        {
            DateCandidature = DateTime.Now;
            Statut = "Envoyée";
            Console.WriteLine($"Candidature envoyée par {Etudiant?.Prenom} {Etudiant?.Nom}");
        }

        public void ModifierStatut(string nouveauStatut)
        {
            Statut = nouveauStatut;
            Console.WriteLine($"Statut de la candidature modifié: {nouveauStatut}");
        }

        public bool EstAcceptee()
        {
            return Statut == "Acceptée";
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"=== Candidature #{Id} ===");
            Console.WriteLine($"Étudiant: {Etudiant?.Prenom} {Etudiant?.Nom}");
            Console.WriteLine($"Offre: {Offre?.Titre}");
            Console.WriteLine($"Date: {DateCandidature:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Statut: {Statut}");
            Console.WriteLine($"Lettre: {LettreMotivation?.Substring(0, Math.Min(50, LettreMotivation.Length))}...");
        }
    }
}