using AbstractFactoryPattern.Legions;

namespace AbstractFactoryPattern.Factories
{
    public interface IFactionFactory
    {
        ILegion Legion { get; set; }
        void RecruitInfantry();
        void RecruitAuxiliary();
        void RecruitReconnaissance();
        void RecruitBattery();
        void RecruitAeronautical();
        void RecruitKnights();
    }
}