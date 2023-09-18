using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Disk
    {
        public string? Name { get; set; }

        public int Volume { get; set; }
        
        public float FreeSpace { get; set; }

        public Disk(string? name, int volume, float freeSpace) 
        {
            Name = name;
            Volume = volume;
            FreeSpace = freeSpace;
        }
    }
}
