using System.Collections.Generic;

namespace RoleplayGame
{
    public class Enemy : Character
    {
        public static List<Enemy> enemiesList = new List<Enemy>();

        public void AddEnemy(Character enemy)
        {
            enemiesList.Add(enemy as Enemy);
        }
        protected int victoryPoints { get; set; }

        public int ReturnVictoryPoints()
        {
            return this.victoryPoints;
        }
    }
}