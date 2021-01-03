using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static ZooZoo.Domain.Models.DietClassification;

namespace ZooZoo.Domain
{
    public class Animal : DomainObject
    {
        public Animal()
        {
            this.Zoos = new HashSet<Zoo>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DietClassificationEnum? DietClassification {get;set;}
        public ICollection<Zoo> Zoos { get; set; }
    }
}