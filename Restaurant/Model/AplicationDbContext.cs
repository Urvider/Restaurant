using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //crear la conexion a la base de datos
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Restauran;" +
                "Integrated Security= True").EnableSensitiveDataLogging(true);

        }
        
    }
}
