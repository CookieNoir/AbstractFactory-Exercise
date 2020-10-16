namespace Goblin_Army
{
    public class Rogue : Entity
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "_R";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Wooden Knife";
        }

        protected override void SetArmorType()
        {
            armorType = "Torn Leather";
        }
    }
}
