using System.Collections.Generic;
namespace RoleplayGame
{
    public class Orc : Enemy
    {

        public Orc(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Sword());
            this.victoryPoints = 30;
        }
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    value += item.AttackValue;
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    value += item.DefenseValue;
                }
                return value;
            }
        }
    }
}