using ConvertisseurTemp.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace ConvertisseurTemp.ViewModels
{
    public class TemperatureViewModel : INotifyPropertyChanged
    {
        // Champs privés
        private string _saisie = "";
        private string _resultat = "";
        private bool _arrondir;
        private string _erreur = "";

        // Propriétés publiques (bindées à la View)
        public string Saisie
        {
            get => _saisie;
            set { _saisie = value; OnPropertyChanged(); }
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

        // Commandes (bindées aux boutons)
        public ICommand VersCelsiusCommand { get; }
        public ICommand VersFahrenheitCommand { get; }

        public TemperatureViewModel()
        {
            VersCelsiusCommand = new RelayCommand(ConvertirVersCelsius);
            VersFahrenheitCommand = new RelayCommand(ConvertirVersFahrenheit);
        }

        private void ConvertirVersCelsius()
        {
            Erreur = "";
            if (!double.TryParse(Saisie, out double valeur))
            {
                Erreur = "Saisie invalide ou vide.";
                return;
            }
            double r = Temperature.VerscelsiuS(valeur);
            Resultat = Arrondir ? $"{Math.Round(r)} °C" : $"{r:F2} °C";
        }

        private void ConvertirVersFahrenheit()
        {
            Erreur = "";
            if (!double.TryParse(Saisie, out double valeur))
            {
                Erreur = "Saisie invalide ou vide.";
                return;
            }
            double r = Temperature.VersFahrenheit(valeur);
            Resultat = Arrondir ? $"{Math.Round(r)} °F" : $"{r:F2} °F";
        }

        // INotifyPropertyChanged 
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? nom = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nom));
        }
    }
}
