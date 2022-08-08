using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PAW_PROJECT
{

    public class HRAntrenorContex : DbContext
    {
        //  public List<Client> Clienti;
        //interactiunea cu datele din tabela antrenori
        public DbSet<Antrenor> Antrenori { get; set; }

        //etapa de configurare - specif tip bd si calea catre bd
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hr.db");
        }

        public HRAntrenorContex()
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
