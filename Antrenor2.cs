using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
   public class Antrenor2
    {
        public int Id { get; set; }//PK in tabela

        public String Nume { get; set; }
        public String Prenume { get; set; }

        // public List<TipAntrenor> tipAntrenor{get;set;}

        public int numarCliienti { get; set; }
        public String Manager { get; set; }


        public List<Client> Clienti { get; set; }

        public Antrenor2(int id, string nume, string prenume, int numarCliienti, List<Client> clienti)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            this.numarCliienti = numarCliienti;
            Clienti = clienti;
        }

        public Antrenor2()
        {
        }

    }
}
