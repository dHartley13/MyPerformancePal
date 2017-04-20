using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{
    public class Game
    {
        //Use GameDb interface
        private readonly IGameDb _db;

        public Game(IGameDb db)
        {
            _db = db;
        }

        //Constructor
        public Game()
        {
            _db = new Gamedb();
        }

        //Properties
        public int GameId { get; private set; }

        private Dictionary<int, int> _stats;


        //public functions
        public void StartGame()
        {
            GameId = _db.CreateGame();
            _stats = new Dictionary<int, int>();
        }

        public void RecordAction(int actionType, string chosenAction)
        {

            if (GameId == 0)
            {
                throw new InvalidOperationException("Cannot record an action as the game has not started");
            }
            else
            {
                _db.SaveAction(actionType, chosenAction, GameId);
                RecordStats(actionType);
            }

        }

        public ReadOnlyDictionary<int, int> GetStats()
        {
            return new ReadOnlyDictionary<int, int>(_stats);
        }


        //private function
        private void RecordStats(int actionType)
        {
            if (_stats.ContainsKey(actionType))
                _stats[actionType] = _stats[actionType] + 1;
            else
                _stats.Add(actionType, 1);
        }
    }
}

