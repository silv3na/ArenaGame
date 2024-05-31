namespace ArenaGame
{
    public class Bow : Weapon
    {
        private int arrows;

        public Bow(int bonusDamage, int arrows)
            : base(bonusDamage)
        {
            this.arrows = arrows;
        }

        public override int UseWeapon()
        {
            if (this.Durability <= 0 || arrows <= 0)
            {
                return 0;
            }

            this.arrows -= 1;
            this.DecreaseDurability();

            return this.bonusDamage;
        }

        public override void DecreaseDurability()
        {
            this.Durability -= 10;
        }
    }
}
