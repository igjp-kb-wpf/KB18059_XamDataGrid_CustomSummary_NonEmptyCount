using System.Collections.ObjectModel;
using System.Windows;

namespace KB18059_WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var data = new ObservableCollection<Person>
            {
                new() { ID = 1, Test1 = "Test1", Test2 = 30 },
                new() { ID = 2, Test1 = "Test2", Test2 = null },
                new() { ID = 3, Test1 = null, Test2 = 40 },
                new() { ID = 4, Test1 = "Test4", Test2 = 35 },
                new() { ID = 5, Test1 = "", Test2 = null }
            };

            xamDataGrid1.DataSource = data;
        }
    }
    public class Person
    {
        public int ID { get; set; }
        public string? Test1 { get; set; }
        public int? Test2 { get; set; }
    }
}