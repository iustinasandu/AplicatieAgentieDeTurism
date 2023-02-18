using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentieDeTurism
{
    [Serializable]
    public class Cazare
    {
        public string numeHotel { get; set; }
        public TipCameraEnum tipCamera { get; set; }
        public TipPensiuneEnum tipPensiune { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public int nrPersoane { get; set; }
        public int nrNopti()
        {
            int diff = (checkOut - checkIn).Days;
            return diff;
        }
        public float tarif { get; set; }
        public float pretTotal()
        {
            int nr = nrNopti();
            return nr * tarif * nrPersoane;
        }

        public Cazare()
        {

        }

        public Cazare(string numeHotel, TipCameraEnum tipCamera, TipPensiuneEnum tipPensiune, DateTime checkIn, DateTime checkOut, int nrPersoane, float tarif)
        {
            this.numeHotel = numeHotel;
            this.tipCamera = tipCamera;
            this.tipPensiune = tipPensiune;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.nrPersoane = nrPersoane;
            this.tarif = tarif;
        }

    }
}
