using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Gearscore { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public Character() { }

    }
}
