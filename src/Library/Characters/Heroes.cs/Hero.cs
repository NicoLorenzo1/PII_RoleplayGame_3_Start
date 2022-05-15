using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Hero : Character
    {
        public static List<Hero> heroesList = new List<Hero>();

        public void AddHero(Character heroe)
        {
            heroesList.Add(heroe as Hero);
        }
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