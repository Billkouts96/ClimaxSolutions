using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climax_trial.MVVM.Model
{

    public class DataAccess
    {
        public List<string> COMPANY_TYPES { get; set; }
        public DataAccess() {
             COMPANY_TYPES = new List<string>()
            { "Ατομική επιχείρηση",
                "Ομόρρυθμη εταιρία",
                "Ετερόρρυθμη εταιρία",
                "ΑΕ",
               "Μονοπρόσωπη ΙΚΕ",
                "ΙΚΕ",
                "ΚΟΙΝΣΕΠ" };
    }
    }
}

    
          


