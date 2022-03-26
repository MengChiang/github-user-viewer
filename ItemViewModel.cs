using System.ComponentModel;

namespace ListBox.Example
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _IsSelected;
        public bool IsSelected
        {
            get => _IsSelected;
            set
            {
                if (_IsSelected != value)
                {
                    _IsSelected = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSelected)));
                }
            }
        }

        public string Url { get; }

        public string Name { get; }

        public string Visibility { get; }

        public int Number { get; }

        public ItemViewModel(string url, string name, bool isAdmin, int number)
        {
            Url = url;
            Name = name;
            Visibility = isAdmin ? "Visible" : "Hidden";
            Number = number;

        }
    }
}
