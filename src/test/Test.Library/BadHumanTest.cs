using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase BadHumanTest, dentro de esta se van a verificar los metodos que el personaje badHuman tiene.
    /// </summary>
    public class BadHumanTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al BadHuman
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            BadHuman badHuman = new BadHuman("badHuman");

            Archer lurtz = new Archer("Lurtz");
            Sword sword = new Sword();

            lurtz.AddItem(sword);

            badHuman.ReceiveAttack(lurtz.AttackValue);
            Assert.AreEqual(83, badHuman.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al BadHuman
        /// </summary>
        [Test]
        public void CureTest()
        {
            BadHuman badHuman = new BadHuman("badHuman");

            Archer lurtz = new Archer("Lurtz");
            Sword sword = new Sword();

            lurtz.AddItem(sword);

            badHuman.ReceiveAttack(lurtz.AttackValue);
            badHuman.Cure();
            Assert.AreEqual(100, badHuman.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del badHuman.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            BadHuman badHuman = new BadHuman("badHuman");

            Assert.AreEqual(25, badHuman.AttackValue);
            Assert.AreEqual(18, badHuman.DefenseValue);
        }

        /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character badHuman.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            BadHuman badHuman = new BadHuman("badHuman");

            Axe axe = new Axe();
            Shield shield = new Shield();

            badHuman.AddItem(axe);
            badHuman.AddItem(shield);

            Assert.AreEqual(50, badHuman.AttackValue);

            badHuman.RemoveItem(axe);
            badHuman.RemoveItem(shield);

            Assert.AreEqual(25, badHuman.AttackValue);
            Assert.AreEqual(18, badHuman.DefenseValue);
        }
    }
}