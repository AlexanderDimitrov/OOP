namespace Battleships.Ships
{
    using System;

    public class Destroyer : BattleShip,IAttack
    {
        private int numberOfAmmunition;

        public Destroyer(string name, double lengthInMeters, double volume, int numberOfAmmunition,bool IsDestroyed)
            :base(name,lengthInMeters,volume,IsDestroyed)
        {
            this.IsDestroyed = false;
            this.NumberOfAmmunition = numberOfAmmunition;
          
        }

       

        public int NumberOfAmmunition
        {
            get
            {
                return this.numberOfAmmunition;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The number of ammunition in a destroyer cannot be negative.");
                }

                this.numberOfAmmunition = value;
            }
        }

        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "We swiped them away";
        }
    }
}
