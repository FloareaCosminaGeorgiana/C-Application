using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
    public class Aparat
    {
        private String denumireAparat;
        private double latimeAparat;
        private double inaltimeAparat;
        private int nrInStoc;

        public Aparat()
        {
        }

        public Aparat(string denumireAparat, double latimeAparat, double inaltimeAparat, int nrInStoc)
        {
            DenumireAparat = denumireAparat;
            LatimeAparat = latimeAparat;
            InaltimeAparat = inaltimeAparat;
            NrInStoc = nrInStoc;
        }

        public int NrInStoc { get => nrInStoc; set => nrInStoc = value; }
        public double InaltimeAparat { get => inaltimeAparat; set => inaltimeAparat = value; }
        public double LatimeAparat { get => latimeAparat; set => latimeAparat = value; }
        public string DenumireAparat { get => denumireAparat; set => denumireAparat = value; }

        public override string ToString()
        {
            return "Denumire aparat: " + denumireAparat + ", latime aparat: " + latimeAparat + ", inaltime aparat: " + inaltimeAparat + ", nr. in stoc: " + nrInStoc;
        }
    }
}