using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SelecteurProduit.Models
{
    class Produit: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _produitNom = "";
        private decimal _produitPrix;
        private bool _garantieActive;
        private int _dureeGarantie = 1;
        private string _message = "";
        private bool _isValid;

        // ── IsValid : champ + getter + SetIsValid() ─────────────────
        public bool IsValid
        {
            get { return _isValid; }
        }

        private void SetIsValid()
        {
            _isValid = !string.IsNullOrEmpty(ProduitNom);
        }

        public string ProduitNom
        {
            get { return _produitNom; }
            set
            {
                if (_produitNom != value)
                {
                    _produitNom = value;
                    SetIsValid();
                    OnPropertyChanged();
                    OnPropertyChanged("PrixAffiche");
                }
            }
        }

        public decimal ProduitPrix
        {
            get { return _produitPrix; }
            set
            {
                if (_produitPrix != value)
                {
                    _produitPrix = value;
                    OnPropertyChanged();
                    OnPropertyChanged("PrixAffiche");
                }
            }
        }

        public bool GarantieActive
        {
            get { return _garantieActive; }
            set
            {
                if (_garantieActive != value)
                {
                    _garantieActive = value;
                    OnPropertyChanged();
                    OnPropertyChanged("PrixAffiche");
                }
            }
        }

        public int DureeGarantie
        {
            get { return _dureeGarantie; }
            set
            {
                if (_dureeGarantie != value)
                {
                    _dureeGarantie = value;
                    OnPropertyChanged();
                    OnPropertyChanged("PrixAffiche");
                }
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PrixAffiche
        {
            get
            {
                if (string.IsNullOrEmpty(ProduitNom)) return "—";
                decimal total = ProduitPrix + (GarantieActive ? DureeGarantie * 49.99m : 0);
                return $"{total:C}";
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
