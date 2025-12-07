using System;

namespace ConsoleApp4.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public int Note { get; set; }
        public string Commentaires { get; set; }
        public DateTime DateEvaluation { get; set; } = DateTime.Now;

        // Relations
        public Etudiant Etudiant { get; set; }
        public Entreprise Entreprise { get; set; }

        public void SaisirEvaluation(int note, string commentaire)
        {
            Note = note;
            Commentaires = commentaire;
            DateEvaluation = DateTime.Now;

            Console.WriteLine($"Évaluation saisie pour {Etudiant?.Prenom} {Etudiant?.Nom}");
            Console.WriteLine($"Note: {note}/20 - Commentaire: {commentaire}");
        }

        public void ConsulterEvaluation()
        {
            Console.WriteLine($"=== Évaluation #{Id} ===");
            Console.WriteLine($"Étudiant: {Etudiant?.Prenom} {Etudiant?.Nom}");
            Console.WriteLine($"Entreprise: {Entreprise?.Nom}");
            Console.WriteLine($"Date: {DateEvaluation:dd/MM/yyyy}");
            Console.WriteLine($"Note: {Note}/20");
            Console.WriteLine($"Commentaire: {Commentaires}");
        }

        public bool EstPositive()
        {
            return Note >= 10;
        }
    }
}