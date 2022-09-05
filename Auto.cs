using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExercise
{
    public enum AutoTipus
    {
        Sedan,
        Pickup,
        Egyterü,
        SUV
    }
    public class Auto : Jarmu
    {
        private AutoTipus autoTipus;
        private int csomagterTerfogat;

        public Auto(AutoTipus autoTipus, int csomagterTerfogat, string rendszam, string gyarto, string tipus, int hengerurtartalom) :
            base(rendszam, gyarto, tipus, hengerurtartalom)
        {
            this.AutoTipus = autoTipus;
            this.CsomagterTerfogat = csomagterTerfogat;
        }

        public AutoTipus AutoTipus { get => autoTipus; set => autoTipus = value; }
        public int CsomagterTerfogat { get => csomagterTerfogat; set => csomagterTerfogat = value; }

        public override string ToString()
        {
            return "(A)"+base.ToString() +$"{autoTipus} (csom.térf.:{csomagterTerfogat} Liter)";
        }
        public override double Fogyasztas()
        {
            double alapFogyasztas = 2.0;

            switch (AutoTipus)
            {
                case AutoTipus.Sedan:
                    alapFogyasztas *= 3;
                    break;

                case AutoTipus.Egyterü:
                    alapFogyasztas *= 4;
                    break;

                case AutoTipus.SUV:
                    alapFogyasztas *= 5;
                    break;

                case AutoTipus.Pickup:
                    alapFogyasztas *= 6;
                    break;
            }

            return alapFogyasztas;
        }
    }
}
