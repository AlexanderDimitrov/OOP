using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Ships
{
    using Battleships;
    public interface IAttack
    {
        string Attack(Ship targetShip);
    }
}
