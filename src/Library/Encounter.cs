using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<Hero> heroesList = Hero.heroesList;
        private List<Enemy> enemiesList = Enemy.enemiesList;

        public void DoEncounter()
        {
            if (Hero.heroesList.Count == 0)
            {
                Console.WriteLine("No hay suficiente cantidad de heroes para comenzar un encuentro");
            }
            else if (enemiesList.Count == 0)
            {
                Console.WriteLine("No hay suficiente cantidad de villanos para comenzar un encuentro");
            }
            else
            {
                Console.WriteLine($"Un encuentro ha comenzado. Hay {heroesList.Count} heroes y {enemiesList.Count} villanos.");

                while (!AllHeroesAreDead() && !AllEnemiesAreDead())
                {
                    int j;
                    for (int i = 0; i < enemiesList.Count; i++)
                    {
                        if (AllHeroesAreDead())
                        {
                            break;
                        }

                        Enemy villian = enemiesList[i];
                        if (!(villian.Health > 0))
                        {
                            continue;
                        }

                        j = i;

                        while (j >= heroesList.Count || !(heroesList[j].Health > 0))
                        {
                            if (j == 0)
                            {
                                j = heroesList.Count;
                            }
                            j--;
                        }

                        Hero hero = heroesList[j];
                        Console.WriteLine($"El villano {villian.Name} ataca a {hero.Name}.");
                        hero.ReceiveAttack(villian.AttackValue);
                        if (!(hero.Health > 0))
                        {
                            Console.WriteLine($"{villian.Name} ha matado a {hero.Name}");
                        }
                    }
                    // Ahora los heroes que quedaron vivos atacan a los enemigos.
                    // Todos los heroes sobrevivientes atacan a cada enemigo 1 vez.
                    foreach (Hero hero in heroesList)
                    {
                        if (AllEnemiesAreDead() || AllHeroesAreDead())
                        {
                            break;
                        }
                        if (!(hero.Health > 0))
                        {
                            continue;
                        }

                        foreach (Enemy villian in enemiesList)
                        {
                            if (!(villian.Health > 0))
                            {
                                continue;
                            }

                            Console.WriteLine($"El heroe {hero.Name} ataca a {villian.Name}.");
                            villian.ReceiveAttack(hero.AttackValue);

                            if (!(villian.Health > 0))
                            {
                                Console.WriteLine($"{hero.Name} ha matado a {villian.Name}");
                                hero.AddVictoryPoints(villian.ReturnVictoryPoints());
                                if (hero.ReturnVictoryPoints() > 5)
                                {
                                    Console.WriteLine($"Se ha curado a {hero.Name} por tener mas de 5 VP");
                                    hero.ResetVictoryPoints();
                                    hero.Cure();
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("El encuentro ha terminado");

            if (AllEnemiesAreDead())
            {
                Console.WriteLine("Los heroes han ganado el encuentro.");
            }
            else
            {
                Console.WriteLine("Los enemigos han ganado el encuentro.");
            }
        }
        public bool AllHeroesAreDead()
        {
            foreach (Hero hero in heroesList)
            {
                if (hero.Health > 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool AllEnemiesAreDead()
        {
            foreach (Enemy enemy in enemiesList)
            {
                if (enemy.Health > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}