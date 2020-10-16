namespace Goblin_Army
{
    class DwarfMage : Mage
    {
        protected override void SetVeryShortDescription()
        {
            veryShortDescription = "DM";
        }

        protected override void SetBasicWeapon()
        {
            weapon = "Mythril Skullbreaker (Dwarfs don't use magic)";
        }
    }
}
