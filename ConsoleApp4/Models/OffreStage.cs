using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models
{
    public class OffreStage
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string CompetencesRequises { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double Remuneration { get; set; }
        public string Statut { get; set; } = "Brouillon";

        // Relations
        public Entreprise Entreprise { get; set; }
        public List<Candidature> Candidatures { get; set; } = new List<Candidature>();

        public void Publier()
        {
            if (Statut == "Brouillon")
            {
                Statut = "Publiée";
                Console.WriteLine($"Offre '{Titre}' publiée.");
            }
        }

        public void Archiver()
        {
            Statut = "Archivée";
            Console.WriteLine($"Offre '{Titre}' archivée.");
        }

        public bool EstValide()
        {
            return Statut == "Publiée" && DateFin > DateTime.Now;
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"=== {Titre} ===");
            Console.WriteLine($"Entreprise: {Entreprise?.Nom}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Compétences: {CompetencesRequises}");
            Console.WriteLine($"Période: {DateDebut:dd/MM/yyyy} au {DateFin:dd/MM/yyyy}");
            Console.WriteLine($"Rémunération: {Remuneration}€");
            Console.WriteLine($"Statut: {Statut}");
            Console.WriteLine($"Candidatures: {Candidatures.Count}");
        }
    }
}