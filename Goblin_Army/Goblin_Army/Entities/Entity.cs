using System;

namespace Goblin_Army
{
    public class Entity
    {
        public string veryShortDescription;
        protected string weapon;
        protected string armorType;

        protected Entity()
        {
            SetVeryShortDescription();
            SetBasicWeapon();
            SetArmorType();
        }

        public void Action(int dice_value)
        {
            Console.WriteLine(veryShortDescription + " makes turn and rolls " + dice_value + ":");
            if (dice_value > 3)
            {
                Console.WriteLine("-Deals 0 damage using " + weapon + "... 'Cause this is a peaceful game;");
            }
            else
            {
                Console.WriteLine("-Misses... 'Cause doesn't know how to handle " + weapon + ";");
            }
            Console.WriteLine("-Stays in " + armorType + " armor and waits for the next turn.\n");
        }

        protected virtual void SetVeryShortDescription()
        {
            veryShortDescription = "_E";
        }

        protected virtual void SetBasicWeapon()
        {
            weapon = "Wooden Stick";
        }

        protected virtual void SetArmorType()
        {
            armorType = "missing";
        }
    }
}
