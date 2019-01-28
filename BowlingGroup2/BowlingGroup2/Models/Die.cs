using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGroup2.Models
{
    public static class Die
    {
        public static Random _ran = new Random();
        public static int GetNextBowl(int remainPinCount)
        {
            //To Account for the exclusive upper bound
            return _ran.Next(0, remainPinCount+1);
        }
    }
}
