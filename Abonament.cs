using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
    [Serializable]
    public enum tipAbonament { Abonament_normal=0,Abonament_premium=1,Abonament_Student=2 };
    [Serializable]
    public class Abonament
    {
        private tipAbonament tipAbonament;
        private double pret;
        private int nrSedinte;

        public Abonament()
        {
            
        }

        public Abonament(tipAbonament tipAbonament, double pret, int nrSedinte)
        {
            this.tipAbonament = tipAbonament;
            this.pret = pret;
            this.nrSedinte = nrSedinte;
        }

        public double Pret { get => pret; set => pret = value; }
        public int NrSedinte { get => nrSedinte; set => nrSedinte = value; }
        internal tipAbonament TipAbonament { get => tipAbonament; set => tipAbonament = value; }
    }
}
