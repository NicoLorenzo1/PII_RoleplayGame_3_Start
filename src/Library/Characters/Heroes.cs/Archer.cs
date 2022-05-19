using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : Hero
    {
        //private List<IItem> items = new List<IItem>();

        public Archer(string name)
        {
            this.Name = name;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
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