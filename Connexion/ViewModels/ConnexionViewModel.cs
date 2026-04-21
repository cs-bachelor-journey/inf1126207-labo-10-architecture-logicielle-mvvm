using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Connexion.ViewModels
{
    class ConnexionViewModel
    {
        public Models.Credentials Credentials { get; set; }
        public ICommand ConnexionCommand { get; set; }

        private void SeConnecter()
        {
            if (Credentials.Authentifier())
            {
                Credentials.Message = $"✅ Bienvenue, {Credentials.NomUtilisateur} !";
                if (Credentials.SeSouvenir)
                    Console.WriteLine($"Mémorisation : {Credentials.NomUtilisateur}");
            }
            else
            {
                Credentials.Message = "❌ Identifiants incorrects.";
            }
        }

        public ConnexionViewModel()
        {
            Credentials = new Models.Credentials();

            ConnexionCommand = new RelayCommand(o => Credentials.IsValid, o => SeConnecter());
        }
    }
}
