using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Interfaces
{
    public interface IRpg
    {
        public int Level { get; set; }
        public int WantedLevel { get; set; }

        public int LeftLevel()
        {
            return WantedLevel - Level;
        }
    }
}
