namespace Goblin_Army
{
    class GoblinMage : Mage
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "GM";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Golden Fire Staff";
        }
    }
}
