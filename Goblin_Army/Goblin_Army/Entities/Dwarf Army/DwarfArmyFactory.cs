namespace Goblin_Army
{
    class DwarfArmyFactory : IArmyFactory
    {
        public Entity GetWarrior()
        {
            return new DwarfWarrior();
        }
        public Entity GetRogue()
        {
            return new DwarfRogue();
        }
        public Entity GetMage()
        {
            return new DwarfMage();
        }
        public Entity GetDoctor()
        {
            return new DwarfDoctor();
        }
    }
}
