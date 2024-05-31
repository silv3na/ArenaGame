namespace ArenaGame
{
    public abstract class Weapon
    {
        protected int bonusDamage;
        private int durability;

        protected Weapon(int bonusDamage)
        {
            this.bonusDamage = bonusDamage;
            this.durability = 100;
        }

        public abstract int UseWeapon();
        public abstract void DecreaseDurability();

        protected int Durability
        {
            get => this.durability;
            set
            {
                if (value >= this.durability)
                {
                    throw new ArgumentException("The weapon hasn't ability to recover!");
                }

                this.durability = value;
            }
        }
    }
}
