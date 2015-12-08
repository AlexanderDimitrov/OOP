using System;
using System.Text;
using RPG_Game.Interfaces;


namespace RPG_Game.Characters
{
    public abstract class Character:IAttack
    {

        public Character(string name)
        {
            this.Name = name;



        }
        public Character()
        {

        }
        public string Name { get; set; }
        private class ClassType
        {
            public ClassType()
            {
                
            }
        }
    }
}