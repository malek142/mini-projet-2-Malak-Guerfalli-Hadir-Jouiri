using ConsoleApp4.Models;
using Microsoft.VisualBasic;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SYSTÈME DE GESTION DES STAGES ===\n");

            // 1. Création d'une entreprise
            var entreprise = new Entreprise
            {
                Id = 1,
                Nom = "TechCorp France",
                Email = "contact@techcorp.fr",
                MotDePasse = "tech123",
                Siret = "12345678900001",
                Adresse = "Paris 75015",
                Secteur = "Informatique"
            };

            // 2. Création d'un étudiant
            var etudiant = new Etudiant
            {
                Id = 2,
                Nom = "Dupont",
                Prenom = "Jean",
                Email = "jean.dupont@edu.fr",
                MotDePasse = "etu123",
                NumeroEtudiant = "ETU2024001",
                Filiere = "Informatique",
                Annee = 3
            };

            // 3. L'entreprise publie une offre
            var offre = entreprise.PublierOffre(
                "Développeur .NET Junior",
                "Développement d'applications web en C#",
                "C#, ASP.NET, SQL, Git",
                new DateTime(2024, 4, 1),
                new DateTime(2024, 9, 30),
                1200.50
            );

            // 4. L'étudiant postule
            bool postulationReussie = etudiant.PostulerOffre(offre);

            if (postulationReussie)
            {
                Console.WriteLine("\n✅ Postulation réussie !");
            }

            // 5. Création d'une convention
            var convention = new Convention
            {
                Id = 1,
                Etudiant = etudiant,
                Entreprise = entreprise,
                DateDebut = new DateTime(2024, 4, 1),
                DateFin = new DateTime(2024, 9, 30),
                Missions = "Développement front-end et back-end, tests unitaires, documentation"
            };

            // 6. Validation de la convention
            entreprise.ValiderConvention(convention);
            convention.Valider();

            // 7. Création d'une évaluation
            var evaluation = new Evaluation
            {
                Id = 1,
                Etudiant = etudiant,
                Entreprise = entreprise,
                Note = 16,
                Commentaires = "Excellent travail, très autonome"
            };

            // 8. Affichage des informations
            Console.WriteLine("\n=== RÉSUMÉ ===");
            Console.WriteLine($"Entreprise: {entreprise.Nom}");
            Console.WriteLine($"Étudiant: {etudiant.Prenom} {etudiant.Nom}");
            Console.WriteLine($"Offre: {offre.Titre}");
            Console.WriteLine($"Convention statut: {convention.Statut}");
            Console.WriteLine($"Évaluation: {evaluation.Note}/20");

            Console.WriteLine("\n=== FIN DU PROGRAMME ===");
            Console.ReadKey();
        }
    }
}
