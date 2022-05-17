using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo AllHeroesAreDead y si queda algún heroe con vida, este retorna false.
        /// </summary>
        [Test]
        public void AllHeroesNotAreDeadTest()
        {
            Dwarf dwarf = new Dwarf("gimli");
            Encounter encounter1 = new Encounter();
            encounter1.AddHero(dwarf);

            Assert.AreEqual(false, encounter1.AllHeroesAreDead());
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AllEnemiesAreDead y si queda algún heroe con vida, este retorna false.
        /// </summary>
        /// </summary>
        [Test]
        public void AllenemiesNotAreDeadTest()
        {
            BadHuman badHuman = new BadHuman("batman");
            Encounter encounter1 = new Encounter();
            encounter1.AddEnemy(badHuman);

            Assert.AreEqual(false, encounter1.AllEnemiesAreDead());
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AllEnemiesAreDead y si no queda ningún enemigo con vida, este retorna true.
        /// </summary>
        [Test]
        public void AllEnemiesAreDeadTest()
        {
            BadHuman badHuman = new BadHuman("batman");

            Dwarf dwarf = new Dwarf("gimli");
            Staff staff = new Staff();
            dwarf.AddItem(staff);

            Encounter encounter1 = new Encounter();
            encounter1.AddEnemy(badHuman);
            encounter1.AddHero(dwarf);
            encounter1.DoEncounter();

            Assert.AreEqual(true, encounter1.AllEnemiesAreDead());
        }

        /// <summary>
        /// Test que se encarga de verificas el metodo AllHeroesAreDead y si no queda ningún heroe con vida, este retorna true.
        /// </summary>
        [Test]
        public void AllHeroesAreDeadTest()
        {
            BadHuman badHuman1 = new BadHuman("batman1");
            Staff staff = new Staff();
            badHuman1.AddItem(staff);

            Dwarf dwarf1 = new Dwarf("gimli1");

            Encounter encounter2 = new Encounter();
            encounter2.AddEnemy(badHuman1);
            encounter2.AddHero(dwarf1);
            encounter2.DoEncounter();

            Assert.AreEqual(true, encounter2.AllHeroesAreDead());
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AddEnemy de la clase Encounter, en este caso si este falla al agregar algun personaje,
        /// o la lista queda vacía, el metodo reconoce que no queda ningún enemigo con vida.
        /// </summary>
        [Test]
        public void EncounterAddEnemyTest()
        {
            BadHuman badHuman = new BadHuman("batman");
            Encounter encounter1 = new Encounter();
            encounter1.AddEnemy(badHuman);

            Assert.AreEqual(false, encounter1.AllEnemiesAreDead());
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AddHero de la clase Encounter, en este caso si este falla al agregar algun personaje,
        /// o la lista queda vacía, el metodo reconoce que no queda ningún heroe con vida.
        /// </summary>
        [Test]
        public void EncounterAddHeroTest()
        {
            Dwarf dwarf1 = new Dwarf("gimli1");
            Encounter encounter1 = new Encounter();
            encounter1.AddHero(dwarf1);

            Assert.AreEqual(false, encounter1.AllHeroesAreDead());
        }

    }
}
