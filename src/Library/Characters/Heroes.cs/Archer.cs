using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : Hero
    {
        private List<IItem> items = new List<IItem>();

        public Archer(string name)
        {
            this.Name = name;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}