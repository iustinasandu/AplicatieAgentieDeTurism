using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurism
{
    [Serializable]
    public class Tranzactie
    {
        public int idTranzactie = 1;
        public string numeClient { get; set; }
        public string prenumeClient { get; set; }
        public float pret { get; set; }
        public float TVA()
        {
            return (float)(0.19 * this.pret);
        }
        public float pretFinal()
        {
            return (this.pret + this.TVA());
        }
        public int nrFactura = 1;
        

        public Tranzactie()
        {
            idTranzactie = 0;
            numeClient = "";
            prenumeClient = "";
            pret = 0;
            nrFactura = 0;
        }

        public Tranzactie(int idTranzactie, string numeClient, string prenumeClient, float pret, int nrFactura)
        {
            idTranzactie++;
            this.numeClient = numeClient;
            this.prenumeClient = prenumeClient;
            this.pret = pret;
            nrFactura++;
        }

    }
}
