using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace GestionnaireTaches.ViewModels
{
    class TachesViewModel
    {
        public Models.NouveauTache NouveauTache { get; set; }
        public ObservableCollection<string> Taches { get; set; }
        public ICommand AjouterTacheCommande { get; set; }

        // the function to adda new task
        public void AjouterTache()
        {
            NouveauTache.Erreur = "";

            // verify the task name if null or empty
            if (string.IsNullOrWhiteSpace(NouveauTache.Nom))
            {
                NouveauTache.Erreur = "Le nom est obligatoire.";
                return;
            }

            Taches.Add($"{NouveauTache.Icone()} [{NouveauTache.Priorite}] {NouveauTache.Nom}");
            NouveauTache.Nom = "";
        }

        public TachesViewModel()
        {
            NouveauTache = new Models.NouveauTache();
            Taches = new ObservableCollection<string>();

            AjouterTacheCommande = new RelayCommand(o => NouveauTache.IsValid, o => AjouterTache());
        }
    }
}
