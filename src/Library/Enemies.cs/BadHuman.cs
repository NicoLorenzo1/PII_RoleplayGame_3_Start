using System.Collections.Generic;
namespace RoleplayGame
{
    public class BadHuman : Enemy
    {
        //private List<IItem> items = new List<IItem>();

        public BadHuman(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.victoryPoints = 25;
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