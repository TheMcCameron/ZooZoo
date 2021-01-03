using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZoo.Domain
{
    public class Zoo : DomainObject
    {
        public Zoo()
        {
            this.Animals = new HashSet<Animal>();
        }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
