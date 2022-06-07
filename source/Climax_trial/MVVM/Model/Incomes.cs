using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climax_trial.MVVM.Model
{
    public class Incomes
    {
        public int Id { get; set; }
        private string _month;
        private float _tax;
        private float _price;
        private float _taxableprice;
        

        #region Properties
        public string Month { get { return _month; } set { _month = value; } }
        public float Tax { get { return _tax; } set { _tax = value; } }
        public float Price { get { return _price; } set { _price = value; } }
        public float TaxablePrice { get { return _taxableprice; } set { _taxableprice = value; } }
        #endregion

        public Incomes()
        {
            this._month = "";
            this._tax = 0;
            this._price = 0;
            this._taxableprice =0;
        }

    }
}
