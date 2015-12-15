namespace Battleships.Ships
{
    using System;

    public class Yacht : Ship
    {
        

        public Yacht(string name, double lengthInMeters, double volume,bool IsDestroyed):base(name,lengthInMeters,volume,IsDestroyed)
        {
            this.IsDestroyed = false;
         
        }

        
    }
}
