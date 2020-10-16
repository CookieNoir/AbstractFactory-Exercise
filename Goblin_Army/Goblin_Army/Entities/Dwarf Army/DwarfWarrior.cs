namespace Goblin_Army
{
    class DwarfWarrior : Warrior
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "DW";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Mythril Hammer";
        }
    }
}
