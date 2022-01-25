using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBeheerV2
{
    public class GebruikerController
    {
        private AutoBeheerDataContext db;

        public ObservableCollection<Gebruiker> Gebruiker { get; }

        public GebruikerController()
        {
            db = new AutoBeheerDataContext();

            Gebruiker = new ObservableCollection<Gebruiker>(db.Gebruikers);
        }

        public void NieuwGebruiker(Gebruiker gebruiker) 
        {
            if (Gebruiker != null) 
            {
                db.Gebruikers.InsertOnSubmit(gebruiker);

                db.SubmitChanges();

                Gebruiker.Add(gebruiker);
            }
        }

        public void WijzigGebruiker(Gebruiker gebruiker) 
        {
            if (Gebruiker != null)
            {
                db.SubmitChanges();
            }
        }

        public void VerwijderGebruiker(Gebruiker gebruiker) 
        {
            if (Gebruiker != null)
            {
                db.Gebruikers.DeleteOnSubmit(gebruiker);

                db.SubmitChanges();

                Gebruiker.Remove(gebruiker);
            }
        }

        public Gebruiker Inloggen(string naam, string wachtwoord)
        {
            var gebruiker = db.Gebruikers.Where(g => g.Naam == naam && g.Wachtwoord == wachtwoord).SingleOrDefault();

            return gebruiker;
        }

    }
}
