using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GestionnaireTaches.Models
{
    class NouveauTache: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nom = "";
        private string _priorite = "Basse";
        private string _erreur = "";
        private bool _isValid;

        // ── IsValid : champ + getter + SetIsValid() ─────────────────
        public bool IsValid
        {
            get { return _isValid; } 
        }

        private void SetIsValid()
        {
            _isValid = !string.IsNullOrEmpty(Nom);
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (_nom != value)
                {
                    _nom = value;
                    SetIsValid();
                    OnPropertyChanged();
                }
            }
        }

        public string Priorite
        {
            get { return _priorite; }
            set
            {
                if (_priorite != value)
                {
                    _priorite = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsPrioriteBasse));
                    OnPropertyChanged(nameof(IsPrioriteMoyenne));
                    OnPropertyChanged(nameof(IsPrioriteHaute));
                }
            }
        }

        public bool IsPrioriteBasse
        {
            get { return Priorite == "Basse"; }
            set { if (value) Priorite = "Basse"; }
        }

        public bool IsPrioriteMoyenne
        {
            get { return Priorite == "Moyenne"; }
            set { if (value) Priorite = "Moyenne"; }
        }

        public bool IsPrioriteHaute
        {
            get { return Priorite == "Haute"; }
            set { if (value) Priorite = "Haute"; }
        }

        public string Erreur
        {
            get { return _erreur; }
            set
            {
                if (_erreur != value)
                {
                    _erreur = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Icone()
        {
            if (Priorite == "Haute") return "🔴";
            if (Priorite == "Moyenne") return "🟡";
            return "🟢";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
