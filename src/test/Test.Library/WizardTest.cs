using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase WizardTest, dentro de esta se van a verificar los metodos que el personaje Wizard tiene.
    /// </summary>
    public class WizardTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Wizard
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Wizard gandalf = new Wizard("Gandalf");
            //El wizard tiene equipado un staff por defecto, por lo que su 
            //DefenseValue es 100 (por alguna razón)

            Archer lurtz = new Archer("Lurtz");
            Staff staff1 = new Staff();
            lurtz.AddItem(staff1);
            //Para este test es necesario que se le haga daño al personaje Wizard 
            //por lo que se le agrega un arma al Archer para que lo logre
            
            gandalf.ReceiveAttack(lurtz.AttackValue);
            Assert.AreEqual(85, gandalf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Wizard
        /// </summary>
        [Test]
        public void CureTest()
        {
            Wizard gandalf = new Wizard("Gandalf");

            Archer lurtz = new Archer("Lurtz");
            Staff staff1 = new Staff();
            lurtz.AddItem(staff1);

            gandalf.ReceiveAttack(lurtz.AttackValue);
            gandalf.Cure();
            Assert.AreEqual(100, gandalf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Wizard.
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