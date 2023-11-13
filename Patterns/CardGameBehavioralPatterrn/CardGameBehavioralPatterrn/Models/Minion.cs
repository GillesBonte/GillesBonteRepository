using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameBehavioralPatterrn.Models
{
    public class Minion : Card
    {
        public Minion()
        {
        }

        public Minion(int attack, int defense, int cost, string name)
        {
            Attack = attack; 
            Defense = defense;
            Cost = cost;
            Name = name;
        }

        public int Attack { get; set; }
        public int Defense { get; set; }
    }

}
