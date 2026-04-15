using KB18059_WpfApp1.Infrastructure;

namespace KB18059_WpfApp1.Model;

internal class Person : ObservableObject
{
    private int _id;
    private string? _test1;
    private int? _test2;

    public int ID
    {
        get => _id;
        set
        {
            if (_id != value)
            {
                _id = value;
                OnPropertyChanged();
            }
        }
    }

    public string? Test1
    {
        get => _test1;
        set
        {
            if (_test1 != value)
            {
                _test1 = value;
                OnPropertyChanged();
            }
        }
    }

    public int? Test2
    {
        get => _test2;
        set
        {
            if (_test2 != value)
            {
                _test2 = value;
                OnPropertyChanged();
            }
        }
    }
}