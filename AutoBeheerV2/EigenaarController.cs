using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheerV2
{
    public class EigenaarController
    {
        public ObservableCollection<Eigenaar> Eigenaars { get; }

        private AutoBeheerDataContext db;

        public EigenaarController()
        {
            db = new AutoBeheerDataContext();

            Eigenaars = new ObservableCollection<Eigenaar>(db.Eigenaars);
        }
    }
}
