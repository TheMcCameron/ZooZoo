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
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; }
    }
}
