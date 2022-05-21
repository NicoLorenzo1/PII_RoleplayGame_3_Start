using System.Collections.Generic;

namespace RoleplayGame
{
    /// <summary>
    /// Modificamos esta clase para que pueda heredar de Hero pero poder implementar los metodos de AddItem y RemoveItem en
    /// los items mágicos en los personajes mágicos.
    /// </summary>
    public class MagicCharacter : Hero
    {
        public List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public void AddItem(IMagicalItem item)
        {
            {
                if (this.magicalItems == null)
                {
                    this.magicalItems = new List<IMagicalItem>();
                }
                this.magicalItems.Add(item);
            }
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    }
}


