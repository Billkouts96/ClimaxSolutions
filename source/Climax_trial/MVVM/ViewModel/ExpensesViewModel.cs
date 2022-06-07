using System;
using System.Collections.Generic;
using LiveCharts;
using System.Linq;
using Climax_trial.MVVM.Model;
using Climax_trial.Core;
using Climax_trial.Services;
using System.Collections.ObjectModel;


namespace Climax_trial.MVVM.ViewModel
{
     public class ExpensesViewModel : ObservableObject , ISaveObjectChanges
    {
        //let's first initialize the categories of various expenses
        public List<string> EXPENSES_CATEGORIES { get; set; }
        public List<string> EXPENSE_TYPE{ get; set; }
        private Expenses _expense;

        //this is a button for save a new expense . Afterwards delete button will be introduced as well
        public RelayCommand SaveExpense { get; set; }
        //public RelayCommand AddNewExpense { get; set; }
        public event ISaveObjectChanges.SaveObjectChangesHandler SaveObject;

     
        public ObservableCollection<Expenses> Expenses
        {
            get
            {
                return new ObservableCollection<Expenses>(service.GetExpenses);
            }
        }

        Service service = Service.GetInstance();
        public ExpensesViewModel()
        {
            

            EXPENSES_CATEGORIES = new List<string>()
            { "Λογιστική παρακολούθηση",
                "Διαχείριση site",
                "Καθαριότητα",
                "Συντηρήσεις",
               "Ηλεκτρικό ρεύμα",
                "Υπεργολαβίες",
                "Τηλέφωνο" };


            EXPENSE_TYPE = new List<string>()
            {   "Ετήσια",
                "Μηνιαία",
                "Ημερήσια",
                };

            
            SaveExpense = new RelayCommand(obj =>
            {
                if (_expense != null)
                {
                    service.AddExpense(_expense);

                    //return to default values all the affected fields
                    _expense.Taxfree = 0;
                    _expense.Price = 0;
                    _expense.Tax = 0;
                    OnPropertyChanged(nameof(Expense));
                    OnPropertyChanged(nameof(ExpensesSeries));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(TaxFree));
                    OnPropertyChanged(nameof(Tax));
                }
                //dont know what is this about
                //SaveObjectExecute(this);               
            });


            _expense = new Expenses();

            
        }

        public Expenses  Expense
        {
            get => _expense;
        }
       
      
        public string Name
        {
            get => _expense.Name;
            set
            {
                _expense.Name = value;
                OnPropertyChanged();
            }
        }
        public string Type
        {
            get => _expense.Type;
            set
            {
                _expense.Type = value;
                OnPropertyChanged();
            }
        }

        public float Price
        {
            get => _expense.Price;
            set
            {
                _expense.Price = value;
                OnPropertyChanged();
            }
        }

        public float TaxFree
        {
            get => _expense.Taxfree;
            set
            {
                _expense.Taxfree = value;
                OnPropertyChanged();
            }
        }

        public float Tax
        {
            get => _expense.Tax;
            set
            {
                _expense.Tax = value;
                OnPropertyChanged();
            }
        }

        // series needed for the pie chart 

        public SeriesCollection ExpensesSeries
        {
            get => ChartsService.CreateSeriesCollection(Service.GetExpensesCategoriesDictionary(Expenses));
        }

        public List<string> LoadCategories
        {
            get => service.GetExpensesCategories;
            
            
           
        }

        public void SaveObjectExecute(object obj)
        {
            SaveObject?.Invoke(this, new SaveObjectChangesEventArgs(obj as ExpensesViewModel));
        }

    }
}
