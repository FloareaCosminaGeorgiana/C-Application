using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Extensions.EnumMapping;

namespace PAW_PROJECT
{
   
  //  public  enum TipAntrenor {Antrenor_fitness=0,Antrenor_zumba=1,Antrenor_kangoo_jumps=2 }
    public class Antrenor
    {
        public int Id { get; set; }//PK in tabela

        public String Nume { get; set; }
        public String Prenume { get; set; }

       // public List<TipAntrenor> tipAntrenor{get;set;}

        public int numarCliienti { get; set; }
        
        public List<Client> Clienti { get; set; }

        public Antrenor(int id, string nume, string prenume, int numarCliienti, List<Client> clienti)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            this.numarCliienti = numarCliienti;
            Clienti = clienti;
        }

        public Antrenor()
        {
        }



        //public void adaugaTipAntrenor(TipAntrenor optional)
        //{
        //    tipAntrenor.Add(optional);
        //}
    }
}
