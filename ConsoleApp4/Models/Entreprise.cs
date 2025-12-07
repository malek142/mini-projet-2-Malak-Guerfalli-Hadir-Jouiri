using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models
{
    public class Entreprise : Utilisateur
    {
        public string Siret { get; set; }
        public string Adresse { get; set; }
        public string Secteur { get; set; }
        public string SiteWeb { get; set; }
        public List<OffreStage> Offres { get; set; } = new List<OffreStage>();

        public OffreStage PublierOffre(string titre, string description, string competences,
                                      DateTime dateDebut, DateTime dateFin, double remuneration)
        {
            var offre = new OffreStage
            {
                Titre = titre,
                Description = description,
                CompetencesRequises = competences,
                DateDebut = dateDebut,
                DateFin = dateFin,
                Remuneration = remuneration,
                Statut = "Publiée",
                Entreprise = this
            };

            Offres.Add(offre);
            Console.WriteLine($"Offre '{titre}' publiée par {Nom}");
            return offre;
        }

        public List<Candidature> ConsulterCandidatures()
        {
            var toutesCandidatures = new List<Candidature>();

            foreach (var offre in Offres)
            {
                toutesCandidatures.AddRange(offre.Candidatures);
            }

            Console.WriteLine($"{Nom} consulte {toutesCandidatures.Count} candidature(s)");
            return toutesCandidatures;
        }

        public bool ValiderConvention(Convention convention)
        {
            if (convention == null) return false;

            convention.Statut = "Validée par l'entreprise";
            Console.WriteLine($"{Nom} a validé la convention pour {convention.Etudiant.Prenom} {convention.Etudiant.Nom}");
            return true;
        }

        public override void ModifierProfil(string nouveauNom = null, string nouveauPrenom = null,
                                          string nouvelEmail = null, string nouveauMotDePasse = null)
        {
            if (!string.IsNullOrEmpty(nouveauNom))
                Nom = nouveauNom;

            if (!string.IsNullOrEmpty(nouvelEmail))
                Email = nouvelEmail;

            if (!string.IsNullOrEmpty(nouveauMotDePasse))
                MotDePasse = nouveauMotDePasse;

            Console.WriteLine($"Profil entreprise {Nom} (SIRET: {Siret}) modifié.");
        }
    }
}
