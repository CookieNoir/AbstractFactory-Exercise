namespace Goblin_Army
{
    public class Mage : Entity
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "_M";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Wooden Fire Staff";
        }

        protected override void SetArmorType()
        {
            armorType = "Light Magic";
        }
    }
}
