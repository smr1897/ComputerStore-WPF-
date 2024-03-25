using ComputerStore.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

		public RelayCommand ProductViewCommand { get; set; }

        public RelayCommand EmployeeViewCommand { get; set; }

		public HomeViewModel HomeVM { get; set; }
        public ProductViewModel ProductVM { get; set; }
		public EmployeeViewModel EmployeeVM { get; set; }

        private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			
			set 
			{ 
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
			ProductVM = new ProductViewModel();
			EmployeeVM = new EmployeeViewModel();
	
			CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand(o => 
			{
				CurrentView = HomeVM;
				}
			);

			ProductViewCommand = new RelayCommand(o =>
			{
				CurrentView = ProductVM;
			}

			);

			EmployeeViewCommand = new RelayCommand(o =>
			{
				CurrentView = EmployeeVM;
			});
		}

	}
}
