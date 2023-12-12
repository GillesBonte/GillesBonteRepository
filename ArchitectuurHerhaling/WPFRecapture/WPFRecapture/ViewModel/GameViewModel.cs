using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFRecapture.Model;

namespace WPFRecapture.ViewModel
{
    public class GameViewModel : VMBase
    {
        private Game _currentGame;
        public ObservableCollection<Game> Games { get; set; }

        public GameViewModel()
        {
            Games = new ObservableCollection<Game>();
            Games.Add(new Game() { Id=1,Name="GTA V",Genre="Action"});
            Games.Add(new Game() { Id = 2, Name = "Hearthstone", Genre = "Cardgame" });
            Games.Add(new Game() { Id = 3, Name = "Starcraft", Genre = "RTS" });

        }

        public Game CurrentGame
        {
            get
            {
                return _currentGame;
            }
            set
            {
                _currentGame = value;
                OnPropertyChanged("CurrentGame");
            }
        }


    }

}
