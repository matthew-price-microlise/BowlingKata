using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGroup2.Models
{
    class Player
    {
        public string Name { get; set; }
        public List<int> Scores = new List<int>();

        public Player(string name)
        {
            this.Name = name;
        }

        public void AddScore(int roundScore)
        {
            Scores.Add(roundScore);
        }

    }
}
