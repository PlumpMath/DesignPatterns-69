using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Legions;

namespace AbstractFactoryPattern.Factories
{
    public interface ILegionFactory
    {
        ILegion CreateLegion(string legionType);
    }
}
