using System.Collections.Generic;
namespace RoleplayGame
{
    public class Orc : Enemy
    {
        private List<IItem> items = new List<IItem>();

        public Orc(string name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Sword());
            this.victoryPoints = 30;
        }
    }
}