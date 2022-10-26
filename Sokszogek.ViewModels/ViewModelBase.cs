using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sokszogek.ViewModels
{
    // https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-property-change-notification
    // Ez az osztály valósítja meg INotifyPropertyChanged interfészt
    // az egyirányú és kétirányú kötések támogatására 
    // (olyan, hogy az UI elem frissüljön, amikor a forrás 
    // dinamikusan módosul)
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Esemény deklarálása
        public event PropertyChangedEventHandler PropertyChanged;

        // Az OnPropertyChanged metódust létrehozása az esemény meghívásához
        // A hívó fél neve lesz paraméter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
