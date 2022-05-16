using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase DwarfTest, dentro de esta se van a verificar los metodos que el personaje Dwarf tiene.
    /// </summary>
    public class DwarfTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Dwarf
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            
            Wizard gandalf = new Wizard("Gandalf");
            

            dwarf.ReceiveAttack(gandalf.AttackValue);
            Assert.AreEqual(0, dwarf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Dwarf
        /// </summary>
        [Test]
        public void CureTest()
        {
            Wizard gandalf = new Wizard("Gandalf");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            gandalf.AttackEnemy(dwarf);
            dwarf.Cure();
            Assert.AreEqual(100, dwarf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Dwarf.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            Assert.AreEqual(50, dwarf.AttackValue);
            Assert.AreEqual(32, dwarf.DefenseValue);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AttackEnemy al momento en que el Dwarf ataca a otro personaje.
        /// </summary>
        [Test]
        public void AttackEnemyTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            Archer archer = new Archer("Archer");
            archer.Helmet = new Helmet();
            archer.Bow = new Bow();

            dwarf.AttackEnemy(archer);
            Assert.AreEqual(68, archer.Health);
        }
    }
}