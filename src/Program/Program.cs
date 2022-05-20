using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            //Wizard gandalf = new Wizard("Gandalf");

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine(gimli.AttackValue);
            Console.WriteLine(gimli.DefenseValue);


            //gandalf.AddItem(book);
/*
            Dwarf gimli = new Dwarf("Gimli");
            Archer archer = new Archer("archer");
            Knight knight = new Knight("knight");
            BadHuman badHuman = new BadHuman("human");
            BadHuman badHuman1 = new BadHuman("human1");
            BadHuman badHuman2 = new BadHuman("human2");


            Encounter encounter = new Encounter();

            encounter.AddEnemy(badHuman);
            encounter.AddHero(gimli);
            encounter.AddEnemy(badHuman1);
            encounter.AddEnemy(badHuman2);
            encounter.AddHero(archer);
            encounter.AddHero(knight);
            encounter.DoEncounter();
*/
        }
    }
}
