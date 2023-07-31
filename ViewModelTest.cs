using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiComm_ReproPopupPicker
{
    public class ViewModelTest : INotifyPropertyChanged
    {
        Outlet _selectedItemOutlet;

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Outlet SelectedItemOutlet
        {
            get 
            { 
                return _selectedItemOutlet; 
            }
            set 
            { 
                if (_selectedItemOutlet != value)
                {
                    _selectedItemOutlet = value;
                    NotifyPropertyChanged();
                } 
            }
        }

        public ObservableCollection<Outlet> Outlets { get; set; }

        public ViewModelTest()
        {
            Outlets = new ObservableCollection<Outlet>()
            {
                new Outlet() { Name = "Outlet0" },
                new Outlet() { Name = "Outlet1" },
                new Outlet() { Name = "Outlet2" },
            };

            SelectedItemOutlet = Outlets[1];
        }
    }

    public class Outlet
    {
        public string Name { get; set; }
    }
}
