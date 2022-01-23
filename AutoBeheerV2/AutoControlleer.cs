using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheerV2
{
    public class AutoControlleer
    {
        public ObservableCollection<Auto> Autos { get; }

        private AutoBeheerDataContext db;
        public AutoControlleer()
        {
            db = new AutoBeheerDataContext();

            Autos = new ObservableCollection<Auto>(db.Autos);            
        }

    }
}
