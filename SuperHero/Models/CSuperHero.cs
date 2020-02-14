using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class CSuperHero
    {

        //Member Variables (HAS A)
        [Key]
        public int ID { get; set; }
        public string SuperHeroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperheroAbility { get; set; }
        public string SecondarySuperHeroAbility { get; set; }
        public string CatchPhrase { get; set; }
        
        //Constructor

        
        //Member Methods (CAN DO)

    }
}
