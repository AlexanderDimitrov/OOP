namespace Battleships.Ships
{
    using System;

    public class AircraftCarrier : BattleShip
    {
         private int fighterCapacity;

        public AircraftCarrier(string name, double lengthInMetters, double volume, int fighterCapacity,bool IsDestroyed)
            :base(name,lengthInMetters,volume,IsDestroyed)
        {
           
            this.FighterCapacity = fighterCapacity;
           
            this.IsDestroyed = false;
        }

        
        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }

        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "We Bombed Them away";
        }
        

    }
}
