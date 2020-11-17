using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooZoo.Domain
{
    public class Animal : DomainObject
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(800)]
        public string Description { get; set; }
        public IList<Zoo> Zoos { get; set; }
    }
}