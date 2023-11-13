using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameBehavioralPatterrn.DAL;
using CardGameBehavioralPatterrn.Models;

namespace CardGameBehavioralPatterrn.Repos
{

    public class Card_Repo_EF
    {
        private CardContext _ccController;

        public Card_Repo_EF()
        {
            _ccController = new CardContext();
        }

        public List<Minion> GetAll()
        {
            return _ccController.Minions.ToList<Minion>();
        }

        public void Create()
        {
            _ccController.Minions.Add(new Minion(2, 2, 1, "Beast"));
            _ccController.Minions.Add(new Minion(3, 1, 1, "Murloc"));
            _ccController.Minions.Add(new Minion(1, 3, 1, "Pirate"));
            _ccController.Minions.Add(new Minion(5, 2, 2, "Elemental"));
            _ccController.Minions.Add(new Minion(2, 5, 2, "Naga"));
            _ccController.Minions.Add(new Minion(6, 5, 3, "Undead"));
            _ccController.Minions.Add(new Minion(8, 1, 3, "Demon"));
            _ccController.Minions.Add(new Minion(6, 10, 4, "Amalgam"));
            _ccController.Minions.Add(new Minion(8, 12, 5, "Gilles"));
            _ccController.SaveChanges();
        }

    }

}
