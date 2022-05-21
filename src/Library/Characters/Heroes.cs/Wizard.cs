
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : MagicCharacter
    {
        //private List<IMagicalItem> magicalItems = new List<IMagicalItem>();


        public Wizard(string name)
        {
            this.Name = name;
            this.AddItem(new Staff());
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

                foreach (IMagicalAttackItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += ((IMagicalAttackItem)item).AttackValue;
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
                foreach (IMagicalDefenseItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += ((IMagicalDefenseItem)item).DefenseValue;
                    }

                }
                return value;
            }
        }
    }
}