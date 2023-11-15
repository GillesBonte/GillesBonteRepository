using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameBehavioralPatterrn.Models
{
    public class Spell : Card
    {
        public Spell(int damage, int cost, string name)
        {
            Damage = damage;
            Cost = cost;
            Name = name;
        }

        public int Damage { get; set; }
    }
}
