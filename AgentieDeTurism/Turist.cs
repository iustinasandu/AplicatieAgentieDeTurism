using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurism
{
    [Serializable]
    public class Turist
    {
        public long IdTurist { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public DateTime data_nasterii { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }

        public Turist()
        {

        }

        public Turist(string nume, string prenume, DateTime data_nasterii, string telefon, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.data_nasterii = data_nasterii;
            this.telefon = telefon;
            this.email = email;
        }

        public Turist(long id, string nume, string prenume, DateTime data_nasterii, string telefon, string email)
            : this(nume, prenume, data_nasterii, telefon, email)
        {
            IdTurist = id;
        }

    }
}
