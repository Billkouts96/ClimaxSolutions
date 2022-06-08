using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Climax_trial.MVVM.Model;
using Climax_trial.Core;
using Climax_trial.MVVM.ViewModel;

namespace Climax_trial.Services
{
    class Service
    {
        private static Service instance;
        private static ApplicationContext _db { get; set; }

       

        private Service()
        {
            _db = new ApplicationContext();
            _db.Database.EnsureCreated();
           
        }

        #region Getters
   
        public float GetVatRefund(Expenses Expense)
        {
            return Expense.Taxfree * Expense.Tax;
        }
        public List<string> GetExpensesCategories
        {
            get
            {
                //this eventually will return all expenses categories names

                return _db.Expenses.Select(c => c.Name).ToList();
            }
        }

        public List <Expenses> GetExpenses
        {
            get
            {
                return _db.Expenses.ToList();
            }
        }
        //create dictionary which contains as values the prices and as keys each category
        public static Dictionary<string, float> GetExpensesCategoriesDictionary(ICollection<Expenses> expenses)
        {
            Dictionary<string, float> categories = new();
            foreach (var exp in expenses)
            {
                if (!categories.ContainsKey(exp.Name)) categories.Add(exp.Name, exp.Price);
                else categories[exp.Name] += exp.Price;
            }
            return categories;
        }

        #endregion

        #region ChangeCollection
        #region Expense
        public void AddExpense(Expenses Expense)
        {
            _db.Expenses.Add(Expense);
          // exception handling for annoying " unique contraint error sqlite" to be solved when fuly undrestood

          _db.SaveChanges();
            
           
        }
        

        public void DeleteAccount(Expenses Expense)
        {

            _db.Expenses.Remove(Expense);
            _db.SaveChanges();
        }
        #endregion
        #endregion

        public static Service GetInstance()
        {
            if (instance == null) instance = new Service();
            return instance;
        }
    }
}

