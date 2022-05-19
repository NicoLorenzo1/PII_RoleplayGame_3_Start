using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase OrcTest, dentro de esta se van a verificar los metodos que el personaje Orc tiene.
    /// </summary>
    public class OrcTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Orc
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Archer archer = new Archer("Legolas");
            Bow arco = new Bow();
            archer.AddItem(arco);
            //Con esto el arquero tiene 2 arcos. 1 creado de base y otro creado con Bow arco = new Bow() y luego AddItem(arco)

            Orc orc = new Orc("orc");
            //dwarf por defecto tiene un casco puesto. Por lo que tiene 18 de armor
            //2 arcos = 30, 30-18=12, 100-12=88


            orc.ReceiveAttack(archer.AttackValue);
            Assert.AreEqual(70, orc.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Orc
        /// </summary>
        [Test]
        public void CureTest()
        {
            Archer archer = new Archer("Legolas");
            Bow arco = new Bow();
            archer.AddItem(arco);

            Orc orc = new Orc("orc");


            orc.ReceiveAttack(archer.AttackValue);
            orc.Cure();
            Assert.AreEqual(100, orc.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Orc.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Orc orc = new Orc("orc");
            Axe axe = new Axe();
            Shield shield = new Shield();
            orc.AddItem(axe);
            orc.AddItem(shield);

            Assert.AreEqual(70, orc.AttackValue);
            Assert.AreEqual(14, orc.DefenseValue);
        }
        /// <summary>
        /// Test que se encarga de verificar si se puede remover items que ya fueron añadidos a un character Orc.
        /// </summary>
        [Test]
        public void RemoveItemTest()
        {
            Orc orc = new Orc("orc");
            Axe axe = new Axe();
            Shield shield = new Shield();
            orc.AddItem(axe);
            orc.AddItem(shield);

            Assert.AreEqual(70, orc.AttackValue);
            orc.RemoveItem(axe);

            Assert.AreEqual(45, orc.AttackValue);
            Assert.AreEqual(14, orc.DefenseValue);
        }

    }
}