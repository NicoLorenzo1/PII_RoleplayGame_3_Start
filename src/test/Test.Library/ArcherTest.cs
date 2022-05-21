using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase ArcherTest, dentro de esta se van a verificar los metodos que el personaje Archer tiene.
    /// </summary>
    public class ArcherTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Archer
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);
            //Con esto el dwarf tiene 2 axe. 1 creado de base y otro creado con Axe axe = new Axe() y luego AddItem(axe)

            Archer archer = new Archer("Legolas");
        
            
            //archer por defecto tiene un casco puesto. Por lo que tiene 18 de armor
            //2 axe = 50, 50-18=32, 100-32=68
            

            archer.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(68, archer.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Archer
        /// </summary>
        [Test]
        public void CureTest()
        {
            Archer archer = new Archer("Legolas");

            Dwarf dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            dwarf.AddItem(axe);
            

            archer.ReceiveAttack(dwarf.AttackValue);
            archer.Cure();
            Assert.AreEqual(100, archer.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Archer.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Archer archer = new Archer("Legolas");
            Bow bow = new Bow();
            Shield shield = new Shield();
            archer.AddItem(bow);
            archer.AddItem(shield);

            Assert.AreEqual(30, archer.AttackValue);
            Assert.AreEqual(32, archer.DefenseValue);
        }
                /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character Archer.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            Archer archer = new Archer("Legolas");
            Bow bow = new Bow();
            Shield shield = new Shield();
            archer.AddItem(bow);
            archer.AddItem(shield);
        
            Assert.AreEqual(30, archer.AttackValue);
            archer.RemoveItem(bow);

            Assert.AreEqual(15, archer.AttackValue);
            Assert.AreEqual(32, archer.DefenseValue);
        }
    }
}