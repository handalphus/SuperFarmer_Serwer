using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFarmer_Serwer.Models
{
    public class Player
    {
        
        public long Id { get; set; }
        public string PlayerName { get; set; }
        public int NumberOfRabbit { get; set; }
        public int NumberOfSheep { get; set; }
        public int NumberOfPig { get; set; }
        public int NumberOfCow { get; set; }
        public int NumberOfHorse { get; set; }
        public int NumberOfDog { get; set; }
        public int NumberOfBigDog { get; set; }
    }
}
