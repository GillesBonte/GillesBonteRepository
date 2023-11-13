using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameBehavioralPatterrn.Models;

namespace CardGameBehavioralPatterrn.DAL
{
    public class CardContext : DbContext
    {
        public CardContext() : base("MinionDB")
        {
        }

        public DbSet<Minion> Minions { get; set;}

    }

}
