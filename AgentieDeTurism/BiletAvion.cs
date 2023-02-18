using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurism
{
    [Serializable]
    public class BiletAvion
    {
        public long IdBilet { get; set; }
        public DateTime dataPlecare { get; set; }
        public DateTime dataIntoarcere { get; set; }

        public string orasPlecare { get; set; }
        public string orasDestinatie { get; set; }

        public string nrLoc { get; set; }
        public float pret { get; set; }

        public BiletAvion() 
        {

        }

        public BiletAvion(DateTime dataPlecare, DateTime dataIntoarcere, string orasPlecare, string orasDestinatie, string nrLoc, float pret)
        {
            this.dataPlecare = dataPlecare;
            this.dataIntoarcere = dataIntoarcere;
            this.orasPlecare = orasPlecare;
            this.orasDestinatie = orasDestinatie;
            this.nrLoc = nrLoc;
            this.pret = pret;
        }

        public BiletAvion(long id, DateTime dataPlecare, DateTime dataIntoarcere, string orasPlecare, string orasDestinatie, string nrLoc, float pret)
            : this(dataPlecare, dataIntoarcere, orasPlecare, orasDestinatie, nrLoc, pret)
        {
            IdBilet = id;
        }

    }
}
