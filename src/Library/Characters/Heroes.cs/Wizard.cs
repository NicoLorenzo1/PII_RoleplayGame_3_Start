using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Hero
    {
        private List<IItem> items = new List<IItem>();

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;
            this.AddItem(new Staff());
            this.AddHero(this);
        }


        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    value += item.AttackValue;
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    value += item.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    value += item.DefenseValue;
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    value += item.DefenseValue;
                }
                return value;
            }
        }
    }
}
