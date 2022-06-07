using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Climax_trial.Core;

namespace Climax_trial.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        //create Relay commands to be able to switch between views
        public RelayCommand ExpensesViewCommand { get; set; }
        public RelayCommand DashboardViewCommand { get; set; }

        public RelayCommand IncomesViewCommand { get; set; }

        private object  _currentView;

        public object  CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        
        public ExpensesViewModel ExpenseObj { get; set; }
        public DashboardViewModel DashboardObj { get; set; }

        public IncomesViewModel IncomeObj { get; set; }
        public MainViewModel()
        {
            //just create a new instance of the class
            ExpenseObj = new ExpensesViewModel();
            DashboardObj = new DashboardViewModel();
            IncomeObj = new IncomesViewModel();

            CurrentView = DashboardObj;

            DashboardViewCommand = new RelayCommand(o =>
            {
                CurrentView=DashboardObj;
            });


            ExpensesViewCommand = new RelayCommand(o =>
            {
                CurrentView = ExpenseObj;
            });

            IncomesViewCommand = new RelayCommand(o =>
            {
                CurrentView = IncomeObj;
            });



        }
    }
}
