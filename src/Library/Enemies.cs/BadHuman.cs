using System.Collections.Generic;
namespace RoleplayGame
{
    public class BadHuman : Enemy
    {
        private List<IItem> items = new List<IItem>();

        public BadHuman(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.victoryPoints = 25;
        }
    }
}