﻿namespace Battleships
{
    using System;
    using System.Collections.Generic;
    using Ships;

    public class Engine
    {
        private static readonly Random Rand = new Random();
        private readonly List<Ship> ships = new List<Ship>();

        public void Run()
        {
            this.PopulateShips();

            for (int i = 0; i < 5; i++)
            {
                string attackResult = this.SimulateAttack();

                Console.WriteLine(attackResult);
            }
        }

        private void PopulateShips()
        {
            ships.AddRange(new Ship[]
            {
                new AircraftCarrier("Omaha", 1500, 50,65,false),
                new CargoShip("Jersey", 55, 250,false),
                new Destroyer("York", 155, 2100, 700,false),
                new Warship("Vegas", 210, 2400,false),
                new Yacht("Minie", 15, 200,false), 
            });
        }

        private string SimulateAttack()
        {
            int attackerIndex = Rand.Next(0, this.ships.Count);
            int defenderIndex = Rand.Next(0, this.ships.Count);

            while (defenderIndex == attackerIndex)
            {
                defenderIndex = Rand.Next(0, this.ships.Count);
            }

            Ship attacker = this.ships[attackerIndex];
            Ship defender = this.ships[defenderIndex];
            if (!(attacker is IAttack))
            {
                return "Attacking ship cannot attack others.";
            }
            
            if (attacker.IsDestroyed)
            {
                return "Attacking ship is destroyed.";
            }

            if (defender.IsDestroyed)
            {
                return "Defending ship is already destroyed.";
            }
            IAttack attackingShip = (IAttack)attacker;
            return attackingShip.Attack(defender);
        }
    }
}
