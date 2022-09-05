using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExercise
{
    public abstract class Jarmu
    {
        private string rendszam;
        private string gyarto;
        private string tipus;
        private int hengerurtartalom;

        protected Jarmu(string rendszam, string gyarto, string tipus, int hengerurtartalom)
        {
            this.Rendszam = rendszam;
            this.Gyarto = gyarto;
            this.Tipus = tipus;
            this.Hengerurtartalom = hengerurtartalom;
        }

        public override string ToString()
        {
            return $"{Rendszam} : {Gyarto} ({Tipus}, {Hengerurtartalom})";
        }
        public abstract double Fogyasztas();

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public int Hengerurtartalom { get => hengerurtartalom; set => hengerurtartalom = value; }
    }
}
