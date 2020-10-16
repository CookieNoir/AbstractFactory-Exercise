namespace Goblin_Army
{
    class BasicArmyFactory : IArmyFactory
    {
        public Entity GetWarrior()
        {
            return new Warrior();
        }
        public Entity GetRogue()
        {
            return new Rogue();
        }
        public Entity GetMage()
        {
            return new Mage();
        }
        public Entity GetDoctor()
        {
            return new Doctor();
        }
    }
}
