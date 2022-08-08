using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
    [Serializable]
   public class Client

    {
        public int Id { get; set; }//PK in tabela
        public int AntrenoriId { get; set; }//FK in tabela
        public string numeClient;
       public string prenumeClient;
        public DateTime dateNasterii;
       public tipAbonament TipAbonament;

 

        public Client(/*int idClientt*/ string numeClient, string prenumeClent, 
            DateTime dateNasterii, tipAbonament tipAbonament, String prenumeClient, string numeClientt, int idClient, tipAbonament tipAbonament1)
        {
           // this.IdClient = idClientt;
            this.NumeClient = numeClientt;
            this.PrenumeClient = prenumeClient;
            this.DateNasterii = dateNasterii;
            TipAbonament = tipAbonament;
        
        }

        public Client()
        {
        }

        public string PrenumeClient { get => prenumeClient; set => prenumeClient = value; }
        public string NumeClient { get => numeClient; set => numeClient = value; }
       // public int IdClient { get => idClient; set => idClient = value; }
        public tipAbonament TipAbonament1 { get => TipAbonament; set => TipAbonament = value; }
        public DateTime DateNasterii { get => dateNasterii; set => dateNasterii = value; }
    }
}
