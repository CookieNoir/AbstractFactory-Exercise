namespace Goblin_Army
{
    public class Doctor : Entity
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "_D";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Wooden Healing Staff";
        }

        protected override void SetArmorType()
        {
            armorType = "Heavy Magic";
        }
    }
}
