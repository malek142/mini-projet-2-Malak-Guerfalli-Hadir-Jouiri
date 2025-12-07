using System;

namespace ConsoleApp4.Models
{
    public class Convention
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Missions { get; set; }
        public string Statut { get; set; } = "Brouillon";

        // Relations
        public Etudiant Etudiant { get; set; }
        public Entreprise Entreprise { get; set; }

        public void Creer()
        {
            Statut = "Brouillon";
            Console.WriteLine($"Convention créée pour {Etudiant?.Prenom} {Etudiant?.Nom}");
        }

        public void Valider()
        {
            Statut = "Validée";
            Console.WriteLine($"Convention #{Id} validée.");
        }

        public void Modifier(string nouvellesMissions)
        {
            Missions = nouvellesMissions;
            Console.WriteLine($"Missions de la convention #{Id} modifiées.");
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"=== Convention #{Id} ===");
            Console.WriteLine($"Étudiant: {Etudiant?.Prenom} {Etudiant?.Nom}");
            Console.WriteLine($"Entreprise: {Entreprise?.Nom}");
            Console.WriteLine($"Période: {DateDebut:dd/MM/yyyy} au {DateFin:dd/MM/yyyy}");
            Console.WriteLine($"Statut: {Statut}");
            Console.WriteLine($"Missions: {Missions?.Substring(0, Math.Min(100, Missions.Length))}...");
        }
    }
}