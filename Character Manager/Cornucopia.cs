using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class Cornucopia
    {
        public int Id { get; set; }
        public DateTime StartOfProduction { get; set; }
        public int AmountDaysOfProduction { get; set; }
        public string Product { get; set; }
    }
}
