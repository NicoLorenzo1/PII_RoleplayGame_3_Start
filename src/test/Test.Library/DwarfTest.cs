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
            Archer archer = new Archer("Legolas");
            Bow arco = new Bow();
            archer.AddItem(arco);
            //Con esto el arquero tiene 2 arcos. 1 creado de base y otro creado con Bow arco = new Bow() y luego AddItem(arco)

            Dwarf dwarf = new Dwarf("Gimli");
            //dwarf por defecto tiene un casco puesto. Por lo que tiene 18 de armor
            //2 arcos = 30, 30-18=12, 100-12=88

            dwarf.ReceiveAttack(archer.AttackValue);
            Assert.AreEqual(88, dwarf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Dwarf
        /// </summary>
        [Test]
        public void CureTest()
        {
            Archer archer = new Archer("Legolas");
            Bow arco = new Bow();
            archer.AddItem(arco);

            Dwarf dwarf = new Dwarf("Gimli");
            

            dwarf.ReceiveAttack(archer.AttackValue);
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
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            dwarf.AddItem(axe);
            dwarf.AddItem(shield);

            Assert.AreEqual(50, dwarf.AttackValue);
            Assert.AreEqual(32, dwarf.DefenseValue);
        }
        /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character Dwarf.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            Axe axe = new Axe();
            Shield shield = new Shield();
            dwarf.AddItem(axe);
            dwarf.AddItem(shield);
        
            Assert.AreEqual(50, dwarf.AttackValue);
            dwarf.RemoveItem(axe);

            Assert.AreEqual(25, dwarf.AttackValue);
            Assert.AreEqual(32, dwarf.DefenseValue);
        }
        
    }
}