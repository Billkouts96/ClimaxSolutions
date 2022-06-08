using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climax_trial.Core;

namespace Climax_trial.MVVM.Model
{
    //This class is used to initialize database items for expenses
    
    public class Expenses
    {

        public int     Id { get; set; }
        private string _name;
        private string _type;
        private float _price;
        private float _taxfree;
        private float _tax;

        #region Properties
        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public float Price { get { return _price; } set { _price = value; } }
        public float Taxfree { get { return _taxfree; } set { _taxfree = value; } }
        public float Tax { get { return _tax; } set { _tax = value; } }
        #endregion

        public Expenses()
        {
            this._name = "x";
            this._price = 0;
            this._taxfree = 0;
            this._tax = 0;
            this._type = "y";
        }
        public Expenses(string Name)
        {
            this._name = Name;
        }

    }
}
