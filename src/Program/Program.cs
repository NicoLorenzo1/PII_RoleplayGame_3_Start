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

            Wizard gandalf = new Wizard("Gandalf");

            //gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");
            Archer archer = new Archer("archer");
            Knight knight = new Knight("knight");
            BadHuman badHuman = new BadHuman("human");
            BadHuman badHuman1 = new BadHuman("human1");
            BadHuman badHuman2 = new BadHuman("human2");



            Encounter encounter = new Encounter();
            Console.WriteLine(badHuman.AttackValue);
            Console.WriteLine(gimli.AttackValue);

            encounter.AddEnemy(badHuman);
            encounter.AddHero(gimli);
            encounter.DoEncounter();
        }
    }
}
