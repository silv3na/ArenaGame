namespace ArenaGame
{
    public class Staff : Weapon
    {
        private int shield;

        public Staff(int bonusDamage, int shield)
            : base(bonusDamage)
        {
            this.shield = shield;
        }


        public int UseShield()
        {
            if (shield <= 0)
            {
                return 0;
            }

            return this.shield -= 10;
        }

        public override int UseWeapon()
        {
            if (this.Durability <= 0)
            {
                return 0;
            }

            this.DecreaseDurability();
            return this.bonusDamage;
        }

        public override void DecreaseDurability()
        {
            this.Durability -= 10;
        }
    }
}
