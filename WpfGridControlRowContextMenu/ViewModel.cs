using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace WpfGridControlRowContextMenu
{
    public class ViewModel
    {
        public ViewModel()
        {
            People = new ObservableCollection<Model>
            {
                new Model {Name = "Milan"},
                new Model {Name = "Marta"}
            };

            TestCommand = new RelayCommand(ExecuteMethod);
        }

        private void ExecuteMethod(object parameter)
        {
            var param = (List<Model>)parameter;
        }

        public ObservableCollection<Model> People { get; set; }

        public ICommand TestCommand { get; set; }
    }
}
