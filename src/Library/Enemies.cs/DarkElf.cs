using System.Collections.Generic;
namespace RoleplayGame
{
    public class DarkElf : Enemy
    {
        private List<IItem> items = new List<IItem>();

        public DarkElf(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.AddEnemy(this);
            this.victoryPoints = 25;
        }
    }
}