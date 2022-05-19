using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase DragonTest, dentro de esta se van a verificar los metodos que el personaje Dragon tiene.
    /// </summary>
    public class DragonTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Dragon
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);
            //Con esto el dwarf tiene 2 axe. 1 creado de base y otro creado con Axe axe = new Axe() y luego AddItem(axe)

            Dragon dragon = new Dragon("dragon");

            dragon.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(68, dragon.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Dragon
        /// </summary>
        [Test]
        public void CureTest()
        {

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);

            Dragon dragon = new Dragon("dragon");


            dragon.ReceiveAttack(dwarf.AttackValue);
            dragon.Cure();
            Assert.AreEqual(100, dragon.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Dragon.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Dragon dragon = new Dragon("dragon");

            Bow bow = new Bow();
            Shield shield = new Shield();
            dragon.AddItem(bow);
            dragon.AddItem(shield);

            Assert.AreEqual(40, dragon.AttackValue);
            Assert.AreEqual(32, dragon.DefenseValue);
        }
        /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character Dragon.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            Dragon dragon = new Dragon("dragon");
            
            Bow bow = new Bow();
            dragon.AddItem(bow);

            Assert.AreEqual(40, dragon.AttackValue);
            dragon.RemoveItem(bow);

            Assert.AreEqual(25, dragon.AttackValue);
        }
    }
}