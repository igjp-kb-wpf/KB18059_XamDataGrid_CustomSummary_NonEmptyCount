using KB18059_WpfApp1.Infrastructure;
using KB18059_WpfApp1.Model;
using System.Collections.ObjectModel;

namespace KB18059_WpfApp1;

class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<Person> _people = new();
    public ObservableCollection<Person> People
    {
        get => _people;
        set
        {
            if (_people != value)
            {
                _people = value;
                OnPropertyChanged();
            }
        }
    }

    public MainWindowViewModel()
    {
        _people = new ()
        {
            new() { ID = 1, Test1 = "Test1", Test2 = 30 },
            new() { ID = 2, Test1 = "Test2", Test2 = null },
            new() { ID = 3, Test1 = null, Test2 = 40 },
            new() { ID = 4, Test1 = "Test4", Test2 = 35 },
            new() { ID = 5, Test1 = "", Test2 = null }
        };
    }
}