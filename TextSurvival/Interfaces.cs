using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;

namespace TextSurvival
{
    public interface IGainable
    {
        void Gain(Player user);
        void Lose(Player user);
    }
    public interface IUsable
    {
        void Use(Player user);
    }
}
