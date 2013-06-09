using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public interface ICharacter
    {
        IWeapon Weapon { get; set; }
        void Fight();
    }
}