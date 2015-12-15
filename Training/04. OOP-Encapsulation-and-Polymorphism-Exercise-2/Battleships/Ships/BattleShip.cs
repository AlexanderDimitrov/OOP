using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Ships
{
    public abstract class BattleShip : Ship, IAttack

    {
        public BattleShip(string name,double lenghtInMetters,double volume,bool IsDestroyed):base(name,lenghtInMetters,volume,false)
        {
           
        }
        public abstract string Attack(Ship targetShip);
        protected void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
        

        
       
                    
           
        
    }
}
