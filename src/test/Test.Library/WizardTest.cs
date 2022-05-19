using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase KnightTest, dentro de esta se van a verificar los metodos que el personaje Knight tiene.
    /// </summary>
    public class WizardTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Knight
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Archer lurtz = new Archer("Lurtz");
            
            gandalf.ReceiveAttack(lurtz.AttackValue);
            Assert.AreEqual(100, gandalf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Knight
        /// </summary>
        [Test]
        public void CureTest()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Archer lurtz = new Archer("Lurtz");

            gandalf.ReceiveAttack(lurtz.AttackValue);
            gandalf.Cure();
            Assert.AreEqual(100, gandalf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Knight.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Assert.AreEqual(100, gandalf.AttackValue);
            Assert.AreEqual(100, gandalf.DefenseValue);
        }
    }
}