using Sokszogek.Models;
using System.Collections.ObjectModel;

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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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

        public ObservableCollection<string> SokszogList { get; set; }

        private string _kijeloltElem;
        public string KijeloltElem
        {
            get { return _kijeloltElem; }
            set
            {
                _kijeloltElem = value;
                Szamitas();
            }
        }

        public MainViewModel()
        {
            SokszogList = new ObservableCollection<string>
            {
                "Négyzet",
                "Téglalap",
                "Háromszög"
            };
        }

        private void Szamitas()
        {
            switch (_kijeloltElem)
            {
                case "Négyzet":
                    var negyzet = new Negyzet(OldalA);
                    Kerulet = negyzet.Kerulet();
                    Terulet = negyzet.Terulet();
                    break;
                case "Téglalap":
                    var teglalap = new Teglalap(OldalA, OldalB);
                    Kerulet = teglalap.Kerulet();
                    Terulet = teglalap.Terulet();
                    break;
                case "Háromszög":
                    var haromszog = new Haromszog(OldalA, OldalB, OldalC);
                    Kerulet = haromszog.Kerulet();
                    Terulet = haromszog.Terulet();
                    break;
                default:
                    break;
            }
        }
    }
}
