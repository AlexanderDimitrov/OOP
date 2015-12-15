namespace Battleships.Ships
{
    using System;

    public class Warship : BattleShip,IAttack
    {
        

        public Warship(string name, double lengthInMeters, double volume,bool IsDestroyed):base(name,lengthInMeters,volume,IsDestroyed)
        {
            this.IsDestroyed = false;
            
        }

        

        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "You got Warrshipped";
        }
    }
}
