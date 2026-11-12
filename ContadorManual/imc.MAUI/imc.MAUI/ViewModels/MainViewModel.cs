using imc.MAUI.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace imc.MAUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _peso;
        private string _estatura;
        private string _imc;
        private string _estadoNutricional;
        public string Peso
        {
            get => _peso;
            set
            {
                if (_peso != value)
                {
                    _peso = value;
                    OnPropertyChanged(nameof(Peso));
                }
            }
        }

        public string Estatura
        {
            get => _estatura;
            set
            {
                if (_estatura != value)
                {
                    _estatura = value;
                    OnPropertyChanged(nameof(Estatura));
                }
            }
        }

        public string Imc
        {
            get => _imc;
            set
            {
                if (_imc != value)
                {
                    _imc = value;
                    OnPropertyChanged(nameof(Imc));
                }
            }
        }

        public string EstadoNutricional
        {
            get => _estadoNutricional;
            set
            {
                if (_estadoNutricional != value)
                {
                    _estadoNutricional = value;
                    OnPropertyChanged(nameof(EstadoNutricional));
                }
            }
        }

        public ICommand CalcularComand { get; private set; }
        public ICommand LimpiarCommand { get; private set; }
        public MainViewModel ()
        {
            CalcularComand = new Command(CalcularResultados);
            LimpiarCommand = new Command(LimpiarDatos);
        }

        private void CalcularResultados()
        {
            decimal peso;
            decimal estatura;
            bool PesoEsValido = decimal.TryParse(Peso, out peso);
            bool EstaturaEsVlida = decimal.TryParse(Estatura, out estatura);

            if (PesoEsValido && EstaturaEsVlida)
            {
                decimal imc = Calculadora.IndiceDeMasaCorporal(peso, estatura);
                Imc = imc.ToString("f4");
                EstadoNutricional = Calculadora.SituacionNutricional(imc);
            }
        }

        private void LimpiarDatos ()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            EstadoNutricional = string.Empty;

        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
