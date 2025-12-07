using Microsoft.VisualBasic;
using System;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models
{
    public class Administrateur : Utilisateur
    {
        public string Matricule { get; set; }

        public void GererUtilisateurs()
        {
            Console.WriteLine($"{Prenom} {Nom} gère les utilisateurs du système.");
        }

        public void GenererStatistiques()
        {
            Console.WriteLine($"{Prenom} {Nom} génère des statistiques.");
        }

        public bool ValiderConvention(Convention convention)
        {
            if (convention == null) return false;

            convention.Statut = "Validée par l'administration";
            Console.WriteLine($"Administrateur {Nom} a validé la convention.");
            return true;
        }

        public void BloquerUtilisateur(Utilisateur utilisateur)
        {
            utilisateur.Actif = false;
            Console.WriteLine($"Utilisateur {utilisateur.Prenom} {utilisateur.Nom} bloqué.");
        }
    }
}