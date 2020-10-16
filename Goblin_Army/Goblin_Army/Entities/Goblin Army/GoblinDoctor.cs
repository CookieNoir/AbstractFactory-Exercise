namespace Goblin_Army
{
    class GoblinDoctor : Doctor
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "GD";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Golden Healing Staff";
        }
    }
}
