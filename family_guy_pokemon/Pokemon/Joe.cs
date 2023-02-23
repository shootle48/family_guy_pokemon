using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_guy_pokemon.Pokemon
{
    internal class Joe : Pokemons
    {
        public Joe()
        {
            Random random = new Random();
            this.name = "Joe Swanson";
            this.hp = random.Next(100, 200);
            this._image = Properties.Resources._5;
            this.attack = random.Next(50, 100);
            this.defense = random.Next(75, 150);
        }
    }
}
