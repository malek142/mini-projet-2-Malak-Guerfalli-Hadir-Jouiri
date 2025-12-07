using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models
{
    public class Etudiant : Utilisateur
    {
        public string NumeroEtudiant { get; set; }
        public string Filiere { get; set; }
        public int Annee { get; set; }
        public List<Candidature> Candidatures { get; set; } = new List<Candidature>();
        public Convention Convention { get; set; }

        public bool PostulerOffre(OffreStage offre)
        {
            if (offre == null || offre.Statut != "Publiée")
                return false;

            var candidature = new Candidature
            {
                Etudiant = this,
                Offre = offre,
                DateCandidature = DateTime.Now,
                Statut = "En attente"
            };

            Candidatures.Add(candidature);
            offre.Candidatures.Add(candidature);

            Console.WriteLine($"{Prenom} {Nom} a postulé à l'offre : {offre.Titre}");
            return true;
        }

        public void RemplirConvention()
        {
            if (Convention == null)
            {
                Convention = new Convention
                {
                    Etudiant = this,
                    DateDebut = DateTime.Now.AddDays(7),
                    DateFin = DateTime.Now.AddMonths(6),
                    Statut = "Brouillon"
                };
            }
            Console.WriteLine("Convention remplie par l'étudiant.");
        }

        public void ConsulterSuivi()
        {
            Console.WriteLine($"{Prenom} {Nom} consulte son suivi de stage.");
            Console.WriteLine($"Filière: {Filiere}, Année: {Annee}");
            Console.WriteLine($"Nombre de candidatures: {Candidatures.Count}");
        }
    }
}