using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Character 
    {
        private int health = 100;

        public List<IItem> items{get;private set;}

        public string Name { get; set; }
        
        public virtual int AttackValue
        {
            get
            {
                return this.AttackValue;
            }
        }

        public virtual int DefenseValue
        {
            get
            {
                return this.DefenseValue;
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
            if (this.items == null) 
            {
                this.items = new List<IItem>();
            }
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}