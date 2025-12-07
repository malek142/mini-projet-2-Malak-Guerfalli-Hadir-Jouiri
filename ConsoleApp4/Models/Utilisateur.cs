using System;

namespace ConsoleApp4.Models
{
    public abstract class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public bool Actif { get; set; } = true;

        public virtual bool SeConnecter(string email, string mdp)
        {
            return Email == email && MotDePasse == mdp;
        }

        public void SeDeconnecter()
        {
            Console.WriteLine($"{Prenom} {Nom} s'est déconnecté.");
        }

        public virtual void ModifierProfil(string nouveauNom = null, string nouveauPrenom = null,
                                          string nouvelEmail = null, string nouveauMotDePasse = null)
        {
            if (!string.IsNullOrEmpty(nouveauNom))
                Nom = nouveauNom;

            if (!string.IsNullOrEmpty(nouveauPrenom))
                Prenom = nouveauPrenom;

            if (!string.IsNullOrEmpty(nouvelEmail))
                Email = nouvelEmail;

            if (!string.IsNullOrEmpty(nouveauMotDePasse))
                MotDePasse = nouveauMotDePasse;

            Console.WriteLine($"Profil de {Prenom} {Nom} modifié avec succès.");
        }
    }
}