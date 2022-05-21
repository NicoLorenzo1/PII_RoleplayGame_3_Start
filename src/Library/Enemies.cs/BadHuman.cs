
using System.Collections.Generic;
namespace RoleplayGame
{
    public class BadHuman : Enemy
    {
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
                    if (item is IAttackItem)
                    {
                        value += ((IAttackItem)item).AttackValue;
                    }

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
                    if (item is IDefenseItem)
                    {
                        value += ((IDefenseItem)item).DefenseValue;
                    }

                }
                return value;
            }
        }
    }
}