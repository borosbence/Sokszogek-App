using Sokszogek.Models;

namespace Sokszogek.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private double _oldalA;
        public double OldalA
        {
            get { return _oldalA; }
            set
            {
                _oldalA = value;
                Szamitas();
            }
        }

        private double _oldalB;
        public double OldalB
        {
            get { return _oldalB; }
            set
            {
                _oldalB = value;
                Szamitas();
            }
        }

        private double _oldalC;
        public double OldalC
        {
            get { return _oldalC; }
            set
            {
                _oldalC = value;
                Szamitas();
            }
        }

        private double _kerulet;
        public double Kerulet
        {
            get { return _kerulet; }
            set
            {
                _kerulet = value;
                OnPropertyChanged();
            }
        }

        private double _terulet;
        public double Terulet
        {
            get { return _terulet; }
            set
            {
                _terulet = value;
                OnPropertyChanged();
            }
        }

        public List<string> SokszogList { get; } = ["Négyzet", "Téglalap", "Háromszög"];

        private string? _kijeloltElem;
        public string? KijeloltElem
        {
            get { return _kijeloltElem; }
            set
            {
                _kijeloltElem = value;
                Szamitas();
            }
        }

        private void Szamitas()
        {
            Sokszog? sokszog = null;
            switch (_kijeloltElem)
            {
                case "Négyzet":
                    // Polimorfizumus
                    sokszog = new Negyzet(OldalA);
                    break;
                case "Téglalap":
                    sokszog = new Teglalap(OldalA, OldalB);
                    break;
                case "Háromszög":
                    sokszog = new Haromszog(OldalA, OldalB, OldalC);
                    break;
                default:
                    break;
            }
            if (sokszog != null)
            {
                Kerulet = sokszog.Kerulet();
                Terulet = sokszog.Terulet();
            }
        }
    }
}
