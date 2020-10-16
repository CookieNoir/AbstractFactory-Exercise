namespace Goblin_Army
{
    interface IArmyFactory
    {
        Entity GetWarrior();
        Entity GetRogue();
        Entity GetMage();
        Entity GetDoctor();
    }
}
