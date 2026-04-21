using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConvertisseurTemp.Models
{
    public class Temperature : INotifyPropertyChanged
    {
        // Champs privés
        private string _saisie = "";
        private string _resultat = "";
        private bool _arrondir;
        private string _erreur = "";
        private bool _isValid;

        public event PropertyChangedEventHandler? PropertyChanged;

        // IsValid : utilisé par le ViewModel pour CanExecute
        public bool IsValid
        {
            get { return _isValid; }
        }

        private void SetIsValid()
        {
            _isValid = !string.IsNullOrEmpty(Saisie) &&
                       double.TryParse(Saisie, out _);
        }

        // Propriétés publiques (bindées à la View)
        public string Saisie
        {
            get => _saisie;
            set { _saisie = value; SetIsValid(); OnPropertyChanged(); }
        }

        public string Resultat
        {
            get => _resultat;
            set { _resultat = value; OnPropertyChanged(); }
        }

        public bool Arrondir
        {
            get => _arrondir;
            set { _arrondir = value; OnPropertyChanged(); }
        }

        public string Erreur
        {
            get => _erreur;
            set { _erreur = value; OnPropertyChanged(); }
        }

        // Formules de conversion
        public static double VersCelsius(double f) => (f - 32) * 5.0 / 9.0;
        public static double VersFahrenheit(double c) => c * 9.0 / 5.0 + 32;

        // INotifyPropertyChanged 
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
