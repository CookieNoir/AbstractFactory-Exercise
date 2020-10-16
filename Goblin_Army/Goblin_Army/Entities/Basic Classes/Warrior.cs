namespace Goblin_Army
{
    public class Warrior : Entity
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "_W";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Wooden Sword";
        }

        protected override void SetArmorType()
        {
            armorType = "Heavy and Shiny";
        }
    }
}
