using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Connexion.Models
{
    class Credentials: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nomUtilisateur = "";
        private string _motDePasse = "";
        private string _message = "";
        private bool _seSouvenir;
        private bool _isValid;

        // ── IsValid : champ + getter + SetIsValid() ─────────────────
        public bool IsValid
        {
            get { return _isValid; }
        }

        private void SetIsValid()
        {
            _isValid = !string.IsNullOrEmpty(NomUtilisateur) &&
                       !string.IsNullOrEmpty(MotDePasse);
        }

        public string NomUtilisateur
        {
            get { return _nomUtilisateur; }
            set
            {
                if (_nomUtilisateur != value)
                {
                    _nomUtilisateur = value;
                    SetIsValid();
                    OnPropertyChanged();
                }
            }
        }

        public string MotDePasse
        {
            get { return _motDePasse; }
            set
            {
                if (_motDePasse != value)
                {
                    _motDePasse = value;
                    SetIsValid();
                    OnPropertyChanged();
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

        public bool SeSouvenir
        {
            get { return _seSouvenir; }
            set
            {
                if (_seSouvenir != value)
                {
                    _seSouvenir = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Authentifier() => NomUtilisateur == "admin" && MotDePasse == "1234";

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
