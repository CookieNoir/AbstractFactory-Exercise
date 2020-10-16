namespace Goblin_Army
{
    class DwarfDoctor : Doctor
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "DD";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Doctor Rifle (Dwarfs don't use magic)";
        }
    }
}
