namespace Goblin_Army
{
    class GoblinArmyFactory : IArmyFactory
    {
        public Entity GetWarrior()
        {
            return new GoblinWarrior();
        }
        public Entity GetRogue()
        {
            return new GoblinRogue();
        }
        public Entity GetMage()
        {
            return new GoblinMage();
        }
        public Entity GetDoctor()
        {
            return new GoblinDoctor();
        }
    }
}
