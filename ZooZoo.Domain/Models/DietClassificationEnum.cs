using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZoo.Domain.Models
{
    public class DietClassification
    {
        public enum DietClassificationEnum
        {
            Herbivore = 1,
            Carnivore = 2,
            Omnivore = 3,
            Detritivore = 4
        }
    }
}
