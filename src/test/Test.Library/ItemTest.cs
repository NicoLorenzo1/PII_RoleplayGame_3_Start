using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    /// <summary>
    /// Clase ItemTest donde se testean los metodos que tienen todos los items.
    /// </summary>
    public class ItemTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArmorReturnDefenseTest()
        {
            IItem armor = new Armor();
            Assert.AreEqual(25, armor.DefenseValue);
        }

        [Test]
        public void AxeReturnDefenseTest()
        {
            IItem axe = new Axe();
            Assert.AreEqual(0, axe.DefenseValue);
        }

        [Test]
        public void BowReturnDefenseTest()
        {
            IItem bow = new Bow();
            Assert.AreEqual(0, bow.DefenseValue);
        }

        [Test]
        public void HelmetReturnDefenseTest()
        {
            IItem helmet = new Helmet();
            Assert.AreEqual(18, helmet.DefenseValue);
        }

        [Test]
        public void ShieldReturnDefenseTest()
        {
            IItem shield = new Shield();
            Assert.AreEqual(14, shield.DefenseValue);
        }

        [Test]
        public void SpellReturnDefenseTest()
        {
            ISpell spell = new SpellOne();
            Assert.AreEqual(70, spell.DefenseValue);
        }

        [Test]
        public void SpellsBookReturnDefenseTest()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpell spell = new SpellOne();
            spellsBook.AddSpell(spell);
            Assert.AreEqual(spell.DefenseValue, spellsBook.DefenseValue);
        }

        [Test]
        public void StaffReturnDefenseTest()
        {
            IItem staff = new Staff();
            Assert.AreEqual(100, staff.DefenseValue);
        }

        [Test]
        public void SwordReturnDefenseTest()
        {
            IItem sword = new Sword();
            Assert.AreEqual(0, sword.DefenseValue);
        }

        [Test]
        public void ArmorReturnAttackTest()
        {
            IItem armor = new Armor();
            Assert.AreEqual(0, armor.AttackValue);
        }

        [Test]
        public void SpellReturnAttackTest()
        {
            ISpell spell = new SpellOne();
            Assert.AreEqual(70, spell.AttackValue);
        }

        [Test]
        public void AxeReturnAttackTest()
        {
            IItem axe = new Axe();
            Assert.AreEqual(25, axe.AttackValue);
        }

        [Test]
        public void BowReturnAttackTest()
        {
            IItem bow = new Bow();
            Assert.AreEqual(15, bow.AttackValue);
        }

        [Test]
        public void HelmetReturnAttackTest()
        {
            IItem helmet = new Helmet();
            Assert.AreEqual(0, helmet.AttackValue);
        }

        [Test]
        public void ShieldReturnAttackTest()
        {
            IItem shield = new Shield();
            Assert.AreEqual(0, shield.AttackValue);
        }

        [Test]
        public void SpellsBookReturnAttackTest()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpell spell = new SpellOne();
            spellsBook.AddSpell(spell);
            Assert.AreEqual(spell.AttackValue, spellsBook.AttackValue);
        }

        [Test]
        public void StaffReturnAttackTest()
        {
            IItem staff = new Staff();
            Assert.AreEqual(100, staff.AttackValue);
        }

        [Test]
        public void SwordReturnAttackTest()
        {
            IItem sword = new Sword();
            Assert.AreEqual(20, sword.AttackValue);
        }

    }
}