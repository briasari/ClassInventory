using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    internal class Player
    {
        //class attributes
        public string name, age, team, position;

        //constructor method
        public Player(string _name, string _age, string _team, string _position)
        {
            name = _name;
            age = _age;
            team = _team;
            position = _position;

        }

    }
}
