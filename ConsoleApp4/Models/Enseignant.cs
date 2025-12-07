using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models
{
    public class Enseignant : Utilisateur
    {
        public string Matricule { get; set; }
        public string Departement { get; set; }
        public List<Etudiant> EtudiantsSuivis { get; set; } = new List<Etudiant>();

        public void EvaluerRapports()
        {
            Console.WriteLine($"{Prenom} {Nom} évalue les rapports de stage.");

            foreach (var etudiant in EtudiantsSuivis)
            {
                Console.WriteLine($"- Rapport de {etudiant.Prenom} {etudiant.Nom}");
            }
        }

        public void VisiterEntreprises()
        {
            Console.WriteLine($"{Prenom} {Nom} visite les entreprises partenaires.");
        }

        public void AjouterEtudiant(Etudiant etudiant)
        {
            if (etudiant != null && !EtudiantsSuivis.Contains(etudiant))
            {
                EtudiantsSuivis.Add(etudiant);
                Console.WriteLine($"{etudiant.Prenom} {etudiant.Nom} ajouté à la liste des suivis.");
            }
        }
    }
}
