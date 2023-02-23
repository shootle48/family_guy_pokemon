using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_guy_pokemon.Pokemon
{
    internal class Peter : Pokemons
    {
        public Peter()
        {
            Random random = new Random();
            this.name = "Peter Griffin";
            this.hp = random.Next(100, 200);
            this._image = Properties.Resources._1;
            this.attack = random.Next(50, 100);
            this.defense = random.Next(75, 150);
        }
    }
}
