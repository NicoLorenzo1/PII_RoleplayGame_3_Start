namespace RoleplayGame
{
    public interface IMagicCharacter
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }

    /*
        public interface IMagicCharacter <T>
    {
        void AddItem(T item);

        void RemoveItem(T item);
    }*/
}
