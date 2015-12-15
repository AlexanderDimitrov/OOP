namespace Battleships.Ships
{
    using System;

    public class CargoShip : Ship
    {
        
        public CargoShip(string name, double lengthInMetters, double volume,bool IsDestroyed):base(name,lengthInMetters,volume,IsDestroyed)
        {
            this.IsDestroyed = false;
          
        }

      
         
    }
}
