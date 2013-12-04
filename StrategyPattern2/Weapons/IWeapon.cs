namespace StrategyPattern2.Weapons
{
    public interface IWeapon
    {
        string Name { get; set; }
        void UseWeapon();
    }
}