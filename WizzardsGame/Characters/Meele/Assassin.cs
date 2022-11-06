using WizzardsGame.Equipment.Armors.Leather;
using WizzardsGame.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizzardsGame.Characters.Meele
{
    public class Assassin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public string Faction { get; set; }
        public string Name { get; set; }

        public LightLeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }


        public Assassin()
        {

        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
