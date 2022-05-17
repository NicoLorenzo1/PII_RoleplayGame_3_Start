using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Hero, IMagicCharacter
    {
        private List<IItem> items = new List<IItem>();

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;
            this.AddItem(new Staff());
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
        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}
