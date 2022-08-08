using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
    public class HRApplicationContext : DbContext
    {
        // public List<Client> Clienti;
        //interactiunea cu datele din tabela antrenori
        public DbSet<Antrenor2> Antrenori2 { get; set; }
        public DbSet<Client> Clienti { get; set; }

        //etapa de configurare - specif tip bd si calea catre bd
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hr.db");
        }

        public HRApplicationContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
