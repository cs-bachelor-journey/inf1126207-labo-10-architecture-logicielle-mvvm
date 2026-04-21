using SelecteurProduit.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace SelecteurProduit.ViewModels
{
    class ProduitViewModel
    {
        public Models.Produit Produit { get; set; }
        public ObservableCollection<string> Produits { get; set; }
        public ICommand AcheterCommand { get; set; }

        private readonly Dictionary<string, decimal> _prix =
           new Dictionary<string, decimal>
           {
                { "Ordinateur", 1299.99m },
                { "Smartphone", 799.99m  },
                { "Tablette",   549.99m  }
           };

        public void SelectionnerProduit(string nom)
        {
            Produit.ProduitNom = nom;
            Produit.ProduitPrix = _prix.ContainsKey(nom) ? _prix[nom] : 0;
        }

        private void Acheter()
        {
            string garantie = Produit.GarantieActive
                ? $" + garantie {Produit.DureeGarantie} an(s)" : "";
            Produit.Message = $"✅ {Produit.ProduitNom}{garantie} → {Produit.PrixAffiche}";
        }

        public ProduitViewModel()
        {
            Produit = new Models.Produit();
            Produits = new ObservableCollection<string>()
                        { "Ordinateur", "Smartphone", "Tablette" };

            AcheterCommand = new RelayCommand(
                o => Produit.IsValid,
                o => Acheter()
            );
        }
    }
}
