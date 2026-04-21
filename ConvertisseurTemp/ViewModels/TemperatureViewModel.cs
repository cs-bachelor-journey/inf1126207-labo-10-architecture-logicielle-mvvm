using ConvertisseurTemp.Models;
using System.Windows.Input;

namespace ConvertisseurTemp.ViewModels
{
    public class TemperatureViewModel 
    {
        // Le ViewModel expose le Model à la View via cette propriété
        public Temperature Temperature { get; set; }

        // Commandes (bindées aux boutons)
        public ICommand VersCelsiusCommand { get; set; }
        public ICommand VersFahrenheitCommand { get; set; }

        private void ConvertirVersCelsius()
        {
            Temperature.Erreur = "";
            if (!double.TryParse(Temperature.Saisie, out double val))
            {
                Temperature.Erreur = "Saisie invalide.";
                return;
            }
            double r = Temperature.VersCelsius(val);
            Temperature.Resultat = Temperature.Arrondir
                ? $"{Math.Round(r)} °C"
                : $"{r:F2} °C";
        }

        private void ConvertirVersFahrenheit()
        {
            Temperature.Erreur = "";
            if (!double.TryParse(Temperature.Saisie, out double val))
            {
                Temperature.Erreur = "Saisie invalide.";
                return;
            }
            double r = Temperature.VersFahrenheit(val);
            Temperature.Resultat = Temperature.Arrondir
                ? $"{Math.Round(r)} °F"
                : $"{r:F2} °F";
        }

        public TemperatureViewModel()
        {
            Temperature = new Temperature();

            VersCelsiusCommand = new RelayCommand(o => Temperature.IsValid, o => ConvertirVersCelsius());
            VersFahrenheitCommand = new RelayCommand(o => Temperature.IsValid, o => ConvertirVersFahrenheit());
        }      
    }
}
