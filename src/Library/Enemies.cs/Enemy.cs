using System.Collections.Generic;

namespace RoleplayGame
{
    public class Enemy : Character
    {
        protected int victoryPoints { get; set; }

        public int ReturnVictoryPoints()
        {
            return this.victoryPoints;
        }
    }
}