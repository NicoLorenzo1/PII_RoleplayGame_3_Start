using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Hero : Character
    {



        protected int victoryPointsCounter { get; set; }

        public void AddVictoryPoints(int vp)
        {
            this.victoryPointsCounter += vp;
        }
        public int ReturnVictoryPoints()
        {
            return this.victoryPointsCounter;
        }
        public void ResetVictoryPoints()
        {
            this.victoryPointsCounter = 0;
        }
    }
}