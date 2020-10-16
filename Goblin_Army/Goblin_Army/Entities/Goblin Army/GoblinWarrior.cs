namespace Goblin_Army
{
    class GoblinWarrior : Warrior
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "GW";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Golden Sword";
        }
    }
}
