using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase KnightTest, dentro de esta se van a verificar los metodos que el personaje Knight tiene.
    /// </summary>
    public class KnightTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Knight
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Knight boromir = new Knight("Boromir");

            Archer lurtz = new Archer("Lurtz");
            
            boromir.ReceiveAttack(lurtz.AttackValue);
            Assert.AreEqual(100, boromir.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Knight
        /// </summary>
        [Test]
        public void CureTest()
        {
            Knight boromir = new Knight("Boromir");

            Archer lurtz = new Archer("Lurtz");

            boromir.ReceiveAttack(lurtz.AttackValue);
            boromir.Cure();
            Assert.AreEqual(100, boromir.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Knight.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Knight boromir = new Knight("Boromir");

            Assert.AreEqual(20, boromir.AttackValue);
            Assert.AreEqual(39, boromir.DefenseValue);
        }
    }
}