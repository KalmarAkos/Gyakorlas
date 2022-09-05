using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExercise
{
    public enum MotorTipus
    {
        Naked,
        Enduro,
        Supermoto,
        Speed,
        Chopper
    }
    public class Motor : Jarmu
    {
        private MotorTipus motorTipus;

        public Motor(MotorTipus motorTipus, string rendszam, string gyarto, string tipus, int hengerurtartalom) :
            base(rendszam, gyarto, tipus, hengerurtartalom)
        {
            this.MotorTipus = motorTipus;
        }

        public override string ToString()
        {
            return "(M)" + base.ToString() + $"{MotorTipus} ,(Jogosítvány : {Jogositvany})";
        }

        public MotorTipus MotorTipus { get => motorTipus; set => motorTipus = value; }

        public string Jogositvany
        {
            get
            {
                if (Hengerurtartalom > 700)
                {
                    return "A";
                }
                else if (Hengerurtartalom > 125 && Hengerurtartalom <= 700)
                {
                    return "A2";
                }
                else if (Hengerurtartalom > 50 && Hengerurtartalom <= 125)
                {
                    return "A1";
                }
                else
                {
                    return "AM";
                }
            }
        }

        public override double Fogyasztas()
        {
            double alapFogyasztas = 1.5;

            switch (MotorTipus)
            {
                case MotorTipus.Naked:
                    alapFogyasztas *= 2;
                    break;
                case MotorTipus.Enduro:
                    alapFogyasztas *= 3;
                    break;
                case MotorTipus.Supermoto:
                    alapFogyasztas *= 4;
                    break;
                case MotorTipus.Speed:
                    alapFogyasztas *= 5;
                    break;
                case MotorTipus.Chopper:
                    alapFogyasztas *= 6;
                    break;
            }
            return alapFogyasztas;
        }
    }
}
