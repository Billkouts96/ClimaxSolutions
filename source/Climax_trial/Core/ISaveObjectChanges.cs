using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climax_trial.Core
{
    public class SaveObjectChangesEventArgs
    {
        private object _object;
        public object Object
        {
            get => _object;
        }
        public SaveObjectChangesEventArgs(object obj)
        {
            this._object = obj;
        }
    }
   public  interface ISaveObjectChanges
    {
        public delegate void SaveObjectChangesHandler(object sender, SaveObjectChangesEventArgs e);
        public event SaveObjectChangesHandler SaveObject;
        public void SaveObjectExecute(object obj);
    }
}
