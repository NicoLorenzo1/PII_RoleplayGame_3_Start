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
            IDefenseItem armor = new Armor();
            Assert.AreEqual(25, armor.DefenseValue);
        }

        [Test]
        public void HelmetReturnDefenseTest()
        {
            IDefenseItem helmet = new Helmet();
            Assert.AreEqual(18, helmet.DefenseValue);
        }

        [Test]
        public void ShieldReturnDefenseTest()
        {
            IDefenseItem shield = new Shield();
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
            IDefenseItem staff = new Staff();
            Assert.AreEqual(100, staff.DefenseValue);
        }

        [Test]
        public void StaffReturnAttackTest()
        {
            IAttackItem staff = new Staff();
            Assert.AreEqual(100, staff.AttackValue);
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
            IAttackItem axe = new Axe();
            Assert.AreEqual(25, axe.AttackValue);
        }

        [Test]
        public void BowReturnAttackTest()
        {
            IAttackItem bow = new Bow();
            Assert.AreEqual(15, bow.AttackValue);
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
        public void SwordReturnAttackTest()
        {
            IAttackItem sword = new Sword();
            Assert.AreEqual(20, sword.AttackValue);
        }

    }
}