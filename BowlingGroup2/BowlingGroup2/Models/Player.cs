using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGroup2.Models
{
    class Player
    {
        private string Name { get; set; }
        private List<int> Scores = new List<int>();

        public Player(string name)
        {
            this.Name = name;
        }
        
        public void AddScore(int frame, int roundScore)
        {
            Scores.Insert(frame, roundScore);
        
        }

    }
}
