using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase DragonTest, dentro de esta se van a verificar los metodos que el personaje DarkElf tiene.
    /// </summary>
    public class DarkElfTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al DarkElf
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {

            DarkElf darkElf = new DarkElf("darkElf");

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);

            darkElf.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(68, darkElf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al DarkElf
        /// </summary>
        [Test]
        public void CureTest()
        {

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);

            DarkElf darkElf = new DarkElf("darkElf");


            darkElf.ReceiveAttack(dwarf.AttackValue);
            darkElf.Cure();
            Assert.AreEqual(100, darkElf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del DarkElf.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            DarkElf darkElf = new DarkElf("darkElf");

            Bow bow = new Bow();
            Shield shield = new Shield();
            darkElf.AddItem(bow);
            darkElf.AddItem(shield);

            Assert.AreEqual(40, darkElf.AttackValue);
            Assert.AreEqual(32, darkElf.DefenseValue);
        }
        /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character DarkElf.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            DarkElf darkElf = new DarkElf("darkElf");

            Bow bow = new Bow();
            darkElf.AddItem(bow);

            Assert.AreEqual(40, darkElf.AttackValue);
            darkElf.RemoveItem(bow);

            Assert.AreEqual(25, darkElf.AttackValue);
        }
    }
}