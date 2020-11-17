using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooZoo.Domain;

namespace ZooZoo.EntityFramework
{
    public class ZooZooDbContext : DbContext
    {
        public ZooZooDbContext()
            :base("name=ZooZooDbContext")
        {

        }
        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }

    }
}
