using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KB18059_WpfApp1.Infrastructure;

abstract class ObservableObject : INotifyPropertyChanged
{
    protected ObservableObject()
    {

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] String? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

