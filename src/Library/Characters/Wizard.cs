using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : IMagicCharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;

            this.AddItem(new Staff());
        }

        public string Name { get; set; }

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

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
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